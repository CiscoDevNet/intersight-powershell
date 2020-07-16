# TelemetryDruidPostAggregator
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The post-aggregator type. | 
**Name** | **String** | Output name for the post-aggregator. | [optional] 
**Fn** | **String** | null | [optional] 
**Fields** | **String[]** | array of fieldAccess type post aggregators to access the thetaSketch aggregators or thetaSketchSetOp type post aggregators to allow arbitrary combination of set operations. | [optional] 
**Ordering** | **String** | Arithmetic post-aggregators may specify an ordering, which defines the order of resulting values when sorting results. This can be useful for topN queries for instance. If no ordering (or null) is specified, the default floating point ordering is used. numericFirst ordering always returns finite values first, followed by NaN, and infinite values last. | [optional] 
**FieldName** | **String** | The name field value of the hyperUnique aggregator. | [optional] 
**Value** | **Double** | The numerical value. | [optional] 
**Field** | **String** | Post aggregator of type fieldAccess that refers to a thetaSketch aggregator or that of type thetaSketchSetOp. | [optional] 
**Func** | **String** |  | [optional] 
**Size** | **Int32** | must be max of size from sketches in fields input. | [optional] [default to 16384]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTelemetryDruidPostAggregator  -Type null `
 -Name null `
 -Fn null `
 -Fields null `
 -Ordering null `
 -FieldName null `
 -Value null `
 -Field null `
 -Func null `
 -Size null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

