# TelemetryDruidFieldAccessorPostAggregator
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The post-aggregator type. | 
**Name** | **String** | Output name for the post-aggregator. | [optional] 
**FieldName** | **String** | Name of the metric column. | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidFieldAccessorPostAggregator = Initialize-IntersightTelemetryDruidFieldAccessorPostAggregator  -Type null `
 -Name null `
 -FieldName null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidFieldAccessorPostAggregator | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

