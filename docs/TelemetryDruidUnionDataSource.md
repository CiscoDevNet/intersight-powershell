# TelemetryDruidUnionDataSource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The type of data source. | 
**DataSources** | **String[]** | A list of data sources. | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidUnionDataSource = Initialize-IntersightTelemetryDruidUnionDataSource  -Type null `
 -DataSources null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidUnionDataSource | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

