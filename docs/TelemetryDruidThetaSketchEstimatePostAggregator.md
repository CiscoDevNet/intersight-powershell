# TelemetryDruidThetaSketchEstimatePostAggregator
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The post-aggregator type. | 
**Name** | **String** | Output name for the post-aggregator. | [optional] 
**Field** | **String** | Post aggregator of type fieldAccess that refers to a thetaSketch aggregator or that of type thetaSketchSetOp. | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidThetaSketchEstimatePostAggregator = Initialize-IntersightTelemetryDruidThetaSketchEstimatePostAggregator  -Type null `
 -Name null `
 -Field null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidThetaSketchEstimatePostAggregator | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

