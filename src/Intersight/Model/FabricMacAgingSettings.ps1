#
# Cisco Intersight
# Cisco Intersight is a management platform delivered as a service with embedded analytics for your Cisco and 3rd party IT infrastructure. This platform offers an intelligent level of management that enables IT organizations to analyze, simplify, and automate their environments in more advanced ways than the prior generations of tools. Cisco Intersight provides an integrated and intuitive management experience for resources in the traditional data center as well as at the edge. With flexible deployment options to address complex security needs, getting started with Intersight is quick and easy. Cisco Intersight has deep integration with Cisco UCS and HyperFlex systems allowing for remote deployment, configuration, and ongoing maintenance. The model-based deployment works for a single system in a remote location or hundreds of systems in a data center and enables rapid, standardized configuration and deployment. It also streamlines maintaining those systems whether you are working with small or very large configurations. The Intersight OpenAPI document defines the complete set of properties that are returned in the HTTP response. From that perspective, a client can expect that no additional properties are returned, unless these properties are explicitly defined in the OpenAPI document. However, when a client uses an older version of the Intersight OpenAPI document, the server may send additional properties because the software is more recent than the client. In that case, the client may receive properties that it does not know about. Some generated SDKs perform a strict validation of the HTTP response body against the OpenAPI document. This document was created on 2021-02-05T15:05:56Z.
# Version: 1.0.9-3562
# Contact: intersight@cisco.com
# Generated by OpenAPI Generator: https://openapi-generator.tech
#

<#
.SYNOPSIS

No summary available.

.DESCRIPTION

Mac Address Table Aging option and time settings.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER MacAgingOption
This specifies one of the option to configure the MAC address aging time. * `Default` - This option sets the default MAC address aging time to 14500 seconds for End Host mode. * `Custom` - This option allows the the user to configure the MAC address aging time on the switch. For Switch Model UCS-FI-6454 or higher, the valid range is 120 to 918000 seconds and the switch will set the lower multiple of 5 of the given time. * `Never` - This option disables the MAC address aging process and never allows the MAC address entries to get removed from the table.
.PARAMETER MacAgingTime
Define the MAC address aging time in seconds. This field is valid when the ""Custom"" MAC address aging option is selected.
.OUTPUTS

FabricMacAgingSettings<PSCustomObject>
#>

function Initialize-IntersightFabricMacAgingSettings {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("fabric.MacAgingSettings")]
        [String]
        ${ClassId} = "fabric.MacAgingSettings",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("fabric.MacAgingSettings")]
        [String]
        ${ObjectType} = "fabric.MacAgingSettings",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("Default", "Custom", "Never")]
        [String]
        ${MacAgingOption} = "Default",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${MacAgingTime}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightFabricMacAgingSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$ClassId) {
            throw "invalid value for 'ClassId', 'ClassId' cannot be null."
        }

        if (!$ObjectType) {
            throw "invalid value for 'ObjectType', 'ObjectType' cannot be null."
        }

        if ($MacAgingTime -and $MacAgingTime -gt 1000000) {
          throw "invalid value for 'MacAgingTime', must be smaller than or equal to 1000000."
        }

        if ($MacAgingTime -and $MacAgingTime -lt 1) {
          throw "invalid value for 'MacAgingTime', must be greater than or equal to 1."
        }

        
        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "MacAgingOption" = ${MacAgingOption}
            "MacAgingTime" = ${MacAgingTime}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to FabricMacAgingSettings<PSCustomObject>

.DESCRIPTION

Convert from JSON to FabricMacAgingSettings<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

FabricMacAgingSettings<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToFabricMacAgingSettings {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightFabricMacAgingSettings' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightFabricMacAgingSettings
        $AllProperties = ("ClassId", "ObjectType", "MacAgingOption", "MacAgingTime")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        If ([string]::IsNullOrEmpty($Json) -or $Json -eq "{}") { # empty json
            throw "Error! Empty JSON cannot be serialized due to the required property 'ClassId' missing."
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ClassId"))) {
            throw "Error! JSON cannot be serialized due to the required property 'ClassId' missing."
        } else {
            $ClassId = $JsonParameters.PSobject.Properties["ClassId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectType"))) {
            throw "Error! JSON cannot be serialized due to the required property 'ObjectType' missing."
        } else {
            $ObjectType = $JsonParameters.PSobject.Properties["ObjectType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MacAgingOption"))) { #optional property not found
            $MacAgingOption = $null
        } else {
            $MacAgingOption = $JsonParameters.PSobject.Properties["MacAgingOption"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MacAgingTime"))) { #optional property not found
            $MacAgingTime = $null
        } else {
            $MacAgingTime = $JsonParameters.PSobject.Properties["MacAgingTime"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "MacAgingOption" = ${MacAgingOption}
            "MacAgingTime" = ${MacAgingTime}
        }

        return $PSO
    }

}
