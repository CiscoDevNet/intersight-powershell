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

Definition of the list of properties defined in 'firmware.ComponentMeta', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER ComponentLabel
The name of the component in the compressed HSU bundle.
.PARAMETER ComponentType
The type of component image within the distributable. * `ALL` - This represents all the components. * `ALL,HDD` - This represents all the components plus the HDDs. * `None` - This represents none of the components. * `NXOS` - This represents NXOS components. * `IOM` - This represents IOM components. * `PSU` - This represents PSU components. * `CIMC` - This represents CIMC components. * `BIOS` - This represents BIOS components. * `PCIE` - This represents PCIE components. * `Drive` - This represents Storage components. * `DIMM` - This represents DIMM components. * `BoardController` - This represents Board Controller components. * `StorageController` - This represents Storage Controller components. * `HBA` - This represents HBA components. * `GPU` - This represents GPU components. * `SasExpander` - This represents SasExpander components. * `MSwitch` - This represents mSwitch components. * `CMC` - This represents CMC components.
.PARAMETER Description
This shows the description of component image within the distributable.
.PARAMETER Disruption
The type of disruption on each component. For example, host reboot, automatic power cycle, and manual power cycle. * `None` - Indicates that the component did not receive a disruption request. * `HostReboot` - Indicates that the component received a host reboot request. * `EndpointReboot` - Indicates that the component received an end point reboot request. * `ManualPowerCycle` - Indicates that the component received a manual power cycle request. * `AutomaticPowerCycle` - Indicates that the component received an automatic power cycle request.
.PARAMETER ImagePath
This shows the path of component image within the distributable.
.PARAMETER IsOobSupported
If set, the component can be updated through out-of-band management, else, is updated through host service utility boot.
.PARAMETER Model
The model of the component image in the distributable.
.PARAMETER OobManageability
No description available.
.PARAMETER PackedVersion
The image version of components packaged in the distributable.
.PARAMETER RedfishUrl
The redfish target for each component.
.PARAMETER Vendor
The version of component image in the distributable.
.OUTPUTS

FirmwareComponentMetaAllOf<PSCustomObject>
#>

function Initialize-IntersightFirmwareComponentMetaAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("firmware.ComponentMeta")]
        [String]
        ${ClassId} = "firmware.ComponentMeta",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("firmware.ComponentMeta")]
        [String]
        ${ObjectType} = "firmware.ComponentMeta",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ComponentLabel},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("ALL", "ALL,HDD", "None", "NXOS", "IOM", "PSU", "CIMC", "BIOS", "PCIE", "Drive", "DIMM", "BoardController", "StorageController", "HBA", "GPU", "SasExpander", "MSwitch", "CMC")]
        [String]
        ${ComponentType} = "ALL",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Description},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("None", "HostReboot", "EndpointReboot", "ManualPowerCycle", "AutomaticPowerCycle")]
        [String]
        ${Disruption} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ImagePath},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsOobSupported},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Model},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("None", "Update", "Inventory", "Activate", "Config")]
        [String[]]
        ${OobManageability},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${PackedVersion},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RedfishUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Vendor}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightFirmwareComponentMetaAllOf' | Write-Debug
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
            "ComponentLabel" = ${ComponentLabel}
            "ComponentType" = ${ComponentType}
            "Description" = ${Description}
            "Disruption" = ${Disruption}
            "ImagePath" = ${ImagePath}
            "IsOobSupported" = ${IsOobSupported}
            "Model" = ${Model}
            "OobManageability" = ${OobManageability}
            "PackedVersion" = ${PackedVersion}
            "RedfishUrl" = ${RedfishUrl}
            "Vendor" = ${Vendor}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to FirmwareComponentMetaAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to FirmwareComponentMetaAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

FirmwareComponentMetaAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToFirmwareComponentMetaAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightFirmwareComponentMetaAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightFirmwareComponentMetaAllOf
        $AllProperties = ("ClassId", "ObjectType", "ComponentLabel", "ComponentType", "Description", "Disruption", "ImagePath", "IsOobSupported", "Model", "OobManageability", "PackedVersion", "RedfishUrl", "Vendor")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ComponentLabel"))) { #optional property not found
            $ComponentLabel = $null
        } else {
            $ComponentLabel = $JsonParameters.PSobject.Properties["ComponentLabel"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ComponentType"))) { #optional property not found
            $ComponentType = $null
        } else {
            $ComponentType = $JsonParameters.PSobject.Properties["ComponentType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Disruption"))) { #optional property not found
            $Disruption = $null
        } else {
            $Disruption = $JsonParameters.PSobject.Properties["Disruption"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ImagePath"))) { #optional property not found
            $ImagePath = $null
        } else {
            $ImagePath = $JsonParameters.PSobject.Properties["ImagePath"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsOobSupported"))) { #optional property not found
            $IsOobSupported = $null
        } else {
            $IsOobSupported = $JsonParameters.PSobject.Properties["IsOobSupported"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Model"))) { #optional property not found
            $Model = $null
        } else {
            $Model = $JsonParameters.PSobject.Properties["Model"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OobManageability"))) { #optional property not found
            $OobManageability = $null
        } else {
            $OobManageability = $JsonParameters.PSobject.Properties["OobManageability"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PackedVersion"))) { #optional property not found
            $PackedVersion = $null
        } else {
            $PackedVersion = $JsonParameters.PSobject.Properties["PackedVersion"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RedfishUrl"))) { #optional property not found
            $RedfishUrl = $null
        } else {
            $RedfishUrl = $JsonParameters.PSobject.Properties["RedfishUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Vendor"))) { #optional property not found
            $Vendor = $null
        } else {
            $Vendor = $JsonParameters.PSobject.Properties["Vendor"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "ComponentLabel" = ${ComponentLabel}
            "ComponentType" = ${ComponentType}
            "Description" = ${Description}
            "Disruption" = ${Disruption}
            "ImagePath" = ${ImagePath}
            "IsOobSupported" = ${IsOobSupported}
            "Model" = ${Model}
            "OobManageability" = ${OobManageability}
            "PackedVersion" = ${PackedVersion}
            "RedfishUrl" = ${RedfishUrl}
            "Vendor" = ${Vendor}
        }

        return $PSO
    }

}

