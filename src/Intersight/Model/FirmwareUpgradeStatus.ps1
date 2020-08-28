#
# Cisco Intersight
# Cisco Intersight is a management platform delivered as a service with embedded analytics for your Cisco and 3rd party IT infrastructure. This platform offers an intelligent level of management that enables IT organizations to analyze, simplify, and automate their environments in more advanced ways than the prior generations of tools. Cisco Intersight provides an integrated and intuitive management experience for resources in the traditional data center as well as at the edge. With flexible deployment options to address complex security needs, getting started with Intersight is quick and easy. Cisco Intersight has deep integration with Cisco UCS and HyperFlex systems allowing for remote deployment, configuration, and ongoing maintenance. The model-based deployment works for a single system in a remote location or hundreds of systems in a data center and enables rapid, standardized configuration and deployment. It also streamlines maintaining those systems whether you are working with small or very large configurations. The Intersight OpenAPI document defines the complete set of properties that are returned in the HTTP response. From that perspective, a client can expect that no additional properties are returned, unless these properties are explicitly defined in the OpenAPI document. However, when a client uses an older version of the Intersight OpenAPI document, the server may send additional properties because the software is more recent than the client. In that case, the client may receive properties that it does not know about. Some generated SDKs perform a strict validation of the HTTP response body against the OpenAPI document. This document was created on 2020-07-16T08:45:19Z.
# Version: 1.0.9-2020
# Contact: intersight@cisco.com
# Generated by OpenAPI Generator: https://openapi-generator.tech
#

<#
.SYNOPSIS

No summary available.

.DESCRIPTION

The status for the upgrade operation to include the status for the download and upgrade stages.

.PARAMETER Moid
The unique identifier of this Managed Object instance.
.PARAMETER Owners
No description available.
.PARAMETER Tags
No description available.
.PARAMETER VersionContext
No description available.
.PARAMETER Parent
No description available.
.PARAMETER DownloadError
The error message from the endpoint during the download.
.PARAMETER DownloadMessage
The message from the endpoint during the download.} type: string
.PARAMETER DownloadPercentage
The percentage of the image downloaded in the endpoint.
.PARAMETER DownloadProgress
The download progress of the file represented as a percentage between 0% and 100%. If progress reporting is not possible a value of -1 is sent.
.PARAMETER DownloadRetries
The number of retries the plugin attempted before succeeding or failing the download.
.PARAMETER DownloadStage
The image download stages. Example:downloading, flashing.
.PARAMETER EpPowerStatus
The server power status after the upgrade request is submitted in the endpoint.
.PARAMETER OverallError
The reason for the operation failure.
.PARAMETER OverallPercentage
The overall percentage of the operation.
.PARAMETER Overallstatus
The overall status of the operation.
.PARAMETER PendingType
Pending reason for the upgrade waiting.
.PARAMETER Sha256checksum
The sha256checksum of the downloaded file as calculated by the download plugin after successfully downloading a file.
.PARAMETER Upgrade
No description available.
.PARAMETER Workflow
No description available.
.OUTPUTS

FirmwareUpgradeStatus<PSCustomObject>
#>

function Initialize-IntersightFirmwareUpgradeStatus {
    [CmdletBinding()]
    Param (
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
        ${Parent},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DownloadError},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DownloadMessage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${DownloadPercentage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${DownloadProgress},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${DownloadRetries},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${DownloadStage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("none", "powered on", "powered off")]
        [String]
        ${EpPowerStatus} = "none",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${OverallError},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${OverallPercentage},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("none", "started", "prepare initiating", "prepare initiated", "prepared", "download initiating", "download initiated", "downloading", "downloaded", "upgrade initiating on fabric A", "upgrade initiated on fabric A", "upgrading fabric A", "rebooting fabric A", "upgraded fabric A", "upgrade initiating on fabric B", "upgrade initiated on fabric B", "upgrading fabric B", "rebooting fabric B", "upgraded fabric B", "upgrade initiating", "upgrade initiated", "upgrading", "oob images staging", "oob images staged", "rebooting", "upgraded", "success", "failed", "terminated", "pending", "ReadyForCache", "Caching", "Cached", "CachingFailed")]
        [String]
        ${Overallstatus} = "none",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("none", "pending for next reboot")]
        [String]
        ${PendingType} = "none",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Sha256checksum},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Upgrade},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Workflow}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightFirmwareUpgradeStatus' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Moid" = ${Moid}
            "Owners" = ${Owners}
            "Tags" = ${Tags}
            "VersionContext" = ${VersionContext}
            "Parent" = ${Parent}
            "DownloadError" = ${DownloadError}
            "DownloadMessage" = ${DownloadMessage}
            "DownloadPercentage" = ${DownloadPercentage}
            "DownloadProgress" = ${DownloadProgress}
            "DownloadRetries" = ${DownloadRetries}
            "DownloadStage" = ${DownloadStage}
            "EpPowerStatus" = ${EpPowerStatus}
            "OverallError" = ${OverallError}
            "OverallPercentage" = ${OverallPercentage}
            "Overallstatus" = ${Overallstatus}
            "PendingType" = ${PendingType}
            "Sha256checksum" = ${Sha256checksum}
            "Upgrade" = ${Upgrade}
            "Workflow" = ${Workflow}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to FirmwareUpgradeStatus<PSCustomObject>

.DESCRIPTION

Convert from JSON to FirmwareUpgradeStatus<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

FirmwareUpgradeStatus<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToFirmwareUpgradeStatus {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightFirmwareUpgradeStatus' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightFirmwareUpgradeStatus
        $AllProperties = ("AccountMoid", "ClassId", "CreateTime", "DomainGroupMoid", "ModTime", "Moid", "ObjectType", "Owners", "SharedScope", "Tags", "VersionContext", "Ancestors", "Parent", "PermissionResources", "DisplayNames", "DownloadError", "DownloadMessage", "DownloadPercentage", "DownloadProgress", "DownloadRetries", "DownloadStage", "EpPowerStatus", "OverallError", "OverallPercentage", "Overallstatus", "PendingType", "Sha256checksum", "Upgrade", "Workflow")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        If ([string]::IsNullOrEmpty($Json) -or $Json -eq "{}") { # empty json
            throw "Error! Empty JSON cannot be serialized due to the required property `ClassId` missing."
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ClassId"))) {
            throw "Error! JSON cannot be serialized due to the required property `ClassId` missing."
        } else {
            $ClassId = $JsonParameters.PSobject.Properties["ClassId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectType"))) {
            throw "Error! JSON cannot be serialized due to the required property `ObjectType` missing."
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DownloadError"))) { #optional property not found
            $DownloadError = $null
        } else {
            $DownloadError = $JsonParameters.PSobject.Properties["DownloadError"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DownloadMessage"))) { #optional property not found
            $DownloadMessage = $null
        } else {
            $DownloadMessage = $JsonParameters.PSobject.Properties["DownloadMessage"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DownloadPercentage"))) { #optional property not found
            $DownloadPercentage = $null
        } else {
            $DownloadPercentage = $JsonParameters.PSobject.Properties["DownloadPercentage"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DownloadProgress"))) { #optional property not found
            $DownloadProgress = $null
        } else {
            $DownloadProgress = $JsonParameters.PSobject.Properties["DownloadProgress"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DownloadRetries"))) { #optional property not found
            $DownloadRetries = $null
        } else {
            $DownloadRetries = $JsonParameters.PSobject.Properties["DownloadRetries"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DownloadStage"))) { #optional property not found
            $DownloadStage = $null
        } else {
            $DownloadStage = $JsonParameters.PSobject.Properties["DownloadStage"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EpPowerStatus"))) { #optional property not found
            $EpPowerStatus = $null
        } else {
            $EpPowerStatus = $JsonParameters.PSobject.Properties["EpPowerStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OverallError"))) { #optional property not found
            $OverallError = $null
        } else {
            $OverallError = $JsonParameters.PSobject.Properties["OverallError"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OverallPercentage"))) { #optional property not found
            $OverallPercentage = $null
        } else {
            $OverallPercentage = $JsonParameters.PSobject.Properties["OverallPercentage"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Overallstatus"))) { #optional property not found
            $Overallstatus = $null
        } else {
            $Overallstatus = $JsonParameters.PSobject.Properties["Overallstatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PendingType"))) { #optional property not found
            $PendingType = $null
        } else {
            $PendingType = $JsonParameters.PSobject.Properties["PendingType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Sha256checksum"))) { #optional property not found
            $Sha256checksum = $null
        } else {
            $Sha256checksum = $JsonParameters.PSobject.Properties["Sha256checksum"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Upgrade"))) { #optional property not found
            $Upgrade = $null
        } else {
            $Upgrade = $JsonParameters.PSobject.Properties["Upgrade"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Workflow"))) { #optional property not found
            $Workflow = $null
        } else {
            $Workflow = $JsonParameters.PSobject.Properties["Workflow"].value
        }

        $PSO = [PSCustomObject]@{
            "AccountMoid" = ${AccountMoid}
            "ClassId" = ${ClassId}
            "CreateTime" = ${CreateTime}
            "DomainGroupMoid" = ${DomainGroupMoid}
            "ModTime" = ${ModTime}
            "Moid" = ${Moid}
            "ObjectType" = ${ObjectType}
            "Owners" = ${Owners}
            "SharedScope" = ${SharedScope}
            "Tags" = ${Tags}
            "VersionContext" = ${VersionContext}
            "Ancestors" = ${Ancestors}
            "Parent" = ${Parent}
            "PermissionResources" = ${PermissionResources}
            "DisplayNames" = ${DisplayNames}
            "DownloadError" = ${DownloadError}
            "DownloadMessage" = ${DownloadMessage}
            "DownloadPercentage" = ${DownloadPercentage}
            "DownloadProgress" = ${DownloadProgress}
            "DownloadRetries" = ${DownloadRetries}
            "DownloadStage" = ${DownloadStage}
            "EpPowerStatus" = ${EpPowerStatus}
            "OverallError" = ${OverallError}
            "OverallPercentage" = ${OverallPercentage}
            "Overallstatus" = ${Overallstatus}
            "PendingType" = ${PendingType}
            "Sha256checksum" = ${Sha256checksum}
            "Upgrade" = ${Upgrade}
            "Workflow" = ${Workflow}
        }

        return $PSO
    }

}
