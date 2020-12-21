# TelemetryDruidInvertedTopNMetricSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The dimension spec type. | 
**Metric** | [**TelemetryDruidTopNMetricSpec**](TelemetryDruidTopNMetricSpec.md) |  | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidInvertedTopNMetricSpec = Initialize-IntersightTelemetryDruidInvertedTopNMetricSpec  -Type null `
 -Metric null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidInvertedTopNMetricSpec | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

