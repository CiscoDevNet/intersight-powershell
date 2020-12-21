# TelemetryDruidSelectorFilterAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dimension** | **String** | The name of a dimension. | 
**Value** | **String** | The value of a dimension. | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidSelectorFilterAllOf = Initialize-IntersightTelemetryDruidSelectorFilterAllOf  -Dimension null `
 -Value null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidSelectorFilterAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

