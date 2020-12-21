# TelemetryDruidMinMaxAggregator
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The aggregator type. | 
**Name** | **String** | Output name for the min/max value. | 
**FieldName** | **String** | Name of the metric column. | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidMinMaxAggregator = Initialize-IntersightTelemetryDruidMinMaxAggregator  -Type null `
 -Name null `
 -FieldName null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidMinMaxAggregator | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

