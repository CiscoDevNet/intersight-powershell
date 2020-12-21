# TelemetryDruidOrderByColumnSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dimension** | **String** | Any dimension or metric name. | [optional] 
**Direction** | **String** | null | [optional] 
**DimensionOrder** | **String** | null | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidOrderByColumnSpec = Initialize-IntersightTelemetryDruidOrderByColumnSpec  -Dimension null `
 -Direction null `
 -DimensionOrder null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidOrderByColumnSpec | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

