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

Definition of the list of properties defined in 'niaapi.NiaMetadata', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER Content
No description available.
.PARAMETER Date
The date when this package is generated.
.PARAMETER MetadataChksum
Chksum used to check the integrity of the Metadata file downloaded.
.PARAMETER MetadataFilename
The Filename of this Metadata package.
.PARAMETER Version
The version number of the Metadata package.
.OUTPUTS

NiaapiNiaMetadataAllOf<PSCustomObject>
#>

function Initialize-IntersightNiaapiNiaMetadataAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("niaapi.NiaMetadata")]
        [String]
        ${ClassId} = "niaapi.NiaMetadata",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("niaapi.NiaMetadata")]
        [String]
        ${ObjectType} = "niaapi.NiaMetadata",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Content},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${Date},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MetadataChksum},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MetadataFilename},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${Version}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightNiaapiNiaMetadataAllOf' | Write-Debug
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
            "Content" = ${Content}
            "Date" = ${Date}
            "MetadataChksum" = ${MetadataChksum}
            "MetadataFilename" = ${MetadataFilename}
            "Version" = ${Version}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to NiaapiNiaMetadataAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to NiaapiNiaMetadataAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

NiaapiNiaMetadataAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToNiaapiNiaMetadataAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightNiaapiNiaMetadataAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightNiaapiNiaMetadataAllOf
        $AllProperties = ("ClassId", "ObjectType", "Content", "Date", "MetadataChksum", "MetadataFilename", "Version")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Content"))) { #optional property not found
            $Content = $null
        } else {
            $Content = $JsonParameters.PSobject.Properties["Content"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Date"))) { #optional property not found
            $Date = $null
        } else {
            $Date = $JsonParameters.PSobject.Properties["Date"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MetadataChksum"))) { #optional property not found
            $MetadataChksum = $null
        } else {
            $MetadataChksum = $JsonParameters.PSobject.Properties["MetadataChksum"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MetadataFilename"))) { #optional property not found
            $MetadataFilename = $null
        } else {
            $MetadataFilename = $JsonParameters.PSobject.Properties["MetadataFilename"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Version"))) { #optional property not found
            $Version = $null
        } else {
            $Version = $JsonParameters.PSobject.Properties["Version"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "Content" = ${Content}
            "Date" = ${Date}
            "MetadataChksum" = ${MetadataChksum}
            "MetadataFilename" = ${MetadataFilename}
            "Version" = ${Version}
        }

        return $PSO
    }

}

