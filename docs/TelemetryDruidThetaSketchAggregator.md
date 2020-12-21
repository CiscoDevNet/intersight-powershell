# TelemetryDruidThetaSketchAggregator
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The aggregator type. | 
**Name** | **String** | A String for the output (result) name of the calculation. | 
**FieldName** | **String** | A String for the name of the aggregator used at ingestion time. | 
**Size** | **Int32** | Must be a power of 2. Internally, size refers to the maximum number of entries sketch object will retain. Higher size means higher accuracy but more space to store sketches. Note that after you index with a particular size, druid will persist sketch in segments and you will use size greater or equal to that at query time. In general, We recommend just sticking to default size. | [optional] [default to 16384]

## Examples

- Prepare the resource
```powershell
$TelemetryDruidThetaSketchAggregator = Initialize-IntersightTelemetryDruidThetaSketchAggregator  -Type null `
 -Name null `
 -FieldName null `
 -Size null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidThetaSketchAggregator | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

