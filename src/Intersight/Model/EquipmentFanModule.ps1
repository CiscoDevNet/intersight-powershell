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

This represents Fan module housing multiple fans for chassis/server.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER Moid
The unique identifier of this Managed Object instance.
.PARAMETER Owners
No description available.
.PARAMETER Tags
No description available.
.PARAMETER VersionContext
No description available.
.PARAMETER Var0ClusterReplicationNetworkPolicy
No description available.
.PARAMETER Parent
No description available.
.PARAMETER OperReason
No description available.
.PARAMETER ComputeRackUnit
No description available.
.PARAMETER EquipmentChassis
No description available.
.PARAMETER EquipmentRackEnclosure
No description available.
.PARAMETER InventoryDeviceInfo
No description available.
.PARAMETER NetworkElement
No description available.
.PARAMETER RegisteredDevice
No description available.
.OUTPUTS

EquipmentFanModule<PSCustomObject>
#>

function Initialize-IntersightEquipmentFanModule {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("equipment.FanModule")]
        [String]
        ${ClassId} = "equipment.FanModule",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("equipment.FanModule")]
        [String]
        ${ObjectType} = "equipment.FanModule",
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
        ${Var0ClusterReplicationNetworkPolicy},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Parent},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("Unknown", "OK", "TemperatureWarning", "TemperatureCritical", "InputVoltageWarning", "InputVoltageCritical", "OutputVoltageWarning", "OutputVoltageCritical", "OutputCurrentWarning", "OutputCurrentCritical", "SpeedWarning", "SpeedCritical", "FanMissingWarning", "FansMissingCritical", "IocardPostWarning", "AsicPostWarning", "FruStateCritical", "FruStateWarning", "AlternateImageWarning", "SelectedImageWarning", "LowMemoryCritical", "LowMemoryWarning", "PowerCritical", "PowerWarning", "ThermalSafeModeCritical", "PsuRedundancyLostCritical", "InputPowerWarning", "InputPowerCritical", "OutputPowerWarning", "OutputPowerCritical", "FanGeneralCritical", "PowerSupplyGeneralCritical", "PowerSupplyInputWarning", "PowerSupplyOutputCritical", "PowerSupplyInputLostWarning", "PowerSupplyUnresponsiveCritical", "FanUnresponsiveCritical", "MemoryUncorrectableError", "MemoryTemperatureWarning", "MemoryTemperatureCritical", "MotherBoardPowerCritical", "MotherBoardTemperatureWarning", "MotherBoardTemperatureCritical", "MotherBoardVoltageWarning", "MotherBoardVoltageCritical", "ProcessorCatErr", "ProcessorThermTrip", "ProcessorTemperatureWarning", "ProcessorTemperatureCritical")]
        [String[]]
        ${OperReason},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ComputeRackUnit},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${EquipmentChassis},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${EquipmentRackEnclosure},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${InventoryDeviceInfo},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NetworkElement},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RegisteredDevice}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightEquipmentFanModule' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$ClassId) {
            throw "invalid value for 'ClassId', 'ClassId' cannot be null."
        }

        if (!$ObjectType) {
            throw "invalid value for 'ObjectType', 'ObjectType' cannot be null."
        }

        
        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "Moid" = ${Moid}
            "Owners" = ${Owners}
            "Tags" = ${Tags}
            "VersionContext" = ${VersionContext}
            "_0_ClusterReplicationNetworkPolicy" = ${Var0ClusterReplicationNetworkPolicy}
            "Parent" = ${Parent}
            "OperReason" = ${OperReason}
            "ComputeRackUnit" = ${ComputeRackUnit}
            "EquipmentChassis" = ${EquipmentChassis}
            "EquipmentRackEnclosure" = ${EquipmentRackEnclosure}
            "InventoryDeviceInfo" = ${InventoryDeviceInfo}
            "NetworkElement" = ${NetworkElement}
            "RegisteredDevice" = ${RegisteredDevice}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to EquipmentFanModule<PSCustomObject>

.DESCRIPTION

Convert from JSON to EquipmentFanModule<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

EquipmentFanModule<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToEquipmentFanModule {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightEquipmentFanModule' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightEquipmentFanModule
        $AllProperties = ("ClassId", "ObjectType", "AccountMoid", "CreateTime", "DomainGroupMoid", "ModTime", "Moid", "Owners", "SharedScope", "Tags", "VersionContext", "_0_ClusterReplicationNetworkPolicy", "Ancestors", "Parent", "PermissionResources", "DisplayNames", "DeviceMoId", "Dn", "Rn", "Model", "Revision", "Serial", "Vendor", "Description", "ModuleId", "OperReason", "OperState", "PartNumber", "Pid", "Presence", "Sku", "TrayId", "Vid", "ComputeRackUnit", "EquipmentChassis", "EquipmentRackEnclosure", "Fans", "InventoryDeviceInfo", "NetworkElement", "RegisteredDevice")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "_0_ClusterReplicationNetworkPolicy"))) { #optional property not found
            $Var0ClusterReplicationNetworkPolicy = $null
        } else {
            $Var0ClusterReplicationNetworkPolicy = $JsonParameters.PSobject.Properties["_0_ClusterReplicationNetworkPolicy"].value
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DeviceMoId"))) { #optional property not found
            $DeviceMoId = $null
        } else {
            $DeviceMoId = $JsonParameters.PSobject.Properties["DeviceMoId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Dn"))) { #optional property not found
            $Dn = $null
        } else {
            $Dn = $JsonParameters.PSobject.Properties["Dn"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Rn"))) { #optional property not found
            $Rn = $null
        } else {
            $Rn = $JsonParameters.PSobject.Properties["Rn"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Model"))) { #optional property not found
            $Model = $null
        } else {
            $Model = $JsonParameters.PSobject.Properties["Model"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Revision"))) { #optional property not found
            $Revision = $null
        } else {
            $Revision = $JsonParameters.PSobject.Properties["Revision"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Serial"))) { #optional property not found
            $Serial = $null
        } else {
            $Serial = $JsonParameters.PSobject.Properties["Serial"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Vendor"))) { #optional property not found
            $Vendor = $null
        } else {
            $Vendor = $JsonParameters.PSobject.Properties["Vendor"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ModuleId"))) { #optional property not found
            $ModuleId = $null
        } else {
            $ModuleId = $JsonParameters.PSobject.Properties["ModuleId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OperReason"))) { #optional property not found
            $OperReason = $null
        } else {
            $OperReason = $JsonParameters.PSobject.Properties["OperReason"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OperState"))) { #optional property not found
            $OperState = $null
        } else {
            $OperState = $JsonParameters.PSobject.Properties["OperState"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PartNumber"))) { #optional property not found
            $PartNumber = $null
        } else {
            $PartNumber = $JsonParameters.PSobject.Properties["PartNumber"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Pid"))) { #optional property not found
            $VarPid = $null
        } else {
            $VarPid = $JsonParameters.PSobject.Properties["Pid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Presence"))) { #optional property not found
            $Presence = $null
        } else {
            $Presence = $JsonParameters.PSobject.Properties["Presence"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Sku"))) { #optional property not found
            $Sku = $null
        } else {
            $Sku = $JsonParameters.PSobject.Properties["Sku"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TrayId"))) { #optional property not found
            $TrayId = $null
        } else {
            $TrayId = $JsonParameters.PSobject.Properties["TrayId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Vid"))) { #optional property not found
            $Vid = $null
        } else {
            $Vid = $JsonParameters.PSobject.Properties["Vid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ComputeRackUnit"))) { #optional property not found
            $ComputeRackUnit = $null
        } else {
            $ComputeRackUnit = $JsonParameters.PSobject.Properties["ComputeRackUnit"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EquipmentChassis"))) { #optional property not found
            $EquipmentChassis = $null
        } else {
            $EquipmentChassis = $JsonParameters.PSobject.Properties["EquipmentChassis"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EquipmentRackEnclosure"))) { #optional property not found
            $EquipmentRackEnclosure = $null
        } else {
            $EquipmentRackEnclosure = $JsonParameters.PSobject.Properties["EquipmentRackEnclosure"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Fans"))) { #optional property not found
            $Fans = $null
        } else {
            $Fans = $JsonParameters.PSobject.Properties["Fans"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InventoryDeviceInfo"))) { #optional property not found
            $InventoryDeviceInfo = $null
        } else {
            $InventoryDeviceInfo = $JsonParameters.PSobject.Properties["InventoryDeviceInfo"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NetworkElement"))) { #optional property not found
            $NetworkElement = $null
        } else {
            $NetworkElement = $JsonParameters.PSobject.Properties["NetworkElement"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RegisteredDevice"))) { #optional property not found
            $RegisteredDevice = $null
        } else {
            $RegisteredDevice = $JsonParameters.PSobject.Properties["RegisteredDevice"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "AccountMoid" = ${AccountMoid}
            "CreateTime" = ${CreateTime}
            "DomainGroupMoid" = ${DomainGroupMoid}
            "ModTime" = ${ModTime}
            "Moid" = ${Moid}
            "Owners" = ${Owners}
            "SharedScope" = ${SharedScope}
            "Tags" = ${Tags}
            "VersionContext" = ${VersionContext}
            "_0_ClusterReplicationNetworkPolicy" = ${Var0ClusterReplicationNetworkPolicy}
            "Ancestors" = ${Ancestors}
            "Parent" = ${Parent}
            "PermissionResources" = ${PermissionResources}
            "DisplayNames" = ${DisplayNames}
            "DeviceMoId" = ${DeviceMoId}
            "Dn" = ${Dn}
            "Rn" = ${Rn}
            "Model" = ${Model}
            "Revision" = ${Revision}
            "Serial" = ${Serial}
            "Vendor" = ${Vendor}
            "Description" = ${Description}
            "ModuleId" = ${ModuleId}
            "OperReason" = ${OperReason}
            "OperState" = ${OperState}
            "PartNumber" = ${PartNumber}
            "Pid" = ${VarPid}
            "Presence" = ${Presence}
            "Sku" = ${Sku}
            "TrayId" = ${TrayId}
            "Vid" = ${Vid}
            "ComputeRackUnit" = ${ComputeRackUnit}
            "EquipmentChassis" = ${EquipmentChassis}
            "EquipmentRackEnclosure" = ${EquipmentRackEnclosure}
            "Fans" = ${Fans}
            "InventoryDeviceInfo" = ${InventoryDeviceInfo}
            "NetworkElement" = ${NetworkElement}
            "RegisteredDevice" = ${RegisteredDevice}
        }

        return $PSO
    }

}

