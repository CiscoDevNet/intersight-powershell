# TelemetryDruidHavingQueryFilter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The having filter type. | 
**VarFilter** | [**TelemetryDruidFilter**](TelemetryDruidFilter.md) |  | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidHavingQueryFilter = Initialize-IntersightTelemetryDruidHavingQueryFilter  -Type null `
 -VarFilter null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidHavingQueryFilter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

