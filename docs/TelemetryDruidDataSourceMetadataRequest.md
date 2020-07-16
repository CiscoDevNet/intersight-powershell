# TelemetryDruidDataSourceMetadataRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QueryType** | **String** | null | 
**DataSource** | [**TelemetryDruidDataSource**](TelemetryDruidDataSource.md) |  | 
**Context** | [**TelemetryDruidQueryContext**](TelemetryDruidQueryContext.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTelemetryDruidDataSourceMetadataRequest  -QueryType null `
 -DataSource null `
 -Context null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

