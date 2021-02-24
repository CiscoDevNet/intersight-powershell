# TelemetryDruidSearchRequestAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataSource** | [**TelemetryDruidDataSource**](TelemetryDruidDataSource.md) |  | 
**Intervals** | **String[]** | A JSON Object representing ISO-8601 Intervals. This defines the time ranges to run the query over. | 
**Granularity** | [**TelemetryDruidGranularity**](TelemetryDruidGranularity.md) |  | 
**VarFilter** | [**TelemetryDruidFilter**](TelemetryDruidFilter.md) |  | [optional] 
**Aggregations** | [**TelemetryDruidAggregator[]**](TelemetryDruidAggregator.md) | Aggregation functions are used to summarize data in buckets. Summarization functions include counting rows, calculating the min/max/sum of metrics and retrieving the first/last value of metrics for each bucket. Additional summarization functions are available with extensions. If no aggregator is provided, the results will be empty for each bucket. | [optional] 
**SearchDimensions** | **String[]** | The list of dimensions to run the search over. Excluding this means the search is run over all dimensions. | [optional] 
**Query** | [**TelemetryDruidAggregateSearchSpec**](TelemetryDruidAggregateSearchSpec.md) |  | [optional] 
**Limit** | **Int32** | An integer that limits the number of results. The default is unlimited. | [optional] 
**Context** | [**TelemetryDruidQueryContext**](TelemetryDruidQueryContext.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidSearchRequestAllOf = Initialize-IntersightTelemetryDruidSearchRequestAllOf  -DataSource null `
 -Intervals [&quot;2020-01-01T00:00:00.000/2020-01-03T00:00:00.000&quot;,&quot;2020-01-01T00:00:00.000Z/2020-01-03T00:00:00.000Z&quot;,&quot;2007-03-01T13:00:00Z/2008-05-11T15:30:00Z&quot;,&quot;2007-03-01T13:00:00Z/P1Y2M10DT2H30M&quot;,&quot;P1Y2M10DT2H30M/2008-05-11T15:30:00Z&quot;] `
 -Granularity null `
 -VarFilter null `
 -Aggregations null `
 -SearchDimensions null `
 -Query null `
 -Limit null `
 -Context null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidSearchRequestAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

