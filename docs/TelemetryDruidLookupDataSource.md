# TelemetryDruidLookupDataSource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The type of data source. | 
**Lookup** | **String** | the name of the lookup object. | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidLookupDataSource = Initialize-IntersightTelemetryDruidLookupDataSource  -Type null `
 -Lookup null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidLookupDataSource | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

