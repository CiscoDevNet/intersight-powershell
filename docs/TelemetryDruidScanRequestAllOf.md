# TelemetryDruidScanRequestAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataSource** | [**TelemetryDruidDataSource**](TelemetryDruidDataSource.md) |  | 
**Intervals** | **String[]** | A JSON Object representing ISO-8601 Intervals. This defines the time ranges to run the query over. | 
**ResultFormat** | **String** | How the results are represented, list, compactedList or valueVector. Currently only list and compactedList are supported. | [optional] [default to "list"]
**VarFilter** | [**TelemetryDruidFilter**](TelemetryDruidFilter.md) |  | [optional] 
**Columns** | **String[]** | A String array of dimensions and metrics to scan. If left empty, all dimensions and metrics are returned. | [optional] 
**BatchSize** | **Int32** | The maximum number of rows buffered before being returned to the client. | [optional] [default to 20480]
**Limit** | **Int32** | How many rows to return. If not specified, all rows will be returned. | [optional] 
**Order** | **String** | The ordering of returned rows based on timestamp. &quot;&quot;ascending&quot;&quot;, &quot;&quot;descending&quot;&quot;, and &quot;&quot;none&quot;&quot; (default) are supported. Currently, &quot;&quot;ascending&quot;&quot; and &quot;&quot;descending&quot;&quot; are only supported for queries where the __time column is included in the columns field and the requirements outlined in the time ordering section are met. | [optional] [default to "none"]
**Legacy** | **Boolean** | Return results consistent with the legacy &quot;&quot;scan-query&quot;&quot; contrib extension. Defaults to the value set by druid.query.scan.legacy, which in turn defaults to false. | [optional] [default to $false]
**Context** | [**TelemetryDruidQueryContext**](TelemetryDruidQueryContext.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTelemetryDruidScanRequestAllOf  -DataSource null `
 -Intervals [&quot;2020-01-01T00:00:00.000/2020-01-03T00:00:00.000&quot;] `
 -ResultFormat null `
 -VarFilter null `
 -Columns null `
 -BatchSize null `
 -Limit null `
 -Order null `
 -Legacy null `
 -Context null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

