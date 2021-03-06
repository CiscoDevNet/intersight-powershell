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

Impact of the chassis endpoint during the upgrade operation.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER ComputationError
Details for the error that occurred during the reboot validation analysis.
.PARAMETER ComputationStatusDetail
The computation status of the estimate operation for a component. * `Inprogress` - Upgrade impact calculation is in progress. * `Completed` - Upgrade impact calculation is completed. * `Unavailable` - Upgrade impact is not available since the image is not present in the Fabric Interconnect. * `Failed` - Upgrade impact is not available due to an unknown error.
.PARAMETER DomainName
The endpoint type or name.
.PARAMETER EndPoint
A reference to a REST resource, uniquely identified by object type and MOID.
.PARAMETER FirmwareVersion
The current firmware version of the component.
.PARAMETER ImpactType
The impact type of the endpoint, whether a reboot is required or not. * `NoReboot` - A reboot is not required for the endpoint after upgrade. * `Reboot` - A reboot is required to the endpoint after upgrade.
.PARAMETER Model
The model details of the component.
.PARAMETER TargetFirmwareVersion
The target firmware version of the component.
.PARAMETER VersionImpact
The change of version impact for the endpoint. * `None` - No change in version for the component. * `Upgrade` - The component will be upgraded. * `Downgrade` - The component will be downgraded.
.PARAMETER ImpactDetail
No description available.
.PARAMETER Name
Name of the chassis that will be affected by the upgrade.
.PARAMETER UserLabel
Details for the chassis that will be impacted by the upgrade.
.OUTPUTS

FirmwareChassisUpgradeImpact<PSCustomObject>
#>

function Initialize-IntersightFirmwareChassisUpgradeImpact {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("firmware.ChassisUpgradeImpact")]
        [String]
        ${ClassId} = "firmware.ChassisUpgradeImpact",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("firmware.ChassisUpgradeImpact")]
        [String]
        ${ObjectType} = "firmware.ChassisUpgradeImpact",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ComputationError},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("Inprogress", "Completed", "Unavailable", "Failed")]
        [String]
        ${ComputationStatusDetail} = "Inprogress",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DomainName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${EndPoint},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${FirmwareVersion},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("NoReboot", "Reboot")]
        [String]
        ${ImpactType} = "NoReboot",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Model},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TargetFirmwareVersion},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("None", "Upgrade", "Downgrade")]
        [String]
        ${VersionImpact} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${ImpactDetail},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Name},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${UserLabel}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightFirmwareChassisUpgradeImpact' | Write-Debug
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
            "ComputationError" = ${ComputationError}
            "ComputationStatusDetail" = ${ComputationStatusDetail}
            "DomainName" = ${DomainName}
            "EndPoint" = ${EndPoint}
            "FirmwareVersion" = ${FirmwareVersion}
            "ImpactType" = ${ImpactType}
            "Model" = ${Model}
            "TargetFirmwareVersion" = ${TargetFirmwareVersion}
            "VersionImpact" = ${VersionImpact}
            "ImpactDetail" = ${ImpactDetail}
            "Name" = ${Name}
            "UserLabel" = ${UserLabel}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to FirmwareChassisUpgradeImpact<PSCustomObject>

.DESCRIPTION

Convert from JSON to FirmwareChassisUpgradeImpact<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

FirmwareChassisUpgradeImpact<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToFirmwareChassisUpgradeImpact {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightFirmwareChassisUpgradeImpact' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightFirmwareChassisUpgradeImpact
        $AllProperties = ("ClassId", "ObjectType", "ComputationError", "ComputationStatusDetail", "DomainName", "EndPoint", "FirmwareVersion", "ImpactType", "Model", "TargetFirmwareVersion", "VersionImpact", "ImpactDetail", "Name", "UserLabel")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ComputationError"))) { #optional property not found
            $ComputationError = $null
        } else {
            $ComputationError = $JsonParameters.PSobject.Properties["ComputationError"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ComputationStatusDetail"))) { #optional property not found
            $ComputationStatusDetail = $null
        } else {
            $ComputationStatusDetail = $JsonParameters.PSobject.Properties["ComputationStatusDetail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DomainName"))) { #optional property not found
            $DomainName = $null
        } else {
            $DomainName = $JsonParameters.PSobject.Properties["DomainName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EndPoint"))) { #optional property not found
            $EndPoint = $null
        } else {
            $EndPoint = $JsonParameters.PSobject.Properties["EndPoint"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FirmwareVersion"))) { #optional property not found
            $FirmwareVersion = $null
        } else {
            $FirmwareVersion = $JsonParameters.PSobject.Properties["FirmwareVersion"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ImpactType"))) { #optional property not found
            $ImpactType = $null
        } else {
            $ImpactType = $JsonParameters.PSobject.Properties["ImpactType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Model"))) { #optional property not found
            $Model = $null
        } else {
            $Model = $JsonParameters.PSobject.Properties["Model"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TargetFirmwareVersion"))) { #optional property not found
            $TargetFirmwareVersion = $null
        } else {
            $TargetFirmwareVersion = $JsonParameters.PSobject.Properties["TargetFirmwareVersion"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "VersionImpact"))) { #optional property not found
            $VersionImpact = $null
        } else {
            $VersionImpact = $JsonParameters.PSobject.Properties["VersionImpact"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ImpactDetail"))) { #optional property not found
            $ImpactDetail = $null
        } else {
            $ImpactDetail = $JsonParameters.PSobject.Properties["ImpactDetail"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Name"))) { #optional property not found
            $Name = $null
        } else {
            $Name = $JsonParameters.PSobject.Properties["Name"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UserLabel"))) { #optional property not found
            $UserLabel = $null
        } else {
            $UserLabel = $JsonParameters.PSobject.Properties["UserLabel"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "ComputationError" = ${ComputationError}
            "ComputationStatusDetail" = ${ComputationStatusDetail}
            "DomainName" = ${DomainName}
            "EndPoint" = ${EndPoint}
            "FirmwareVersion" = ${FirmwareVersion}
            "ImpactType" = ${ImpactType}
            "Model" = ${Model}
            "TargetFirmwareVersion" = ${TargetFirmwareVersion}
            "VersionImpact" = ${VersionImpact}
            "ImpactDetail" = ${ImpactDetail}
            "Name" = ${Name}
            "UserLabel" = ${UserLabel}
        }

        return $PSO
    }

}

