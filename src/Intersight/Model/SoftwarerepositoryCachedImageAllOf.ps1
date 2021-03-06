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

Definition of the list of properties defined in 'softwarerepository.CachedImage', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER Action
The action to be performed on the imported file. If 'PreCache' is set, the image will be cached in endpoint. If 'Evict' is set, the cached file will be removed. Applicable in Intersight appliance deployment. If 'Cancel' is set, the ImportState is marked as 'Failed'. Applicable for local machine source. * `None` - No action should be taken on the imported file. * `GeneratePreSignedUploadUrl` - Generate pre signed URL of file for importing into the repository. * `GeneratePreSignedDownloadUrl` - Generate pre signed URL of file in the repository to download. * `CompleteImportProcess` - Mark that the import process of the file into the repository is complete. * `MarkImportFailed` - Mark to indicate that the import process of the file into the repository failed. * `PreCache` - Cache the file into the Intersight Appliance. * `Cancel` - The cancel import process for the file into the repository. * `Extract` - The action to extract the file in the external repository. * `Evict` - Evict the cached file from the Intersight Appliance.
.PARAMETER RegisteredWorkflows
No description available.
.PARAMETER File
No description available.
.PARAMETER NetworkElement
No description available.
.OUTPUTS

SoftwarerepositoryCachedImageAllOf<PSCustomObject>
#>

function Initialize-IntersightSoftwarerepositoryCachedImageAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("softwarerepository.CachedImage")]
        [String]
        ${ClassId} = "softwarerepository.CachedImage",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("softwarerepository.CachedImage")]
        [String]
        ${ObjectType} = "softwarerepository.CachedImage",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("None", "GeneratePreSignedUploadUrl", "GeneratePreSignedDownloadUrl", "CompleteImportProcess", "MarkImportFailed", "PreCache", "Cancel", "Extract", "Evict")]
        [String]
        ${Action} = "None",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${RegisteredWorkflows},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${File},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${NetworkElement}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightSoftwarerepositoryCachedImageAllOf' | Write-Debug
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
            "Action" = ${Action}
            "RegisteredWorkflows" = ${RegisteredWorkflows}
            "File" = ${File}
            "NetworkElement" = ${NetworkElement}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to SoftwarerepositoryCachedImageAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to SoftwarerepositoryCachedImageAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

SoftwarerepositoryCachedImageAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToSoftwarerepositoryCachedImageAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightSoftwarerepositoryCachedImageAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightSoftwarerepositoryCachedImageAllOf
        $AllProperties = ("ClassId", "ObjectType", "Action", "CacheState", "CachedTime", "LastAccessTime", "Md5sum", "OriginalSha512sum", "Path", "RegisteredWorkflows", "UsedCount", "File", "NetworkElement")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Action"))) { #optional property not found
            $Action = $null
        } else {
            $Action = $JsonParameters.PSobject.Properties["Action"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CacheState"))) { #optional property not found
            $CacheState = $null
        } else {
            $CacheState = $JsonParameters.PSobject.Properties["CacheState"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CachedTime"))) { #optional property not found
            $CachedTime = $null
        } else {
            $CachedTime = $JsonParameters.PSobject.Properties["CachedTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastAccessTime"))) { #optional property not found
            $LastAccessTime = $null
        } else {
            $LastAccessTime = $JsonParameters.PSobject.Properties["LastAccessTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Md5sum"))) { #optional property not found
            $Md5sum = $null
        } else {
            $Md5sum = $JsonParameters.PSobject.Properties["Md5sum"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalSha512sum"))) { #optional property not found
            $OriginalSha512sum = $null
        } else {
            $OriginalSha512sum = $JsonParameters.PSobject.Properties["OriginalSha512sum"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Path"))) { #optional property not found
            $Path = $null
        } else {
            $Path = $JsonParameters.PSobject.Properties["Path"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RegisteredWorkflows"))) { #optional property not found
            $RegisteredWorkflows = $null
        } else {
            $RegisteredWorkflows = $JsonParameters.PSobject.Properties["RegisteredWorkflows"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UsedCount"))) { #optional property not found
            $UsedCount = $null
        } else {
            $UsedCount = $JsonParameters.PSobject.Properties["UsedCount"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "File"))) { #optional property not found
            $File = $null
        } else {
            $File = $JsonParameters.PSobject.Properties["File"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NetworkElement"))) { #optional property not found
            $NetworkElement = $null
        } else {
            $NetworkElement = $JsonParameters.PSobject.Properties["NetworkElement"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "Action" = ${Action}
            "CacheState" = ${CacheState}
            "CachedTime" = ${CachedTime}
            "LastAccessTime" = ${LastAccessTime}
            "Md5sum" = ${Md5sum}
            "OriginalSha512sum" = ${OriginalSha512sum}
            "Path" = ${Path}
            "RegisteredWorkflows" = ${RegisteredWorkflows}
            "UsedCount" = ${UsedCount}
            "File" = ${File}
            "NetworkElement" = ${NetworkElement}
        }

        return $PSO
    }

}

