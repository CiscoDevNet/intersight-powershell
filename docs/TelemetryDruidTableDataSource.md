# TelemetryDruidTableDataSource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The type of data source. | 
**Name** | **String** | The name of a data source. | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidTableDataSource = Initialize-IntersightTelemetryDruidTableDataSource  -Type null `
 -Name null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidTableDataSource | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

