# TelemetryDruidStringAnyAggregatorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | Output name for the &#39;any&#39; value. | 
**FieldName** | **String** | Name of the metric column. | 
**MaxStringBytes** | **Int32** | null | [optional] [default to 1024]

## Examples

- Prepare the resource
```powershell
$TelemetryDruidStringAnyAggregatorAllOf = Initialize-IntersightTelemetryDruidStringAnyAggregatorAllOf  -Name null `
 -FieldName null `
 -MaxStringBytes null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidStringAnyAggregatorAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

