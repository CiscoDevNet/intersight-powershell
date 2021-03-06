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

A logical NOT expression filter.

.PARAMETER Type
The filter type.
.PARAMETER ExtractionFn
All filters except the ""spatial"" filter support extraction functions. An extraction function is defined by setting the ""extractionFn"" field on a filter. See Extraction function for more details on extraction functions. If specified, the extraction function will be used to transform input values before the filter is applied. The example below shows a selector filter combined with an extraction function. This filter will transform input values according to the values defined in the lookup map; transformed values will then be matched with the string ""bar_1"".
.PARAMETER Field
No description available.
.OUTPUTS

TelemetryDruidNotFilter<PSCustomObject>
#>

function Initialize-IntersightTelemetryDruidNotFilter {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("selector", "columnComparison", "regex", "and", "or", "not")]
        [String]
        ${Type},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ExtractionFn},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Field}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightTelemetryDruidNotFilter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$Type) {
            throw "invalid value for 'Type', 'Type' cannot be null."
        }

        if (!$Field) {
            throw "invalid value for 'Field', 'Field' cannot be null."
        }

        
        $PSO = [PSCustomObject]@{
            "type" = ${Type}
            "extractionFn" = ${ExtractionFn}
            "field" = ${Field}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to TelemetryDruidNotFilter<PSCustomObject>

.DESCRIPTION

Convert from JSON to TelemetryDruidNotFilter<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

TelemetryDruidNotFilter<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToTelemetryDruidNotFilter {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightTelemetryDruidNotFilter' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightTelemetryDruidNotFilter
        $AllProperties = ("type", "extractionFn", "field")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        If ([string]::IsNullOrEmpty($Json) -or $Json -eq "{}") { # empty json
            throw "Error! Empty JSON cannot be serialized due to the required property 'type' missing."
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "type"))) {
            throw "Error! JSON cannot be serialized due to the required property 'type' missing."
        } else {
            $Type = $JsonParameters.PSobject.Properties["type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "field"))) {
            throw "Error! JSON cannot be serialized due to the required property 'field' missing."
        } else {
            $Field = $JsonParameters.PSobject.Properties["field"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "extractionFn"))) { #optional property not found
            $ExtractionFn = $null
        } else {
            $ExtractionFn = $JsonParameters.PSobject.Properties["extractionFn"].value
        }

        $PSO = [PSCustomObject]@{
            "type" = ${Type}
            "extractionFn" = ${ExtractionFn}
            "field" = ${Field}
        }

        return $PSO
    }

}

