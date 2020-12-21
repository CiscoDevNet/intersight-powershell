# TelemetryDruidFilteredAggregatorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarFilter** | [**TelemetryDruidFilter**](TelemetryDruidFilter.md) |  | 
**Aggregator** | [**TelemetryDruidAggregator**](TelemetryDruidAggregator.md) |  | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidFilteredAggregatorAllOf = Initialize-IntersightTelemetryDruidFilteredAggregatorAllOf  -VarFilter null `
 -Aggregator null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidFilteredAggregatorAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

