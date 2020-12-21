# TelemetryDruidQueryDataSource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The type of data source. | 
**Query** | [**TelemetryDruidGroupByRequest**](TelemetryDruidGroupByRequest.md) |  | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidQueryDataSource = Initialize-IntersightTelemetryDruidQueryDataSource  -Type null `
 -Query null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidQueryDataSource | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

