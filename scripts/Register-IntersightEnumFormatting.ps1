#
# Register-IntersightEnumFormatting.ps1
#
# Runs automatically as a NestedModule after Intersight.PowerShell.dll (and Intersight.dll)
# are loaded.  For every public property whose type is an Intersight.Model enum, a
# ScriptProperty of the same name is added to the declaring type so that the property
# returns the EnumMember string value (e.g. "0", "1", "platform-default") instead of
# the C# identifier name (e.g. "_0", "_1", "PlatformDefault").
#

$modelAssembly = [System.AppDomain]::CurrentDomain.GetAssemblies() |
    Where-Object { $_.GetName().Name -eq 'Intersight' } |
    Select-Object -First 1

# Fallback: the assembly may not be in AppDomain yet due to .NET lazy-loading
# (NestedModule scripts run before the root DLL's dependencies are first accessed).
# Explicitly loading from the module directory forces it into the AppDomain.
if ($null -eq $modelAssembly) {
    $intersightDll = Join-Path $PSScriptRoot 'Intersight.dll'
    if (Test-Path $intersightDll) {
        $modelAssembly = [System.Reflection.Assembly]::LoadFrom($intersightDll)
    }
}

if ($null -eq $modelAssembly) { return }

# ---------------------------------------------------------------------------
# Single pass over all exported types:
#   - For Model classes  → register ScriptProperty getter+setter per enum prop
#   - For Model enums    → build reverse lookup map entry
# (Previously two separate loops over GetExportedTypes(); merged for efficiency.
#  The $registered cache was also removed — each type appears exactly once in
#  GetExportedTypes(), so duplicates cannot occur. Update-TypeData -Force handles
#  the rare re-import case.)
# ---------------------------------------------------------------------------
$global:IntersightEnumReverseMap = @{}

foreach ($type in $modelAssembly.GetExportedTypes()) {
    if ($type.Namespace -notlike 'Intersight.Model*') { continue }

    # -----------------------------------------------------------------------
    # Part A – ScriptProperty registrations (for classes)
    # -----------------------------------------------------------------------
    if ($type.IsClass -and -not $type.IsAbstract) {
        foreach ($prop in $type.GetProperties([System.Reflection.BindingFlags]'Public,Instance')) {
            $propType = $prop.PropertyType

            # Unwrap Nullable<T> -> T  (all Intersight enums are Nullable<SomeEnum>)
            if ($propType.IsGenericType -and
                $propType.GetGenericTypeDefinition() -eq [System.Nullable`1]) {
                $propType = $propType.GetGenericArguments()[0]
            }

            # We only care about enum-typed properties
            if (-not $propType.IsEnum) { continue }

            # $propName baked into both scriptblocks at creation time
            $propName = $prop.Name

            # GETTER: returns the friendly string form of the enum value.
            #   - Enums WITH EnumMemberAttribute : returns attr.Value, stripping NUMBER_ prefix if present
            #   - Enums WITHOUT EnumMemberAttribute (e.g. BaudRateEnum): uses C# identifier, strips NUMBER_
            $getter = [scriptblock]::Create(@"
                `$pi  = `$this.GetType().GetProperty('$propName')
                `$raw = `$pi.GetValue(`$this)
                if (`$null -eq `$raw) { return `$null }
                `$member = `$raw.GetType().GetMember(`$raw.ToString())
                if (`$member.Count -gt 0) {
                    `$attr = `$member[0].GetCustomAttributes(
                        [System.Runtime.Serialization.EnumMemberAttribute], `$false)
                    if (`$attr.Count -gt 0) {
                        `$v = `$attr[0].Value
                        if (`$v -match '^NUMBER_(?<n>\d+)$') { return `$Matches['n'] }
                        return `$v
                    }
                }
                `$s = `$raw.ToString()
                if (`$s -match '^NUMBER_(?<n>\d+)$') { return `$Matches['n'] }
                return `$s
"@)

            # SETTER: accepts friendly string ("1", "platform-default", "9600", "NUMBER_9600") or enum object
            #   Pass 1: EnumMemberAttribute value match  (handles "0","1","platform-default", etc.)
            #   Pass 2: direct Enum.Parse by C# identifier (handles BaudRateEnum / no-attribute enums)
            $setter = [scriptblock]::Create(@"
                `$pi       = `$this.GetType().GetProperty('$propName')
                `$propType = `$pi.PropertyType
                if (`$propType.IsGenericType) { `$propType = `$propType.GetGenericArguments()[0] }
                `$inputVal = `$args[0]
                if (`$inputVal -isnot [System.Enum]) {
                    `$key = `$inputVal.ToString()
                    `$candidates = @(`$key)
                    if (`$key -match '^\d+$') { `$candidates += "NUMBER_`$key" }
                    # Pass 1: match via EnumMemberAttribute value
                    foreach (`$candidate in `$candidates) {
                        foreach (`$n in [System.Enum]::GetNames(`$propType)) {
                            `$m = `$propType.GetMember(`$n)[0]
                            `$a = `$m.GetCustomAttributes(
                                     [System.Runtime.Serialization.EnumMemberAttribute], `$false)
                            if (`$a.Count -gt 0 -and `$a[0].Value -eq `$candidate) {
                                `$pi.SetValue(`$this, [System.Enum]::Parse(`$propType, `$n))
                                return
                            }
                        }
                    }
                    # Pass 2: direct Parse by C# identifier (enums without EnumMemberAttribute)
                    foreach (`$candidate in `$candidates) {
                        try { `$pi.SetValue(`$this, [System.Enum]::Parse(`$propType, `$candidate, `$true)); return } catch {}
                    }
                    `$pi.SetValue(`$this, [System.Enum]::Parse(`$propType, `$key, `$true))
                } else {
                    `$pi.SetValue(`$this, `$inputVal)
                }
"@)

            try {
                Update-TypeData `
                    -TypeName    $type.FullName `
                    -MemberType  ScriptProperty `
                    -MemberName  $propName `
                    -Value       $getter `
                    -SecondValue $setter `
                    -Force `
                    -ErrorAction SilentlyContinue
            } catch { }
        }
    }

    # -----------------------------------------------------------------------
    # Part B – Reverse lookup map (for enums)
    # -----------------------------------------------------------------------
    if ($type.IsEnum) {
        $valueMap = @{}
        foreach ($memberName in [System.Enum]::GetNames($type)) {
            $mi      = $type.GetMember($memberName)[0]
            $attr    = $mi.GetCustomAttributes([System.Runtime.Serialization.EnumMemberAttribute], $false)
            $enumObj = [System.Enum]::Parse($type, $memberName)
            if ($attr.Count -gt 0) {
                $apiString            = $attr[0].Value
                $valueMap[$apiString] = $enumObj
                # Also register the bare-number form so "115200" resolves the same as "NUMBER_115200"
                if ($apiString -match '^NUMBER_(?<n>\d+)$') {
                    $valueMap[$Matches['n']] = $enumObj
                }
            } else {
                # No EnumMemberAttribute: the C# identifier IS the value (e.g. NUMBER_9600)
                $valueMap[$memberName] = $enumObj
                if ($memberName -match '^NUMBER_(?<n>\d+)$') {
                    $valueMap[$Matches['n']] = $enumObj
                }
            }
        }

        # Register under multiple keys for flexible lookup:
        #   Full name  : "Intersight.Model.BiosPolicy+CbsCmnApbdisEnum"
        #   Nested name: "BiosPolicy+CbsCmnApbdisEnum"
        #   Short name : "CbsCmnApbdisEnum"
        $global:IntersightEnumReverseMap[$type.FullName] = $valueMap
        $global:IntersightEnumReverseMap[$type.Name]     = $valueMap
        $shortName = $type.Name -replace '^.*\+', ''
        $global:IntersightEnumReverseMap[$shortName]     = $valueMap
    }
}

# ---------------------------------------------------------------------------
# ConvertTo-IntersightEnumValue
#   Converts a friendly API string value ("1", "0", "platform-default", etc.)
#   into the correctly typed .NET enum object required by cmdlet parameters.
#
# Usage:
#   New-IntersightBiosPolicy -CbsCmnApbdis (ConvertTo-IntersightEnumValue CbsCmnApbdisEnum "1")
# ---------------------------------------------------------------------------
function ConvertTo-IntersightEnumValue {
    [CmdletBinding()]
    [OutputType([System.Enum])]
    param(
        # Enum type - accepts a [Type] object or any of the name forms above
        [Parameter(Mandatory, Position = 0)]
        [object] $EnumType,

        # The API string value, e.g. "1", "0", "platform-default", "Auto"
        [Parameter(Mandatory, Position = 1)]
        [string] $Value
    )

    $key = if ($EnumType -is [Type]) { $EnumType.FullName } else { $EnumType.ToString() }

    $valueMap = $global:IntersightEnumReverseMap[$key]
    if ($null -eq $valueMap) {
        throw "Unknown Intersight enum type '$key'. " +
              "Use the type name, e.g. 'CbsCmnApbdisEnum', or the full type like [Intersight.Model.BiosPolicy+CbsCmnApbdisEnum]."
    }

    $result = $valueMap[$Value]
    if ($null -eq $result) {
        $valid = ($valueMap.Keys | Sort-Object) -join "', '"
        throw "Value '$Value' is not valid for '$key'. Valid values: '$valid'"
    }
    return $result
}


function script:Register-IntersightProxies {
    $intersightCmds = Get-Command -Module Intersight.PowerShell -CommandType Cmdlet -ErrorAction SilentlyContinue
    if ($intersightCmds.Count -eq 0) { return }

    foreach ($cmd in $intersightCmds) {
        if ($cmd.Verb -notin @('New','Set','Update','Remove','Initialize')) { continue }

        # Collect enum-typed parameters
        $enumParamTypes = @{}
        foreach ($param in $cmd.Parameters.Values) {
            $pType = $param.ParameterType
            if ($pType.IsGenericType -and
                $pType.GetGenericTypeDefinition() -eq [System.Nullable`1]) {
                $pType = $pType.GetGenericArguments()[0]
            }
            if ($pType.IsEnum -and $pType.Namespace -like 'Intersight.Model*') {
                $enumParamTypes[$param.Name] = $pType.FullName
            }
        }
        if ($enumParamTypes.Count -eq 0) { continue }

        # Generate proxy via ProxyCommand, then:
        #   Patch 1 – replace [...Enum] type annotations with [object] so strings are accepted
        #   Patch 2 – inject string→enum conversion before $steppablePipeline.Begin
        $proxyText = [System.Management.Automation.ProxyCommand]::Create($cmd)
        $proxyText = $proxyText -replace '\[Intersight\.Model\.[^\]]+Enum\]', '[object]'

        # Build conversion lines for every enum param; escape $ for -replace substitution
        $convLines = foreach ($pName in $enumParamTypes.Keys) {
            $typeFull = $enumParamTypes[$pName]
            "        if (`$PSBoundParameters.ContainsKey('$pName') -and `$PSBoundParameters['$pName'] -isnot [System.Enum]) {`n" +
            "            `$_m = `$global:IntersightEnumReverseMap['$typeFull']`n" +
            "            `$_k = `$PSBoundParameters['$pName'].ToString()`n" +
            "            if (`$_m -and `$_m.ContainsKey(`$_k)) { `$PSBoundParameters['$pName'] = `$_m[`$_k] }`n" +
            "        }"
        }
        $convBlock = ($convLines -join "`n") -replace '\$', '$$$$'

        # Inject BEFORE GetSteppablePipeline — it captures @PSBoundParameters eagerly,
        # so conversion must happen before it is called, not just before Begin()
        $proxyText = $proxyText -replace '(\s+)(\$steppablePipeline\s*=\s*\$scriptCmd\.GetSteppablePipeline)',
            "`$1$convBlock`$1`$2"

        $funcDef = "function global:$($cmd.Name) {`n$proxyText`n}"
        try { . ([scriptblock]::Create($funcDef)) } catch { }
    }
}

# Defer to after the module finishes loading
$null = Register-EngineEvent -SourceIdentifier PowerShell.OnIdle -MaxTriggerCount 1 -Action {
    try {
        Register-IntersightProxies
    } catch {
        Write-Warning "Intersight: proxy function registration failed: $_"
    }
}
