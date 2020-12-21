# TelemetryDruidHavingDimensionSelectorFilter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The having filter type. | 
**Dimension** | **String** | dimension | 
**Value** | **Double** | null | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidHavingDimensionSelectorFilter = Initialize-IntersightTelemetryDruidHavingDimensionSelectorFilter  -Type null `
 -Dimension null `
 -Value null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidHavingDimensionSelectorFilter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

