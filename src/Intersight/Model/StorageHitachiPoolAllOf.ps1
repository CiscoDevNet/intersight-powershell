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

Definition of the list of properties defined in 'storage.HitachiPool', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER Array
No description available.
.PARAMETER RegisteredDevice
No description available.
.OUTPUTS

StorageHitachiPoolAllOf<PSCustomObject>
#>

function Initialize-IntersightStorageHitachiPoolAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("storage.HitachiPool")]
        [String]
        ${ClassId} = "storage.HitachiPool",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("storage.HitachiPool")]
        [String]
        ${ObjectType} = "storage.HitachiPool",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Array},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RegisteredDevice}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightStorageHitachiPoolAllOf' | Write-Debug
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
            "Array" = ${Array}
            "RegisteredDevice" = ${RegisteredDevice}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to StorageHitachiPoolAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to StorageHitachiPoolAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

StorageHitachiPoolAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToStorageHitachiPoolAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightStorageHitachiPoolAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightStorageHitachiPoolAllOf
        $AllProperties = ("ClassId", "ObjectType", "BlockingModeBlockade", "BlockingModeFull", "DepletionThreshold", "IsShrinking", "MonitoringMode", "MonitoringStatus", "PoolActionMode", "ProgressOfReplacing", "TotalReservedCapacity", "WarningThreshold", "Array", "RegisteredDevice")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BlockingModeBlockade"))) { #optional property not found
            $BlockingModeBlockade = $null
        } else {
            $BlockingModeBlockade = $JsonParameters.PSobject.Properties["BlockingModeBlockade"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BlockingModeFull"))) { #optional property not found
            $BlockingModeFull = $null
        } else {
            $BlockingModeFull = $JsonParameters.PSobject.Properties["BlockingModeFull"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DepletionThreshold"))) { #optional property not found
            $DepletionThreshold = $null
        } else {
            $DepletionThreshold = $JsonParameters.PSobject.Properties["DepletionThreshold"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsShrinking"))) { #optional property not found
            $IsShrinking = $null
        } else {
            $IsShrinking = $JsonParameters.PSobject.Properties["IsShrinking"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MonitoringMode"))) { #optional property not found
            $MonitoringMode = $null
        } else {
            $MonitoringMode = $JsonParameters.PSobject.Properties["MonitoringMode"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MonitoringStatus"))) { #optional property not found
            $MonitoringStatus = $null
        } else {
            $MonitoringStatus = $JsonParameters.PSobject.Properties["MonitoringStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PoolActionMode"))) { #optional property not found
            $PoolActionMode = $null
        } else {
            $PoolActionMode = $JsonParameters.PSobject.Properties["PoolActionMode"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProgressOfReplacing"))) { #optional property not found
            $ProgressOfReplacing = $null
        } else {
            $ProgressOfReplacing = $JsonParameters.PSobject.Properties["ProgressOfReplacing"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TotalReservedCapacity"))) { #optional property not found
            $TotalReservedCapacity = $null
        } else {
            $TotalReservedCapacity = $JsonParameters.PSobject.Properties["TotalReservedCapacity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "WarningThreshold"))) { #optional property not found
            $WarningThreshold = $null
        } else {
            $WarningThreshold = $JsonParameters.PSobject.Properties["WarningThreshold"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Array"))) { #optional property not found
            $Array = $null
        } else {
            $Array = $JsonParameters.PSobject.Properties["Array"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RegisteredDevice"))) { #optional property not found
            $RegisteredDevice = $null
        } else {
            $RegisteredDevice = $JsonParameters.PSobject.Properties["RegisteredDevice"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "BlockingModeBlockade" = ${BlockingModeBlockade}
            "BlockingModeFull" = ${BlockingModeFull}
            "DepletionThreshold" = ${DepletionThreshold}
            "IsShrinking" = ${IsShrinking}
            "MonitoringMode" = ${MonitoringMode}
            "MonitoringStatus" = ${MonitoringStatus}
            "PoolActionMode" = ${PoolActionMode}
            "ProgressOfReplacing" = ${ProgressOfReplacing}
            "TotalReservedCapacity" = ${TotalReservedCapacity}
            "WarningThreshold" = ${WarningThreshold}
            "Array" = ${Array}
            "RegisteredDevice" = ${RegisteredDevice}
        }

        return $PSO
    }

}

