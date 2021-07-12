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

NetApp IP interface is a logical interface.

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
.PARAMETER Services
No description available.
.PARAMETER ArrayController
No description available.
.PARAMETER NetAppEthernetPort
No description available.
.PARAMETER Tenant
No description available.
.OUTPUTS

StorageNetAppIpInterface<PSCustomObject>
#>

function Initialize-IntersightStorageNetAppIpInterface {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("storage.NetAppIpInterface")]
        [String]
        ${ClassId} = "storage.NetAppIpInterface",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("storage.NetAppIpInterface")]
        [String]
        ${ObjectType} = "storage.NetAppIpInterface",
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
        [String[]]
        ${Services},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ArrayController},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NetAppEthernetPort},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Tenant}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightStorageNetAppIpInterface' | Write-Debug
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
            "Services" = ${Services}
            "ArrayController" = ${ArrayController}
            "NetAppEthernetPort" = ${NetAppEthernetPort}
            "Tenant" = ${Tenant}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to StorageNetAppIpInterface<PSCustomObject>

.DESCRIPTION

Convert from JSON to StorageNetAppIpInterface<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

StorageNetAppIpInterface<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToStorageNetAppIpInterface {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightStorageNetAppIpInterface' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightStorageNetAppIpInterface
        $AllProperties = ("ClassId", "ObjectType", "AccountMoid", "CreateTime", "DomainGroupMoid", "ModTime", "Moid", "Owners", "SharedScope", "Tags", "VersionContext", "_0_ClusterReplicationNetworkPolicy", "Ancestors", "Parent", "PermissionResources", "DisplayNames", "Enabled", "HomeNode", "HomePort", "IpAddress", "IpFamily", "Name", "Netmask", "ServicePolicyName", "ServicePolicyUuid", "Services", "State", "Uuid", "ArrayController", "NetAppEthernetPort", "Tenant")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Enabled"))) { #optional property not found
            $Enabled = $null
        } else {
            $Enabled = $JsonParameters.PSobject.Properties["Enabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HomeNode"))) { #optional property not found
            $HomeNode = $null
        } else {
            $HomeNode = $JsonParameters.PSobject.Properties["HomeNode"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "HomePort"))) { #optional property not found
            $HomePort = $null
        } else {
            $HomePort = $JsonParameters.PSobject.Properties["HomePort"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IpAddress"))) { #optional property not found
            $IpAddress = $null
        } else {
            $IpAddress = $JsonParameters.PSobject.Properties["IpAddress"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IpFamily"))) { #optional property not found
            $IpFamily = $null
        } else {
            $IpFamily = $JsonParameters.PSobject.Properties["IpFamily"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Netmask"))) { #optional property not found
            $Netmask = $null
        } else {
            $Netmask = $JsonParameters.PSobject.Properties["Netmask"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServicePolicyName"))) { #optional property not found
            $ServicePolicyName = $null
        } else {
            $ServicePolicyName = $JsonParameters.PSobject.Properties["ServicePolicyName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServicePolicyUuid"))) { #optional property not found
            $ServicePolicyUuid = $null
        } else {
            $ServicePolicyUuid = $JsonParameters.PSobject.Properties["ServicePolicyUuid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Services"))) { #optional property not found
            $Services = $null
        } else {
            $Services = $JsonParameters.PSobject.Properties["Services"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "State"))) { #optional property not found
            $State = $null
        } else {
            $State = $JsonParameters.PSobject.Properties["State"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Uuid"))) { #optional property not found
            $Uuid = $null
        } else {
            $Uuid = $JsonParameters.PSobject.Properties["Uuid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ArrayController"))) { #optional property not found
            $ArrayController = $null
        } else {
            $ArrayController = $JsonParameters.PSobject.Properties["ArrayController"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NetAppEthernetPort"))) { #optional property not found
            $NetAppEthernetPort = $null
        } else {
            $NetAppEthernetPort = $JsonParameters.PSobject.Properties["NetAppEthernetPort"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Tenant"))) { #optional property not found
            $Tenant = $null
        } else {
            $Tenant = $JsonParameters.PSobject.Properties["Tenant"].value
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
            "Enabled" = ${Enabled}
            "HomeNode" = ${HomeNode}
            "HomePort" = ${HomePort}
            "IpAddress" = ${IpAddress}
            "IpFamily" = ${IpFamily}
            "Name" = ${Name}
            "Netmask" = ${Netmask}
            "ServicePolicyName" = ${ServicePolicyName}
            "ServicePolicyUuid" = ${ServicePolicyUuid}
            "Services" = ${Services}
            "State" = ${State}
            "Uuid" = ${Uuid}
            "ArrayController" = ${ArrayController}
            "NetAppEthernetPort" = ${NetAppEthernetPort}
            "Tenant" = ${Tenant}
        }

        return $PSO
    }

}
