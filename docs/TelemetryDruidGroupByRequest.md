# TelemetryDruidGroupByRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QueryType** | **String** | null | 
**DataSource** | [**TelemetryDruidDataSource**](TelemetryDruidDataSource.md) |  | 
**Dimensions** | [**TelemetryDruidDimensionSpec[]**](TelemetryDruidDimensionSpec.md) | A JSON list of dimensions to do the groupBy over; or see DimensionSpec for ways to extract dimensions.. | 
**LimitSpec** | [**TelemetryDruidDefaultLimitSpec**](TelemetryDruidDefaultLimitSpec.md) |  | [optional] 
**Having** | [**TelemetryDruidHavingFilter**](TelemetryDruidHavingFilter.md) |  | [optional] 
**Granularity** | [**TelemetryDruidGranularity**](TelemetryDruidGranularity.md) |  | 
**VarFilter** | [**TelemetryDruidFilter**](TelemetryDruidFilter.md) |  | [optional] 
**Aggregations** | [**TelemetryDruidAggregator[]**](TelemetryDruidAggregator.md) | Aggregation functions are used to summarize data in buckets. Summarization functions include counting rows, calculating the min/max/sum of metrics and retrieving the first/last value of metrics for each bucket. Additional summarization functions are available with extensions. If no aggregator is provided, the results will be empty for each bucket. | [optional] 
**PostAggregations** | [**TelemetryDruidPostAggregator[]**](TelemetryDruidPostAggregator.md) | Post-aggregations are specifications of processing that should happen on aggregated values as they come out of Apache Druid. If you include a post aggregation as part of a query, make sure to include all aggregators the post-aggregator requires. | [optional] 
**Intervals** | **String[]** | A JSON Object representing ISO-8601 Intervals. This defines the time ranges to run the query over. | 
**SubtotalsSpec** | [**SystemCollectionsHashtable**](.md) | A JSON array of arrays to return additional result sets for groupings of subsets of top level dimensions. The subtotals feature allows computation of multiple sub-groupings in a single query. To use this feature, add a &quot;&quot;subtotalsSpec&quot;&quot; to your query, which should be a list of subgroup dimension sets. It should contain the &quot;&quot;outputName&quot;&quot; from dimensions in your &quot;&quot;dimensions&quot;&quot; attribute, in the same order as they appear in the &quot;&quot;dimensions&quot;&quot; attribute. | [optional] 
**Context** | [**TelemetryDruidQueryContext**](TelemetryDruidQueryContext.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidGroupByRequest = Initialize-IntersightTelemetryDruidGroupByRequest  -QueryType null `
 -DataSource null `
 -Dimensions null `
 -LimitSpec null `
 -Having null `
 -Granularity null `
 -VarFilter null `
 -Aggregations null `
 -PostAggregations null `
 -Intervals null `
 -SubtotalsSpec null `
 -Context null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidGroupByRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

