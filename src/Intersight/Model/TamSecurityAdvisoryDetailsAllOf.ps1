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

Definition of the list of properties defined in 'tam.SecurityAdvisoryDetails', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER BaseScore
CVSS version 3 base score for the security Advisory.
.PARAMETER CveIds
No description available.
.PARAMETER EnvironmentalScore
CVSS version 3 environmental score for the security Advisory.
.PARAMETER Status
Cisco assigned status of the published advisory. Depends on whether the investigation is complete or on-going. * `interim` - The Cisco investigation for the advisory is ongoing. Cisco will issue revisions to the advisory when additional information, including fixed software release data, becomes available. * `final` - Cisco has completed its evaluation of the vulnerability described in the advisory. There will be no further updates unless there is a material change in the nature of the vulnerability.
.PARAMETER TemporalScore
CVSS version 3 temporal score for the security Advisory.
.OUTPUTS

TamSecurityAdvisoryDetailsAllOf<PSCustomObject>
#>

function Initialize-IntersightTamSecurityAdvisoryDetailsAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("tam.SecurityAdvisoryDetails")]
        [String]
        ${ClassId} = "tam.SecurityAdvisoryDetails",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("tam.SecurityAdvisoryDetails")]
        [String]
        ${ObjectType} = "tam.SecurityAdvisoryDetails",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${BaseScore},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${CveIds},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${EnvironmentalScore},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("interim", "final")]
        [String]
        ${Status} = "interim",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Double]]
        ${TemporalScore}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightTamSecurityAdvisoryDetailsAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$ClassId) {
            throw "invalid value for 'ClassId', 'ClassId' cannot be null."
        }

        if (!$ObjectType) {
            throw "invalid value for 'ObjectType', 'ObjectType' cannot be null."
        }

        if ($BaseScore -and $BaseScore -gt 10.0) {
          throw "invalid value for 'BaseScore', must be smaller than or equal to 10.0."
        }

        if ($BaseScore -and $BaseScore -lt 0.0) {
          throw "invalid value for 'BaseScore', must be greater than or equal to 0.0."
        }

        if ($EnvironmentalScore -and $EnvironmentalScore -gt 10.0) {
          throw "invalid value for 'EnvironmentalScore', must be smaller than or equal to 10.0."
        }

        if ($EnvironmentalScore -and $EnvironmentalScore -lt 0.0) {
          throw "invalid value for 'EnvironmentalScore', must be greater than or equal to 0.0."
        }

        if ($TemporalScore -and $TemporalScore -gt 10.0) {
          throw "invalid value for 'TemporalScore', must be smaller than or equal to 10.0."
        }

        if ($TemporalScore -and $TemporalScore -lt 0.0) {
          throw "invalid value for 'TemporalScore', must be greater than or equal to 0.0."
        }

        
        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "BaseScore" = ${BaseScore}
            "CveIds" = ${CveIds}
            "EnvironmentalScore" = ${EnvironmentalScore}
            "Status" = ${Status}
            "TemporalScore" = ${TemporalScore}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to TamSecurityAdvisoryDetailsAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to TamSecurityAdvisoryDetailsAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

TamSecurityAdvisoryDetailsAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToTamSecurityAdvisoryDetailsAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightTamSecurityAdvisoryDetailsAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightTamSecurityAdvisoryDetailsAllOf
        $AllProperties = ("ClassId", "ObjectType", "BaseScore", "CveIds", "EnvironmentalScore", "Status", "TemporalScore")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BaseScore"))) { #optional property not found
            $BaseScore = $null
        } else {
            $BaseScore = $JsonParameters.PSobject.Properties["BaseScore"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CveIds"))) { #optional property not found
            $CveIds = $null
        } else {
            $CveIds = $JsonParameters.PSobject.Properties["CveIds"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EnvironmentalScore"))) { #optional property not found
            $EnvironmentalScore = $null
        } else {
            $EnvironmentalScore = $JsonParameters.PSobject.Properties["EnvironmentalScore"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Status"))) { #optional property not found
            $Status = $null
        } else {
            $Status = $JsonParameters.PSobject.Properties["Status"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TemporalScore"))) { #optional property not found
            $TemporalScore = $null
        } else {
            $TemporalScore = $JsonParameters.PSobject.Properties["TemporalScore"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "BaseScore" = ${BaseScore}
            "CveIds" = ${CveIds}
            "EnvironmentalScore" = ${EnvironmentalScore}
            "Status" = ${Status}
            "TemporalScore" = ${TemporalScore}
        }

        return $PSO
    }

}

