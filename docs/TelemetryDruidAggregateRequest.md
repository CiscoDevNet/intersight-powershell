# TelemetryDruidAggregateRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QueryType** | **String** | null | 
**DataSource** | [**TelemetryDruidDataSource**](TelemetryDruidDataSource.md) |  | 
**Descending** | **Boolean** | Whether to make descending ordered result. Default is false(ascending). | [optional] 
**Intervals** | **String[]** | A JSON Object representing ISO-8601 Intervals. This defines the time ranges to run the query over. If an interval is not specified, the query will use a default interval that spans a configurable period before the end time of the most recent segment. | 
**Granularity** | [**TelemetryDruidGranularity**](TelemetryDruidGranularity.md) |  | 
**VarFilter** | [**TelemetryDruidFilter**](TelemetryDruidFilter.md) |  | [optional] 
**Aggregations** | [**TelemetryDruidAggregator[]**](TelemetryDruidAggregator.md) | Aggregation functions are used to summarize data in buckets. Summarization functions include counting rows, calculating the min/max/sum of metrics and retrieving the first/last value of metrics for each bucket. Additional summarization functions are available with extensions. If no aggregator is provided, the results will be empty for each bucket. | [optional] 
**PostAggregations** | [**TelemetryDruidPostAggregator[]**](TelemetryDruidPostAggregator.md) | Post-aggregations are specifications of processing that should happen on aggregated values as they come out of Apache Druid. If you include a post aggregation as part of a query, make sure to include all aggregators the post-aggregator requires. | [optional] 
**Limit** | **Int32** | How many rows to return. If not specified, all rows will be returned. | [optional] 
**Context** | [**TelemetryDruidQueryContext**](TelemetryDruidQueryContext.md) |  | [optional] 
**Dimension** | [**TelemetryDruidDimensionSpec**](TelemetryDruidDimensionSpec.md) |  | 
**Threshold** | **Int32** | An integer defining the N in the topN (i.e. how many results you want in the top list). | 
**Metric** | [**TelemetryDruidTopNMetricSpec**](TelemetryDruidTopNMetricSpec.md) |  | 
**Dimensions** | [**TelemetryDruidDimensionSpec[]**](TelemetryDruidDimensionSpec.md) | A JSON list of dimensions to do the groupBy over; or see DimensionSpec for ways to extract dimensions.. | 
**LimitSpec** | [**TelemetryDruidDefaultLimitSpec**](TelemetryDruidDefaultLimitSpec.md) |  | [optional] 
**Having** | [**TelemetryDruidHavingFilter**](TelemetryDruidHavingFilter.md) |  | [optional] 
**SubtotalsSpec** | [**SystemCollectionsHashtable**](.md) | A JSON array of arrays to return additional result sets for groupings of subsets of top level dimensions. The subtotals feature allows computation of multiple sub-groupings in a single query. To use this feature, add a &quot;&quot;subtotalsSpec&quot;&quot; to your query, which should be a list of subgroup dimension sets. It should contain the &quot;&quot;outputName&quot;&quot; from dimensions in your &quot;&quot;dimensions&quot;&quot; attribute, in the same order as they appear in the &quot;&quot;dimensions&quot;&quot; attribute. | [optional] 
**ResultFormat** | **String** | How the results are represented, list, compactedList or valueVector. Currently only list and compactedList are supported. | [optional] [default to "list"]
**Columns** | **String[]** | A String array of dimensions and metrics to scan. If left empty, all dimensions and metrics are returned. | [optional] 
**BatchSize** | **Int32** | The maximum number of rows buffered before being returned to the client. | [optional] [default to 20480]
**Order** | **String** | The ordering of returned rows based on timestamp. &quot;&quot;ascending&quot;&quot;, &quot;&quot;descending&quot;&quot;, and &quot;&quot;none&quot;&quot; (default) are supported. Currently, &quot;&quot;ascending&quot;&quot; and &quot;&quot;descending&quot;&quot; are only supported for queries where the __time column is included in the columns field and the requirements outlined in the time ordering section are met. | [optional] [default to "none"]
**Legacy** | **Boolean** | Return results consistent with the legacy &quot;&quot;scan-query&quot;&quot; contrib extension. Defaults to the value set by druid.query.scan.legacy, which in turn defaults to false. | [optional] [default to $false]
**Bound** | **String** | Optional, set to maxTime or minTime to return only the latest or earliest timestamp. Default to returning both if not set. | [optional] 
**ToInclude** | [**SystemCollectionsHashtable**](.md) | A JSON Object representing what columns should be included in the result. Defaults to &quot;&quot;all&quot;&quot;. | [optional] 
**Merge** | **Boolean** | Merge all individual segment metadata results into a single result. | [optional] 
**AnalysisTypes** | **String[]** | A list of Strings specifying what column properties (e.g. cardinality, size) should be calculated and returned in the result. Defaults to [&quot;&quot;cardinality&quot;&quot;, &quot;&quot;interval&quot;&quot;, &quot;&quot;minmax&quot;&quot;], but can be overridden with using the segment metadata query config. * cardinality - in the result will return the estimated floor of cardinality for each column. Only relevant for dimension columns. * minmax - Estimated min/max values for each column. Only relevant for dimension columns. * size - in the result will contain the estimated total segment byte size as if the data were stored in text format. * intervals - in the result will contain the list of intervals associated with the queried segments. * timestampSpec - in the result will contain timestampSpec of data stored in segments. This can be null if timestampSpec of segments was unknown or unmergeable (if merging is enabled). * queryGranularity - in the result will contain query granularity of data stored in segments. This can be null if query granularity of segments was unknown or unmergeable (if merging is enabled). * aggregators - in the result will contain the list of aggregators usable for querying metric columns. This may be null if the aggregators are unknown or unmergeable (if merging is enabled). Merging can be strict or lenient. The form of the result is a map of column name to aggregator. * rollup - in the result is true/false/null. When merging is enabled, if some are rollup, others are not, result is null. | [optional] 
**LenientAggregatorMerge** | **Boolean** | If true, and if the &quot;&quot;aggregators&quot;&quot; analysisType is enabled, aggregators will be merged leniently. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTelemetryDruidAggregateRequest  -QueryType null `
 -DataSource null `
 -Descending null `
 -Intervals null `
 -Granularity null `
 -VarFilter null `
 -Aggregations null `
 -PostAggregations null `
 -Limit null `
 -Context null `
 -Dimension null `
 -Threshold null `
 -Metric null `
 -Dimensions null `
 -LimitSpec null `
 -Having null `
 -SubtotalsSpec null `
 -ResultFormat null `
 -Columns null `
 -BatchSize null `
 -Order null `
 -Legacy null `
 -Bound null `
 -ToInclude null `
 -Merge null `
 -AnalysisTypes null `
 -LenientAggregatorMerge null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

