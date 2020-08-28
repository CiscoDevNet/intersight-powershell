#
# Cisco Intersight
# Cisco Intersight is a management platform delivered as a service with embedded analytics for your Cisco and 3rd party IT infrastructure. This platform offers an intelligent level of management that enables IT organizations to analyze, simplify, and automate their environments in more advanced ways than the prior generations of tools. Cisco Intersight provides an integrated and intuitive management experience for resources in the traditional data center as well as at the edge. With flexible deployment options to address complex security needs, getting started with Intersight is quick and easy. Cisco Intersight has deep integration with Cisco UCS and HyperFlex systems allowing for remote deployment, configuration, and ongoing maintenance. The model-based deployment works for a single system in a remote location or hundreds of systems in a data center and enables rapid, standardized configuration and deployment. It also streamlines maintaining those systems whether you are working with small or very large configurations. The Intersight OpenAPI document defines the complete set of properties that are returned in the HTTP response. From that perspective, a client can expect that no additional properties are returned, unless these properties are explicitly defined in the OpenAPI document. However, when a client uses an older version of the Intersight OpenAPI document, the server may send additional properties because the software is more recent than the client. In that case, the client may receive properties that it does not know about. Some generated SDKs perform a strict validation of the HTTP response body against the OpenAPI document. This document was created on 2020-07-16T08:45:19Z.
# Version: 1.0.9-2020
# Contact: intersight@cisco.com
# Generated by OpenAPI Generator: https://openapi-generator.tech
#

<#
.SYNOPSIS

No summary available.

.DESCRIPTION

Common attributes of a virtual machine managed by a  hypervisor. Serves as a base class for all concrete virtual machine types. A virtual machine (VM) is what a user and applications interact with. A VM usually runs a guest OS and applications run on the guest OS.

.PARAMETER Moid
The unique identifier of this Managed Object instance.
.PARAMETER Owners
No description available.
.PARAMETER Tags
No description available.
.PARAMETER VersionContext
No description available.
.PARAMETER Parent
No description available.
.PARAMETER RegisteredDevice
No description available.
.PARAMETER Capacity
No description available.
.PARAMETER GuestInfo
No description available.
.PARAMETER HypervisorType
Type of hypervisor where the virtual machine is hosted for example ESXi.
.PARAMETER Identity
The internally generated identity of this VM. This entity is not manipulated by users. It aids in uniquely identifying the virtual machine object. For VMware, this is MOR (managed object reference).
.PARAMETER IpAddress
No description available.
.PARAMETER MemoryCapacity
No description available.
.PARAMETER Name
User-provided name to identify the virtual machine.
.PARAMETER PowerState
Power state of the virtual machine.
.PARAMETER ProcessorCapacity
No description available.
.PARAMETER Uuid
The uuid of this virtual machine. The uuid is internally generated and not user specified.
.OUTPUTS

VirtualizationBaseVirtualMachine<PSCustomObject>
#>

function Initialize-IntersightVirtualizationBaseVirtualMachine {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Moid},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Owners},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Tags},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${VersionContext},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Parent},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RegisteredDevice},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Capacity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${GuestInfo},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("Unknown", "ESXi", "HXAP")]
        [String]
        ${HypervisorType} = "Unknown",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Identity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${IpAddress},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MemoryCapacity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("Unknown", "PoweredOn", "PoweredOff", "StandBy", "Paused")]
        [String]
        ${PowerState} = "Unknown",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ProcessorCapacity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidatePattern("^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$")]
        [String]
        ${Uuid}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightVirtualizationBaseVirtualMachine' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Moid" = ${Moid}
            "Owners" = ${Owners}
            "Tags" = ${Tags}
            "VersionContext" = ${VersionContext}
            "Parent" = ${Parent}
            "RegisteredDevice" = ${RegisteredDevice}
            "Capacity" = ${Capacity}
            "GuestInfo" = ${GuestInfo}
            "HypervisorType" = ${HypervisorType}
            "Identity" = ${Identity}
            "IpAddress" = ${IpAddress}
            "MemoryCapacity" = ${MemoryCapacity}
            "Name" = ${Name}
            "PowerState" = ${PowerState}
            "ProcessorCapacity" = ${ProcessorCapacity}
            "Uuid" = ${Uuid}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to VirtualizationBaseVirtualMachine<PSCustomObject>

.DESCRIPTION

Convert from JSON to VirtualizationBaseVirtualMachine<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

VirtualizationBaseVirtualMachine<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToVirtualizationBaseVirtualMachine {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightVirtualizationBaseVirtualMachine' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightVirtualizationBaseVirtualMachine
        $AllProperties = ("AccountMoid", "ClassId", "CreateTime", "DomainGroupMoid", "ModTime", "Moid", "ObjectType", "Owners", "SharedScope", "Tags", "VersionContext", "Ancestors", "Parent", "PermissionResources", "DisplayNames", "RegisteredDevice", "Capacity", "GuestInfo", "HypervisorType", "Identity", "IpAddress", "MemoryCapacity", "Name", "PowerState", "ProcessorCapacity", "Uuid")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        If ([string]::IsNullOrEmpty($Json) -or $Json -eq "{}") { # empty json
            throw "Error! Empty JSON cannot be serialized due to the required property `ClassId` missing."
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ClassId"))) {
            throw "Error! JSON cannot be serialized due to the required property `ClassId` missing."
        } else {
            $ClassId = $JsonParameters.PSobject.Properties["ClassId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectType"))) {
            throw "Error! JSON cannot be serialized due to the required property `ObjectType` missing."
        } else {
            $ObjectType = $JsonParameters.PSobject.Properties["ObjectType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AccountMoid"))) { #optional property not found
            $AccountMoid = $null
        } else {
            $AccountMoid = $JsonParameters.PSobject.Properties["AccountMoid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CreateTime"))) { #optional property not found
            $CreateTime = $null
        } else {
            $CreateTime = $JsonParameters.PSobject.Properties["CreateTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DomainGroupMoid"))) { #optional property not found
            $DomainGroupMoid = $null
        } else {
            $DomainGroupMoid = $JsonParameters.PSobject.Properties["DomainGroupMoid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ModTime"))) { #optional property not found
            $ModTime = $null
        } else {
            $ModTime = $JsonParameters.PSobject.Properties["ModTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Moid"))) { #optional property not found
            $Moid = $null
        } else {
            $Moid = $JsonParameters.PSobject.Properties["Moid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Owners"))) { #optional property not found
            $Owners = $null
        } else {
            $Owners = $JsonParameters.PSobject.Properties["Owners"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SharedScope"))) { #optional property not found
            $SharedScope = $null
        } else {
            $SharedScope = $JsonParameters.PSobject.Properties["SharedScope"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Tags"))) { #optional property not found
            $Tags = $null
        } else {
            $Tags = $JsonParameters.PSobject.Properties["Tags"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "VersionContext"))) { #optional property not found
            $VersionContext = $null
        } else {
            $VersionContext = $JsonParameters.PSobject.Properties["VersionContext"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Ancestors"))) { #optional property not found
            $Ancestors = $null
        } else {
            $Ancestors = $JsonParameters.PSobject.Properties["Ancestors"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Parent"))) { #optional property not found
            $Parent = $null
        } else {
            $Parent = $JsonParameters.PSobject.Properties["Parent"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PermissionResources"))) { #optional property not found
            $PermissionResources = $null
        } else {
            $PermissionResources = $JsonParameters.PSobject.Properties["PermissionResources"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayNames"))) { #optional property not found
            $DisplayNames = $null
        } else {
            $DisplayNames = $JsonParameters.PSobject.Properties["DisplayNames"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RegisteredDevice"))) { #optional property not found
            $RegisteredDevice = $null
        } else {
            $RegisteredDevice = $JsonParameters.PSobject.Properties["RegisteredDevice"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Capacity"))) { #optional property not found
            $Capacity = $null
        } else {
            $Capacity = $JsonParameters.PSobject.Properties["Capacity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GuestInfo"))) { #optional property not found
            $GuestInfo = $null
        } else {
            $GuestInfo = $JsonParameters.PSobject.Properties["GuestInfo"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HypervisorType"))) { #optional property not found
            $HypervisorType = $null
        } else {
            $HypervisorType = $JsonParameters.PSobject.Properties["HypervisorType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Identity"))) { #optional property not found
            $Identity = $null
        } else {
            $Identity = $JsonParameters.PSobject.Properties["Identity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IpAddress"))) { #optional property not found
            $IpAddress = $null
        } else {
            $IpAddress = $JsonParameters.PSobject.Properties["IpAddress"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MemoryCapacity"))) { #optional property not found
            $MemoryCapacity = $null
        } else {
            $MemoryCapacity = $JsonParameters.PSobject.Properties["MemoryCapacity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PowerState"))) { #optional property not found
            $PowerState = $null
        } else {
            $PowerState = $JsonParameters.PSobject.Properties["PowerState"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProcessorCapacity"))) { #optional property not found
            $ProcessorCapacity = $null
        } else {
            $ProcessorCapacity = $JsonParameters.PSobject.Properties["ProcessorCapacity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Uuid"))) { #optional property not found
            $Uuid = $null
        } else {
            $Uuid = $JsonParameters.PSobject.Properties["Uuid"].value
        }

        $PSO = [PSCustomObject]@{
            "AccountMoid" = ${AccountMoid}
            "ClassId" = ${ClassId}
            "CreateTime" = ${CreateTime}
            "DomainGroupMoid" = ${DomainGroupMoid}
            "ModTime" = ${ModTime}
            "Moid" = ${Moid}
            "ObjectType" = ${ObjectType}
            "Owners" = ${Owners}
            "SharedScope" = ${SharedScope}
            "Tags" = ${Tags}
            "VersionContext" = ${VersionContext}
            "Ancestors" = ${Ancestors}
            "Parent" = ${Parent}
            "PermissionResources" = ${PermissionResources}
            "DisplayNames" = ${DisplayNames}
            "RegisteredDevice" = ${RegisteredDevice}
            "Capacity" = ${Capacity}
            "GuestInfo" = ${GuestInfo}
            "HypervisorType" = ${HypervisorType}
            "Identity" = ${Identity}
            "IpAddress" = ${IpAddress}
            "MemoryCapacity" = ${MemoryCapacity}
            "Name" = ${Name}
            "PowerState" = ${PowerState}
            "ProcessorCapacity" = ${ProcessorCapacity}
            "Uuid" = ${Uuid}
        }

        return $PSO
    }

}
