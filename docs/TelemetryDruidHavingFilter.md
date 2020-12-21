# TelemetryDruidHavingFilter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The having filter type. | 
**VarFilter** | [**TelemetryDruidFilter**](TelemetryDruidFilter.md) |  | 
**Aggregation** | **String** | aggregate metric | 
**Value** | **Double** | null | 
**Dimension** | **String** | dimension | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidHavingFilter = Initialize-IntersightTelemetryDruidHavingFilter  -Type null `
 -VarFilter null `
 -Aggregation null `
 -Value null `
 -Dimension null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidHavingFilter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

