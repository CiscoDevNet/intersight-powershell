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

Storage Flex Util Physical Drive.

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
.PARAMETER BlockSize
Block size of the FlexUtil Physical drive.
.PARAMETER Capacity
Capacity of the FlexUtil Physical drive.
.PARAMETER Controller
Type of the Physical Drive Controller.
.PARAMETER DrivesEnabled
The number of drives enabled in the FlexUtil Physical Drive.
.PARAMETER Health
Health of the FlexUtil Physical drive.
.PARAMETER ManufacturerDate
Manufacturing date of the FlexUtil Physical Drive.
.PARAMETER ManufacturerId
Manufacturer identity of the FlexUtil Physical Drive.
.PARAMETER OemId
The OEM Identifier of the FlexUtil physical drive.
.PARAMETER PartitionCount
The number of partitions present on the FlexUtil Physical Drive.
.PARAMETER PdStatus
Status of the FlexUtil Physical Drive.
.PARAMETER PhysicalDrive
The type of physical drive. Example - microSD.
.PARAMETER ProductName
Product name of the FlexUtil Physical Drive.
.PARAMETER ProductRevision
Product revision of the FlexUtil Physical Drive.
.PARAMETER ReadErrorCount
Read error count of the FlexUtil Physical Drive.
.PARAMETER ReadErrorThreshold
Read error threshold for FlexUtil Physical Drive.
.PARAMETER WriteEnabled
Write access state of the FlexUtil Physical Drive.
.PARAMETER WriteErrorCount
Write error count of the FlexUtil Physical Drive.
.PARAMETER WriteErrorThreshold
Write error threshold for FlexUtil Physical Drive.
.PARAMETER InventoryDeviceInfo
No description available.
.PARAMETER RegisteredDevice
No description available.
.PARAMETER StorageFlexUtilController
No description available.
.OUTPUTS

StorageFlexUtilPhysicalDrive<PSCustomObject>
#>

function Initialize-IntersightStorageFlexUtilPhysicalDrive {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("storage.FlexUtilPhysicalDrive")]
        [String]
        ${ClassId} = "storage.FlexUtilPhysicalDrive",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("storage.FlexUtilPhysicalDrive")]
        [String]
        ${ObjectType} = "storage.FlexUtilPhysicalDrive",
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
        [String]
        ${BlockSize},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Capacity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Controller},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DrivesEnabled},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Health},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ManufacturerDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ManufacturerId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${OemId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PartitionCount},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PdStatus},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PhysicalDrive},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ProductName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ProductRevision},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ReadErrorCount},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ReadErrorThreshold},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WriteEnabled},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WriteErrorCount},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${WriteErrorThreshold},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${InventoryDeviceInfo},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RegisteredDevice},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${StorageFlexUtilController}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightStorageFlexUtilPhysicalDrive' | Write-Debug
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
            "BlockSize" = ${BlockSize}
            "Capacity" = ${Capacity}
            "Controller" = ${Controller}
            "DrivesEnabled" = ${DrivesEnabled}
            "Health" = ${Health}
            "ManufacturerDate" = ${ManufacturerDate}
            "ManufacturerId" = ${ManufacturerId}
            "OemId" = ${OemId}
            "PartitionCount" = ${PartitionCount}
            "PdStatus" = ${PdStatus}
            "PhysicalDrive" = ${PhysicalDrive}
            "ProductName" = ${ProductName}
            "ProductRevision" = ${ProductRevision}
            "ReadErrorCount" = ${ReadErrorCount}
            "ReadErrorThreshold" = ${ReadErrorThreshold}
            "WriteEnabled" = ${WriteEnabled}
            "WriteErrorCount" = ${WriteErrorCount}
            "WriteErrorThreshold" = ${WriteErrorThreshold}
            "InventoryDeviceInfo" = ${InventoryDeviceInfo}
            "RegisteredDevice" = ${RegisteredDevice}
            "StorageFlexUtilController" = ${StorageFlexUtilController}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to StorageFlexUtilPhysicalDrive<PSCustomObject>

.DESCRIPTION

Convert from JSON to StorageFlexUtilPhysicalDrive<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

StorageFlexUtilPhysicalDrive<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToStorageFlexUtilPhysicalDrive {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightStorageFlexUtilPhysicalDrive' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightStorageFlexUtilPhysicalDrive
        $AllProperties = ("ClassId", "ObjectType", "AccountMoid", "CreateTime", "DomainGroupMoid", "ModTime", "Moid", "Owners", "SharedScope", "Tags", "VersionContext", "_0_ClusterReplicationNetworkPolicy", "Ancestors", "Parent", "PermissionResources", "DisplayNames", "DeviceMoId", "Dn", "Rn", "Model", "Revision", "Serial", "Vendor", "BlockSize", "Capacity", "Controller", "DrivesEnabled", "Health", "ManufacturerDate", "ManufacturerId", "OemId", "PartitionCount", "PdStatus", "PhysicalDrive", "ProductName", "ProductRevision", "ReadErrorCount", "ReadErrorThreshold", "WriteEnabled", "WriteErrorCount", "WriteErrorThreshold", "InventoryDeviceInfo", "RegisteredDevice", "StorageFlexUtilController")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BlockSize"))) { #optional property not found
            $BlockSize = $null
        } else {
            $BlockSize = $JsonParameters.PSobject.Properties["BlockSize"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Capacity"))) { #optional property not found
            $Capacity = $null
        } else {
            $Capacity = $JsonParameters.PSobject.Properties["Capacity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Controller"))) { #optional property not found
            $Controller = $null
        } else {
            $Controller = $JsonParameters.PSobject.Properties["Controller"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DrivesEnabled"))) { #optional property not found
            $DrivesEnabled = $null
        } else {
            $DrivesEnabled = $JsonParameters.PSobject.Properties["DrivesEnabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Health"))) { #optional property not found
            $Health = $null
        } else {
            $Health = $JsonParameters.PSobject.Properties["Health"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ManufacturerDate"))) { #optional property not found
            $ManufacturerDate = $null
        } else {
            $ManufacturerDate = $JsonParameters.PSobject.Properties["ManufacturerDate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ManufacturerId"))) { #optional property not found
            $ManufacturerId = $null
        } else {
            $ManufacturerId = $JsonParameters.PSobject.Properties["ManufacturerId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OemId"))) { #optional property not found
            $OemId = $null
        } else {
            $OemId = $JsonParameters.PSobject.Properties["OemId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PartitionCount"))) { #optional property not found
            $PartitionCount = $null
        } else {
            $PartitionCount = $JsonParameters.PSobject.Properties["PartitionCount"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PdStatus"))) { #optional property not found
            $PdStatus = $null
        } else {
            $PdStatus = $JsonParameters.PSobject.Properties["PdStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PhysicalDrive"))) { #optional property not found
            $PhysicalDrive = $null
        } else {
            $PhysicalDrive = $JsonParameters.PSobject.Properties["PhysicalDrive"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProductName"))) { #optional property not found
            $ProductName = $null
        } else {
            $ProductName = $JsonParameters.PSobject.Properties["ProductName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProductRevision"))) { #optional property not found
            $ProductRevision = $null
        } else {
            $ProductRevision = $JsonParameters.PSobject.Properties["ProductRevision"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ReadErrorCount"))) { #optional property not found
            $ReadErrorCount = $null
        } else {
            $ReadErrorCount = $JsonParameters.PSobject.Properties["ReadErrorCount"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ReadErrorThreshold"))) { #optional property not found
            $ReadErrorThreshold = $null
        } else {
            $ReadErrorThreshold = $JsonParameters.PSobject.Properties["ReadErrorThreshold"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WriteEnabled"))) { #optional property not found
            $WriteEnabled = $null
        } else {
            $WriteEnabled = $JsonParameters.PSobject.Properties["WriteEnabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WriteErrorCount"))) { #optional property not found
            $WriteErrorCount = $null
        } else {
            $WriteErrorCount = $JsonParameters.PSobject.Properties["WriteErrorCount"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WriteErrorThreshold"))) { #optional property not found
            $WriteErrorThreshold = $null
        } else {
            $WriteErrorThreshold = $JsonParameters.PSobject.Properties["WriteErrorThreshold"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InventoryDeviceInfo"))) { #optional property not found
            $InventoryDeviceInfo = $null
        } else {
            $InventoryDeviceInfo = $JsonParameters.PSobject.Properties["InventoryDeviceInfo"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RegisteredDevice"))) { #optional property not found
            $RegisteredDevice = $null
        } else {
            $RegisteredDevice = $JsonParameters.PSobject.Properties["RegisteredDevice"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StorageFlexUtilController"))) { #optional property not found
            $StorageFlexUtilController = $null
        } else {
            $StorageFlexUtilController = $JsonParameters.PSobject.Properties["StorageFlexUtilController"].value
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
            "BlockSize" = ${BlockSize}
            "Capacity" = ${Capacity}
            "Controller" = ${Controller}
            "DrivesEnabled" = ${DrivesEnabled}
            "Health" = ${Health}
            "ManufacturerDate" = ${ManufacturerDate}
            "ManufacturerId" = ${ManufacturerId}
            "OemId" = ${OemId}
            "PartitionCount" = ${PartitionCount}
            "PdStatus" = ${PdStatus}
            "PhysicalDrive" = ${PhysicalDrive}
            "ProductName" = ${ProductName}
            "ProductRevision" = ${ProductRevision}
            "ReadErrorCount" = ${ReadErrorCount}
            "ReadErrorThreshold" = ${ReadErrorThreshold}
            "WriteEnabled" = ${WriteEnabled}
            "WriteErrorCount" = ${WriteErrorCount}
            "WriteErrorThreshold" = ${WriteErrorThreshold}
            "InventoryDeviceInfo" = ${InventoryDeviceInfo}
            "RegisteredDevice" = ${RegisteredDevice}
            "StorageFlexUtilController" = ${StorageFlexUtilController}
        }

        return $PSO
    }

}

