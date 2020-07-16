# TelemetryDruidSegmentMetadataRequestAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataSource** | [**TelemetryDruidDataSource**](TelemetryDruidDataSource.md) |  | 
**Intervals** | **String[]** | A JSON Object representing ISO-8601 Intervals. This defines the time ranges to run the query over. If an interval is not specified, the query will use a default interval that spans a configurable period before the end time of the most recent segment. | [optional] 
**ToInclude** | [**SystemCollectionsHashtable**](.md) | A JSON Object representing what columns should be included in the result. Defaults to &quot;&quot;all&quot;&quot;. | [optional] 
**Merge** | **Boolean** | Merge all individual segment metadata results into a single result. | [optional] 
**Context** | [**TelemetryDruidQueryContext**](TelemetryDruidQueryContext.md) |  | [optional] 
**AnalysisTypes** | **String[]** | A list of Strings specifying what column properties (e.g. cardinality, size) should be calculated and returned in the result. Defaults to [&quot;&quot;cardinality&quot;&quot;, &quot;&quot;interval&quot;&quot;, &quot;&quot;minmax&quot;&quot;], but can be overridden with using the segment metadata query config. * cardinality - in the result will return the estimated floor of cardinality for each column. Only relevant for dimension columns. * minmax - Estimated min/max values for each column. Only relevant for dimension columns. * size - in the result will contain the estimated total segment byte size as if the data were stored in text format. * intervals - in the result will contain the list of intervals associated with the queried segments. * timestampSpec - in the result will contain timestampSpec of data stored in segments. This can be null if timestampSpec of segments was unknown or unmergeable (if merging is enabled). * queryGranularity - in the result will contain query granularity of data stored in segments. This can be null if query granularity of segments was unknown or unmergeable (if merging is enabled). * aggregators - in the result will contain the list of aggregators usable for querying metric columns. This may be null if the aggregators are unknown or unmergeable (if merging is enabled). Merging can be strict or lenient. The form of the result is a map of column name to aggregator. * rollup - in the result is true/false/null. When merging is enabled, if some are rollup, others are not, result is null. | [optional] 
**LenientAggregatorMerge** | **Boolean** | If true, and if the &quot;&quot;aggregators&quot;&quot; analysisType is enabled, aggregators will be merged leniently. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTelemetryDruidSegmentMetadataRequestAllOf  -DataSource null `
 -Intervals null `
 -ToInclude null `
 -Merge null `
 -Context null `
 -AnalysisTypes null `
 -LenientAggregatorMerge null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

