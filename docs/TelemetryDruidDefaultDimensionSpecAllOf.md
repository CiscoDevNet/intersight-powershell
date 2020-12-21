# TelemetryDruidDefaultDimensionSpecAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dimension** | **String** | null | 
**OutputName** | **String** | null | 
**OutputType** | **String** | null | [default to "STRING"]

## Examples

- Prepare the resource
```powershell
$TelemetryDruidDefaultDimensionSpecAllOf = Initialize-IntersightTelemetryDruidDefaultDimensionSpecAllOf  -Dimension null `
 -OutputName null `
 -OutputType null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidDefaultDimensionSpecAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

