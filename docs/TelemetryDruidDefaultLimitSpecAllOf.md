# TelemetryDruidDefaultLimitSpecAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Limit** | **Int32** | How many rows to return. If not specified, all rows will be returned. | 
**Columns** | [**TelemetryDruidOrderByColumnSpec[]**](TelemetryDruidOrderByColumnSpec.md) | null | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidDefaultLimitSpecAllOf = Initialize-IntersightTelemetryDruidDefaultLimitSpecAllOf  -Limit null `
 -Columns null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidDefaultLimitSpecAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

