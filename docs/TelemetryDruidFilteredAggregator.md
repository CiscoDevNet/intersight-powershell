# TelemetryDruidFilteredAggregator
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | The aggregator type. | 
**VarFilter** | [**TelemetryDruidFilter**](TelemetryDruidFilter.md) |  | 
**Aggregator** | [**TelemetryDruidAggregator**](TelemetryDruidAggregator.md) |  | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidFilteredAggregator = Initialize-IntersightTelemetryDruidFilteredAggregator  -Type null `
 -VarFilter null `
 -Aggregator null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidFilteredAggregator | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

