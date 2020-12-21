# TelemetryDruidFirstLastAggregatorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | Output name for the first/last value. | 
**FieldName** | **String** | Name of the metric column. | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidFirstLastAggregatorAllOf = Initialize-IntersightTelemetryDruidFirstLastAggregatorAllOf  -Name null `
 -FieldName null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidFirstLastAggregatorAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

