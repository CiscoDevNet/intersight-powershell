# TelemetryDruidAnyAggregator
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The aggregator type. | 
**Name** | **String** | Output name for the &#39;any&#39; value. | 
**FieldName** | **String** | Name of the metric column. | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidAnyAggregator = Initialize-IntersightTelemetryDruidAnyAggregator  -Type null `
 -Name null `
 -FieldName null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidAnyAggregator | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

