# TelemetryDruidHavingNumericFilter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The having filter type. | 
**Aggregation** | **String** | aggregate metric | 
**Value** | **Double** | null | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidHavingNumericFilter = Initialize-IntersightTelemetryDruidHavingNumericFilter  -Type null `
 -Aggregation null `
 -Value null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidHavingNumericFilter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

