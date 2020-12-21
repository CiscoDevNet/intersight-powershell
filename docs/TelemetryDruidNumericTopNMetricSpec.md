# TelemetryDruidNumericTopNMetricSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The dimension spec type. | 
**Metric** | **String** | The name of the metric to sort topN results. | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidNumericTopNMetricSpec = Initialize-IntersightTelemetryDruidNumericTopNMetricSpec  -Type null `
 -Metric null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidNumericTopNMetricSpec | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

