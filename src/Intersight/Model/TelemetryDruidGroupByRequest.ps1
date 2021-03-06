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

These types of Apache Druid queries take a groupBy query object and return an array of JSON objects where each object represents a grouping asked for by the query.

.PARAMETER QueryType
null
.PARAMETER DataSource
No description available.
.PARAMETER Dimensions
A JSON list of dimensions to do the groupBy over; or see DimensionSpec for ways to extract dimensions..
.PARAMETER LimitSpec
No description available.
.PARAMETER Having
No description available.
.PARAMETER Granularity
No description available.
.PARAMETER VarFilter
No description available.
.PARAMETER Aggregations
Aggregation functions are used to summarize data in buckets. Summarization functions include counting rows, calculating the min/max/sum of metrics and retrieving the first/last value of metrics for each bucket. Additional summarization functions are available with extensions. If no aggregator is provided, the results will be empty for each bucket.
.PARAMETER PostAggregations
Post-aggregations are specifications of processing that should happen on aggregated values as they come out of Apache Druid. If you include a post aggregation as part of a query, make sure to include all aggregators the post-aggregator requires.
.PARAMETER Intervals
A JSON Object representing ISO-8601 Intervals. This defines the time ranges to run the query over.
.PARAMETER SubtotalsSpec
A JSON array of arrays to return additional result sets for groupings of subsets of top level dimensions. The subtotals feature allows computation of multiple sub-groupings in a single query. To use this feature, add a ""subtotalsSpec"" to your query, which should be a list of subgroup dimension sets. It should contain the ""outputName"" from dimensions in your ""dimensions"" attribute, in the same order as they appear in the ""dimensions"" attribute.
.PARAMETER Context
No description available.
.OUTPUTS

TelemetryDruidGroupByRequest<PSCustomObject>
#>

function Initialize-IntersightTelemetryDruidGroupByRequest {
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
        [PSCustomObject[]]
        ${Dimensions},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${LimitSpec},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Having},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Granularity},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${VarFilter},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Aggregations},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${PostAggregations},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Intervals},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${SubtotalsSpec},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Context}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightTelemetryDruidGroupByRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$QueryType) {
            throw "invalid value for 'QueryType', 'QueryType' cannot be null."
        }

        if (!$DataSource) {
            throw "invalid value for 'DataSource', 'DataSource' cannot be null."
        }

        if (!$Dimensions) {
            throw "invalid value for 'Dimensions', 'Dimensions' cannot be null."
        }

        if (!$Granularity) {
            throw "invalid value for 'Granularity', 'Granularity' cannot be null."
        }

        if (!$Intervals) {
            throw "invalid value for 'Intervals', 'Intervals' cannot be null."
        }

        
        $PSO = [PSCustomObject]@{
            "queryType" = ${QueryType}
            "dataSource" = ${DataSource}
            "dimensions" = ${Dimensions}
            "limitSpec" = ${LimitSpec}
            "having" = ${Having}
            "granularity" = ${Granularity}
            "filter" = ${VarFilter}
            "aggregations" = ${Aggregations}
            "postAggregations" = ${PostAggregations}
            "intervals" = ${Intervals}
            "subtotalsSpec" = ${SubtotalsSpec}
            "context" = ${Context}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to TelemetryDruidGroupByRequest<PSCustomObject>

.DESCRIPTION

Convert from JSON to TelemetryDruidGroupByRequest<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

TelemetryDruidGroupByRequest<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToTelemetryDruidGroupByRequest {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightTelemetryDruidGroupByRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightTelemetryDruidGroupByRequest
        $AllProperties = ("queryType", "dataSource", "dimensions", "limitSpec", "having", "granularity", "filter", "aggregations", "postAggregations", "intervals", "subtotalsSpec", "context")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "dimensions"))) {
            throw "Error! JSON cannot be serialized due to the required property 'dimensions' missing."
        } else {
            $Dimensions = $JsonParameters.PSobject.Properties["dimensions"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "granularity"))) {
            throw "Error! JSON cannot be serialized due to the required property 'granularity' missing."
        } else {
            $Granularity = $JsonParameters.PSobject.Properties["granularity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "intervals"))) {
            throw "Error! JSON cannot be serialized due to the required property 'intervals' missing."
        } else {
            $Intervals = $JsonParameters.PSobject.Properties["intervals"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "limitSpec"))) { #optional property not found
            $LimitSpec = $null
        } else {
            $LimitSpec = $JsonParameters.PSobject.Properties["limitSpec"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "having"))) { #optional property not found
            $Having = $null
        } else {
            $Having = $JsonParameters.PSobject.Properties["having"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "filter"))) { #optional property not found
            $VarFilter = $null
        } else {
            $VarFilter = $JsonParameters.PSobject.Properties["filter"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "aggregations"))) { #optional property not found
            $Aggregations = $null
        } else {
            $Aggregations = $JsonParameters.PSobject.Properties["aggregations"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "postAggregations"))) { #optional property not found
            $PostAggregations = $null
        } else {
            $PostAggregations = $JsonParameters.PSobject.Properties["postAggregations"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "subtotalsSpec"))) { #optional property not found
            $SubtotalsSpec = $null
        } else {
            $SubtotalsSpec = $JsonParameters.PSobject.Properties["subtotalsSpec"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "context"))) { #optional property not found
            $Context = $null
        } else {
            $Context = $JsonParameters.PSobject.Properties["context"].value
        }

        $PSO = [PSCustomObject]@{
            "queryType" = ${QueryType}
            "dataSource" = ${DataSource}
            "dimensions" = ${Dimensions}
            "limitSpec" = ${LimitSpec}
            "having" = ${Having}
            "granularity" = ${Granularity}
            "filter" = ${VarFilter}
            "aggregations" = ${Aggregations}
            "postAggregations" = ${PostAggregations}
            "intervals" = ${Intervals}
            "subtotalsSpec" = ${SubtotalsSpec}
            "context" = ${Context}
        }

        return $PSO
    }

}

