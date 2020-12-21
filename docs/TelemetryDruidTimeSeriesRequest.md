# TelemetryDruidTimeSeriesRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QueryType** | **String** | null | 
**DataSource** | [**TelemetryDruidDataSource**](TelemetryDruidDataSource.md) |  | 
**Descending** | **Boolean** | Whether to make descending ordered result. Default is false(ascending). | [optional] 
**Intervals** | **String[]** | A JSON Object representing ISO-8601 Intervals. This defines the time ranges to run the query over. | 
**Granularity** | [**TelemetryDruidGranularity**](TelemetryDruidGranularity.md) |  | 
**VarFilter** | [**TelemetryDruidFilter**](TelemetryDruidFilter.md) |  | [optional] 
**Aggregations** | [**TelemetryDruidAggregator[]**](TelemetryDruidAggregator.md) | Aggregation functions are used to summarize data in buckets. Summarization functions include counting rows, calculating the min/max/sum of metrics and retrieving the first/last value of metrics for each bucket. Additional summarization functions are available with extensions. If no aggregator is provided, the results will be empty for each bucket. | [optional] 
**PostAggregations** | [**TelemetryDruidPostAggregator[]**](TelemetryDruidPostAggregator.md) | Post-aggregations are specifications of processing that should happen on aggregated values as they come out of Apache Druid. If you include a post aggregation as part of a query, make sure to include all aggregators the post-aggregator requires. | [optional] 
**Limit** | **Int32** | An integer that limits the number of results. The default is unlimited. | [optional] 
**Context** | [**TelemetryDruidQueryContext**](TelemetryDruidQueryContext.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidTimeSeriesRequest = Initialize-IntersightTelemetryDruidTimeSeriesRequest  -QueryType null `
 -DataSource null `
 -Descending null `
 -Intervals [&quot;2020-01-01T00:00:00.000/2020-01-03T00:00:00.000&quot;,&quot;2020-01-01T00:00:00.000Z/2020-01-03T00:00:00.000Z&quot;,&quot;2007-03-01T13:00:00Z/2008-05-11T15:30:00Z&quot;,&quot;2007-03-01T13:00:00Z/P1Y2M10DT2H30M&quot;,&quot;P1Y2M10DT2H30M/2008-05-11T15:30:00Z&quot;] `
 -Granularity null `
 -VarFilter null `
 -Aggregations null `
 -PostAggregations null `
 -Limit null `
 -Context null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidTimeSeriesRequest | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

