# TelemetryDruidTopNRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QueryType** | **String** | null | 
**DataSource** | [**TelemetryDruidDataSource**](TelemetryDruidDataSource.md) |  | 
**Intervals** | **String[]** | A JSON Object representing ISO-8601 Intervals. This defines the time ranges to run the query over. | 
**Granularity** | [**TelemetryDruidGranularity**](TelemetryDruidGranularity.md) |  | 
**VarFilter** | [**TelemetryDruidFilter**](TelemetryDruidFilter.md) |  | [optional] 
**Aggregations** | [**TelemetryDruidAggregator[]**](TelemetryDruidAggregator.md) | Aggregation functions are used to summarize data in buckets. Summarization functions include counting rows, calculating the min/max/sum of metrics and retrieving the first/last value of metrics for each bucket. Additional summarization functions are available with extensions. If no aggregator is provided, the results will be empty for each bucket. | [optional] 
**PostAggregations** | [**TelemetryDruidPostAggregator[]**](TelemetryDruidPostAggregator.md) | Post-aggregations are specifications of processing that should happen on aggregated values as they come out of Apache Druid. If you include a post aggregation as part of a query, make sure to include all aggregators the post-aggregator requires. | [optional] 
**Dimension** | [**TelemetryDruidDimensionSpec**](TelemetryDruidDimensionSpec.md) |  | 
**Threshold** | **Int32** | An integer defining the N in the topN (i.e. how many results you want in the top list). | 
**Metric** | [**TelemetryDruidTopNMetricSpec**](TelemetryDruidTopNMetricSpec.md) |  | 
**Context** | [**TelemetryDruidQueryContext**](TelemetryDruidQueryContext.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTelemetryDruidTopNRequest  -QueryType null `
 -DataSource null `
 -Intervals null `
 -Granularity null `
 -VarFilter null `
 -Aggregations null `
 -PostAggregations null `
 -Dimension null `
 -Threshold null `
 -Metric null `
 -Context null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

