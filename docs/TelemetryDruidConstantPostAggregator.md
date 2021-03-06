# TelemetryDruidConstantPostAggregator
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The post-aggregator type. | 
**Name** | **String** | Output name for the post-aggregator. | [optional] 
**Value** | **Double** | The numerical value. | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidConstantPostAggregator = Initialize-IntersightTelemetryDruidConstantPostAggregator  -Type null `
 -Name null `
 -Value null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidConstantPostAggregator | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

