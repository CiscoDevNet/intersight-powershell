# TelemetryDruidSumAggregatorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | Output name for the summed value. | 
**FieldName** | **String** | Name of the metric column to sum over. | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidSumAggregatorAllOf = Initialize-IntersightTelemetryDruidSumAggregatorAllOf  -Name null `
 -FieldName null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidSumAggregatorAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

