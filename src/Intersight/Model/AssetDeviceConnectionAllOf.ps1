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

Definition of the list of properties defined in 'asset.DeviceConnection', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property. The enum values provides the list of concrete types that can be instantiated from this abstract type.
.OUTPUTS

AssetDeviceConnectionAllOf<PSCustomObject>
#>

function Initialize-IntersightAssetDeviceConnectionAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("asset.ClusterMember", "asset.DeviceRegistration")]
        [String]
        ${ClassId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("asset.ClusterMember", "asset.DeviceRegistration")]
        [String]
        ${ObjectType}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightAssetDeviceConnectionAllOf' | Write-Debug
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
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to AssetDeviceConnectionAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to AssetDeviceConnectionAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

AssetDeviceConnectionAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToAssetDeviceConnectionAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightAssetDeviceConnectionAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightAssetDeviceConnectionAllOf
        $AllProperties = ("ClassId", "ObjectType", "ApiVersion", "AppPartitionNumber", "ConnectionId", "ConnectionReason", "ConnectionStatus", "ConnectionStatusLastChangeTime", "ConnectorVersion", "DeviceExternalIpAddress", "ProxyApp")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ApiVersion"))) { #optional property not found
            $ApiVersion = $null
        } else {
            $ApiVersion = $JsonParameters.PSobject.Properties["ApiVersion"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AppPartitionNumber"))) { #optional property not found
            $AppPartitionNumber = $null
        } else {
            $AppPartitionNumber = $JsonParameters.PSobject.Properties["AppPartitionNumber"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConnectionId"))) { #optional property not found
            $ConnectionId = $null
        } else {
            $ConnectionId = $JsonParameters.PSobject.Properties["ConnectionId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConnectionReason"))) { #optional property not found
            $ConnectionReason = $null
        } else {
            $ConnectionReason = $JsonParameters.PSobject.Properties["ConnectionReason"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConnectionStatus"))) { #optional property not found
            $ConnectionStatus = $null
        } else {
            $ConnectionStatus = $JsonParameters.PSobject.Properties["ConnectionStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConnectionStatusLastChangeTime"))) { #optional property not found
            $ConnectionStatusLastChangeTime = $null
        } else {
            $ConnectionStatusLastChangeTime = $JsonParameters.PSobject.Properties["ConnectionStatusLastChangeTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConnectorVersion"))) { #optional property not found
            $ConnectorVersion = $null
        } else {
            $ConnectorVersion = $JsonParameters.PSobject.Properties["ConnectorVersion"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DeviceExternalIpAddress"))) { #optional property not found
            $DeviceExternalIpAddress = $null
        } else {
            $DeviceExternalIpAddress = $JsonParameters.PSobject.Properties["DeviceExternalIpAddress"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProxyApp"))) { #optional property not found
            $ProxyApp = $null
        } else {
            $ProxyApp = $JsonParameters.PSobject.Properties["ProxyApp"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "ApiVersion" = ${ApiVersion}
            "AppPartitionNumber" = ${AppPartitionNumber}
            "ConnectionId" = ${ConnectionId}
            "ConnectionReason" = ${ConnectionReason}
            "ConnectionStatus" = ${ConnectionStatus}
            "ConnectionStatusLastChangeTime" = ${ConnectionStatusLastChangeTime}
            "ConnectorVersion" = ${ConnectorVersion}
            "DeviceExternalIpAddress" = ${DeviceExternalIpAddress}
            "ProxyApp" = ${ProxyApp}
        }

        return $PSO
    }

}

