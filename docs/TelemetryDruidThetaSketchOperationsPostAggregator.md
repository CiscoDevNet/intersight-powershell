# TelemetryDruidThetaSketchOperationsPostAggregator
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The post-aggregator type. | 
**Name** | **String** | Output name for the post-aggregator. | [optional] 
**Func** | **String** |  | [optional] 
**Fields** | **String[]** | array of fieldAccess type post aggregators to access the thetaSketch aggregators or thetaSketchSetOp type post aggregators to allow arbitrary combination of set operations. | [optional] 
**Size** | **Int32** | must be max of size from sketches in fields input. | [optional] [default to 16384]

## Examples

- Prepare the resource
```powershell
$TelemetryDruidThetaSketchOperationsPostAggregator = Initialize-IntersightTelemetryDruidThetaSketchOperationsPostAggregator  -Type null `
 -Name null `
 -Func null `
 -Fields null `
 -Size null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidThetaSketchOperationsPostAggregator | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

