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

Time boundary queries return the earliest and latest data points of a data set.

.PARAMETER QueryType
null
.PARAMETER DataSource
No description available.
.PARAMETER Intervals
A JSON Object representing ISO-8601 Intervals. This defines the time ranges to run the query over. If an interval is not specified, the query will use a default interval that spans a configurable period before the end time of the most recent segment.
.PARAMETER ToInclude
A JSON Object representing what columns should be included in the result. Defaults to ""all"".
.PARAMETER Merge
Merge all individual segment metadata results into a single result.
.PARAMETER Context
No description available.
.PARAMETER AnalysisTypes
A list of Strings specifying what column properties (e.g. cardinality, size) should be calculated and returned in the result. Defaults to [""cardinality"", ""interval"", ""minmax""], but can be overridden with using the segment metadata query config. * cardinality - in the result will return the estimated floor of cardinality for each column. Only relevant for dimension columns. * minmax - Estimated min/max values for each column. Only relevant for dimension columns. * size - in the result will contain the estimated total segment byte size as if the data were stored in text format. * intervals - in the result will contain the list of intervals associated with the queried segments. * timestampSpec - in the result will contain timestampSpec of data stored in segments. This can be null if timestampSpec of segments was unknown or unmergeable (if merging is enabled). * queryGranularity - in the result will contain query granularity of data stored in segments. This can be null if query granularity of segments was unknown or unmergeable (if merging is enabled). * aggregators - in the result will contain the list of aggregators usable for querying metric columns. This may be null if the aggregators are unknown or unmergeable (if merging is enabled). Merging can be strict or lenient. The form of the result is a map of column name to aggregator. * rollup - in the result is true/false/null. When merging is enabled, if some are rollup, others are not, result is null.
.PARAMETER LenientAggregatorMerge
If true, and if the ""aggregators"" analysisType is enabled, aggregators will be merged leniently.
.OUTPUTS

TelemetryDruidSegmentMetadataRequest<PSCustomObject>
#>

function Initialize-IntersightTelemetryDruidSegmentMetadataRequest {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("timeseries", "topN", "groupBy", "scan", "timeBoundary", "segmentMetadata", "dataSourceMetadata", "search")]
        [String]
        ${QueryType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${DataSource},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Intervals},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ToInclude},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${Merge},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Context},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${AnalysisTypes},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${LenientAggregatorMerge}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightTelemetryDruidSegmentMetadataRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$QueryType) {
            throw "invalid value for 'QueryType', 'QueryType' cannot be null."
        }

        if (!$DataSource) {
            throw "invalid value for 'DataSource', 'DataSource' cannot be null."
        }

        
        $PSO = [PSCustomObject]@{
            "queryType" = ${QueryType}
            "dataSource" = ${DataSource}
            "intervals" = ${Intervals}
            "toInclude" = ${ToInclude}
            "merge" = ${Merge}
            "context" = ${Context}
            "analysisTypes" = ${AnalysisTypes}
            "lenientAggregatorMerge" = ${LenientAggregatorMerge}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to TelemetryDruidSegmentMetadataRequest<PSCustomObject>

.DESCRIPTION

Convert from JSON to TelemetryDruidSegmentMetadataRequest<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

TelemetryDruidSegmentMetadataRequest<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToTelemetryDruidSegmentMetadataRequest {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightTelemetryDruidSegmentMetadataRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightTelemetryDruidSegmentMetadataRequest
        $AllProperties = ("queryType", "dataSource", "intervals", "toInclude", "merge", "context", "analysisTypes", "lenientAggregatorMerge")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        If ([string]::IsNullOrEmpty($Json) -or $Json -eq "{}") { # empty json
            throw "Error! Empty JSON cannot be serialized due to the required property 'queryType' missing."
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "queryType"))) {
            throw "Error! JSON cannot be serialized due to the required property 'queryType' missing."
        } else {
            $QueryType = $JsonParameters.PSobject.Properties["queryType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "dataSource"))) {
            throw "Error! JSON cannot be serialized due to the required property 'dataSource' missing."
        } else {
            $DataSource = $JsonParameters.PSobject.Properties["dataSource"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "intervals"))) { #optional property not found
            $Intervals = $null
        } else {
            $Intervals = $JsonParameters.PSobject.Properties["intervals"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "toInclude"))) { #optional property not found
            $ToInclude = $null
        } else {
            $ToInclude = $JsonParameters.PSobject.Properties["toInclude"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "merge"))) { #optional property not found
            $Merge = $null
        } else {
            $Merge = $JsonParameters.PSobject.Properties["merge"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "context"))) { #optional property not found
            $Context = $null
        } else {
            $Context = $JsonParameters.PSobject.Properties["context"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "analysisTypes"))) { #optional property not found
            $AnalysisTypes = $null
        } else {
            $AnalysisTypes = $JsonParameters.PSobject.Properties["analysisTypes"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "lenientAggregatorMerge"))) { #optional property not found
            $LenientAggregatorMerge = $null
        } else {
            $LenientAggregatorMerge = $JsonParameters.PSobject.Properties["lenientAggregatorMerge"].value
        }

        $PSO = [PSCustomObject]@{
            "queryType" = ${QueryType}
            "dataSource" = ${DataSource}
            "intervals" = ${Intervals}
            "toInclude" = ${ToInclude}
            "merge" = ${Merge}
            "context" = ${Context}
            "analysisTypes" = ${AnalysisTypes}
            "lenientAggregatorMerge" = ${LenientAggregatorMerge}
        }

        return $PSO
    }

}

