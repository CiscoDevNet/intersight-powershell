# TelemetryDruidDefaultDimensionSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | the dimension spec type. | 
**Dimension** | **String** | null | 
**OutputName** | **String** | null | 
**OutputType** | **String** | null | [default to "STRING"]

## Examples

- Prepare the resource
```powershell
$TelemetryDruidDefaultDimensionSpec = Initialize-IntersightTelemetryDruidDefaultDimensionSpec  -Type null `
 -Dimension null `
 -OutputName null `
 -OutputType null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidDefaultDimensionSpec | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

