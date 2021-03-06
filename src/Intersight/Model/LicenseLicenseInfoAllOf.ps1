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

Definition of the list of properties defined in 'license.LicenseInfo', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER EvaluationPeriod
The default Trial or Grace period customer is entitled to.
.PARAMETER ExtraEvaluation
The number of days the trial Trial or Grace period is extended. The trial or grace period can be extended once.
.PARAMETER AccountLicenseData
No description available.
.OUTPUTS

LicenseLicenseInfoAllOf<PSCustomObject>
#>

function Initialize-IntersightLicenseLicenseInfoAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("license.LicenseInfo")]
        [String]
        ${ClassId} = "license.LicenseInfo",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("license.LicenseInfo")]
        [String]
        ${ObjectType} = "license.LicenseInfo",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${EvaluationPeriod},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int64]]
        ${ExtraEvaluation},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${AccountLicenseData}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightLicenseLicenseInfoAllOf' | Write-Debug
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
            "EvaluationPeriod" = ${EvaluationPeriod}
            "ExtraEvaluation" = ${ExtraEvaluation}
            "AccountLicenseData" = ${AccountLicenseData}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to LicenseLicenseInfoAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to LicenseLicenseInfoAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

LicenseLicenseInfoAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToLicenseLicenseInfoAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightLicenseLicenseInfoAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightLicenseLicenseInfoAllOf
        $AllProperties = ("ClassId", "ObjectType", "ActiveAdmin", "DaysLeft", "EndTime", "EnforceMode", "ErrorDesc", "EvaluationPeriod", "ExtraEvaluation", "LicenseCount", "LicenseState", "LicenseType", "StartTime", "TrialAdmin", "AccountLicenseData")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ActiveAdmin"))) { #optional property not found
            $ActiveAdmin = $null
        } else {
            $ActiveAdmin = $JsonParameters.PSobject.Properties["ActiveAdmin"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DaysLeft"))) { #optional property not found
            $DaysLeft = $null
        } else {
            $DaysLeft = $JsonParameters.PSobject.Properties["DaysLeft"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EndTime"))) { #optional property not found
            $EndTime = $null
        } else {
            $EndTime = $JsonParameters.PSobject.Properties["EndTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnforceMode"))) { #optional property not found
            $EnforceMode = $null
        } else {
            $EnforceMode = $JsonParameters.PSobject.Properties["EnforceMode"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ErrorDesc"))) { #optional property not found
            $ErrorDesc = $null
        } else {
            $ErrorDesc = $JsonParameters.PSobject.Properties["ErrorDesc"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EvaluationPeriod"))) { #optional property not found
            $EvaluationPeriod = $null
        } else {
            $EvaluationPeriod = $JsonParameters.PSobject.Properties["EvaluationPeriod"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExtraEvaluation"))) { #optional property not found
            $ExtraEvaluation = $null
        } else {
            $ExtraEvaluation = $JsonParameters.PSobject.Properties["ExtraEvaluation"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LicenseCount"))) { #optional property not found
            $LicenseCount = $null
        } else {
            $LicenseCount = $JsonParameters.PSobject.Properties["LicenseCount"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LicenseState"))) { #optional property not found
            $LicenseState = $null
        } else {
            $LicenseState = $JsonParameters.PSobject.Properties["LicenseState"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LicenseType"))) { #optional property not found
            $LicenseType = $null
        } else {
            $LicenseType = $JsonParameters.PSobject.Properties["LicenseType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StartTime"))) { #optional property not found
            $StartTime = $null
        } else {
            $StartTime = $JsonParameters.PSobject.Properties["StartTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TrialAdmin"))) { #optional property not found
            $TrialAdmin = $null
        } else {
            $TrialAdmin = $JsonParameters.PSobject.Properties["TrialAdmin"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AccountLicenseData"))) { #optional property not found
            $AccountLicenseData = $null
        } else {
            $AccountLicenseData = $JsonParameters.PSobject.Properties["AccountLicenseData"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "ActiveAdmin" = ${ActiveAdmin}
            "DaysLeft" = ${DaysLeft}
            "EndTime" = ${EndTime}
            "EnforceMode" = ${EnforceMode}
            "ErrorDesc" = ${ErrorDesc}
            "EvaluationPeriod" = ${EvaluationPeriod}
            "ExtraEvaluation" = ${ExtraEvaluation}
            "LicenseCount" = ${LicenseCount}
            "LicenseState" = ${LicenseState}
            "LicenseType" = ${LicenseType}
            "StartTime" = ${StartTime}
            "TrialAdmin" = ${TrialAdmin}
            "AccountLicenseData" = ${AccountLicenseData}
        }

        return $PSO
    }

}

