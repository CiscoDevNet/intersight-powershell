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

Definition of the list of properties defined in 'firmware.BaseDistributable', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property. The enum values provides the list of concrete types that can be instantiated from this abstract type.
.PARAMETER ComponentMeta
No description available.
.PARAMETER Mdfid
The mdfid of the image provided by cisco.com.
.PARAMETER Model
The endpoint model for which this firmware image is applicable.
.PARAMETER RecommendedBuild
The build which is recommended by Cisco.
.PARAMETER ReleaseNotesUrl
The url for the release notes of this image.
.PARAMETER SupportedModels
No description available.
.PARAMETER Vendor
The vendor or publisher of this file.
.PARAMETER DistributableMetas
An array of relationships to firmwareDistributableMeta resources.
.PARAMETER Release
No description available.
.OUTPUTS

FirmwareBaseDistributableAllOf<PSCustomObject>
#>

function Initialize-IntersightFirmwareBaseDistributableAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("firmware.Distributable", "firmware.DriverDistributable", "firmware.ServerConfigurationUtilityDistributable", "software.ApplianceDistributable", "software.HclMeta", "software.HyperflexBundleDistributable", "software.HyperflexDistributable", "software.SolutionDistributable", "software.UcsdBundleDistributable", "software.UcsdDistributable")]
        [String]
        ${ClassId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("firmware.Distributable", "firmware.DriverDistributable", "firmware.ServerConfigurationUtilityDistributable", "software.ApplianceDistributable", "software.HclMeta", "software.HyperflexBundleDistributable", "software.HyperflexDistributable", "software.SolutionDistributable", "software.UcsdBundleDistributable", "software.UcsdDistributable")]
        [String]
        ${ObjectType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${ComponentMeta},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Mdfid},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Model},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${RecommendedBuild},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ReleaseNotesUrl},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${SupportedModels},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Vendor} = "Cisco",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${DistributableMetas},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Release}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightFirmwareBaseDistributableAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$ClassId) {
            throw "invalid value for 'ClassId', 'ClassId' cannot be null."
        }

        if (!$ObjectType) {
            throw "invalid value for 'ObjectType', 'ObjectType' cannot be null."
        }

        if (!$SupportedModels -and $SupportedModels.length -lt 1) {
            throw "invalid value for 'SupportedModels', number of items must be greater than or equal to 1."
        }

        
        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "ComponentMeta" = ${ComponentMeta}
            "Mdfid" = ${Mdfid}
            "Model" = ${Model}
            "RecommendedBuild" = ${RecommendedBuild}
            "ReleaseNotesUrl" = ${ReleaseNotesUrl}
            "SupportedModels" = ${SupportedModels}
            "Vendor" = ${Vendor}
            "DistributableMetas" = ${DistributableMetas}
            "Release" = ${Release}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to FirmwareBaseDistributableAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to FirmwareBaseDistributableAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

FirmwareBaseDistributableAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToFirmwareBaseDistributableAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightFirmwareBaseDistributableAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightFirmwareBaseDistributableAllOf
        $AllProperties = ("ClassId", "ObjectType", "BundleType", "ComponentMeta", "Guid", "Mdfid", "Model", "PlatformType", "RecommendedBuild", "ReleaseNotesUrl", "SoftwareTypeId", "SupportedModels", "Vendor", "DistributableMetas", "Release")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BundleType"))) { #optional property not found
            $BundleType = $null
        } else {
            $BundleType = $JsonParameters.PSobject.Properties["BundleType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ComponentMeta"))) { #optional property not found
            $ComponentMeta = $null
        } else {
            $ComponentMeta = $JsonParameters.PSobject.Properties["ComponentMeta"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Guid"))) { #optional property not found
            $Guid = $null
        } else {
            $Guid = $JsonParameters.PSobject.Properties["Guid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Mdfid"))) { #optional property not found
            $Mdfid = $null
        } else {
            $Mdfid = $JsonParameters.PSobject.Properties["Mdfid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Model"))) { #optional property not found
            $Model = $null
        } else {
            $Model = $JsonParameters.PSobject.Properties["Model"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PlatformType"))) { #optional property not found
            $PlatformType = $null
        } else {
            $PlatformType = $JsonParameters.PSobject.Properties["PlatformType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RecommendedBuild"))) { #optional property not found
            $RecommendedBuild = $null
        } else {
            $RecommendedBuild = $JsonParameters.PSobject.Properties["RecommendedBuild"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ReleaseNotesUrl"))) { #optional property not found
            $ReleaseNotesUrl = $null
        } else {
            $ReleaseNotesUrl = $JsonParameters.PSobject.Properties["ReleaseNotesUrl"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SoftwareTypeId"))) { #optional property not found
            $SoftwareTypeId = $null
        } else {
            $SoftwareTypeId = $JsonParameters.PSobject.Properties["SoftwareTypeId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SupportedModels"))) { #optional property not found
            $SupportedModels = $null
        } else {
            $SupportedModels = $JsonParameters.PSobject.Properties["SupportedModels"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Vendor"))) { #optional property not found
            $Vendor = $null
        } else {
            $Vendor = $JsonParameters.PSobject.Properties["Vendor"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DistributableMetas"))) { #optional property not found
            $DistributableMetas = $null
        } else {
            $DistributableMetas = $JsonParameters.PSobject.Properties["DistributableMetas"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Release"))) { #optional property not found
            $Release = $null
        } else {
            $Release = $JsonParameters.PSobject.Properties["Release"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "BundleType" = ${BundleType}
            "ComponentMeta" = ${ComponentMeta}
            "Guid" = ${Guid}
            "Mdfid" = ${Mdfid}
            "Model" = ${Model}
            "PlatformType" = ${PlatformType}
            "RecommendedBuild" = ${RecommendedBuild}
            "ReleaseNotesUrl" = ${ReleaseNotesUrl}
            "SoftwareTypeId" = ${SoftwareTypeId}
            "SupportedModels" = ${SupportedModels}
            "Vendor" = ${Vendor}
            "DistributableMetas" = ${DistributableMetas}
            "Release" = ${Release}
        }

        return $PSO
    }

}

