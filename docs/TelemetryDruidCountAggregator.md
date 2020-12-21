# TelemetryDruidCountAggregator
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The aggregator type. | 
**Name** | **String** | the output name | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidCountAggregator = Initialize-IntersightTelemetryDruidCountAggregator  -Type null `
 -Name null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidCountAggregator | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

