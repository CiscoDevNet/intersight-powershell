# TelemetryDruidArithmeticPostAggregatorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | Output name for the minimum/maximum timestamp value. | [optional] 
**Fn** | **String** | null | [optional] 
**Fields** | **String[]** | null | [optional] 
**Ordering** | **String** | Arithmetic post-aggregators may specify an ordering, which defines the order of resulting values when sorting results. This can be useful for topN queries for instance. If no ordering (or null) is specified, the default floating point ordering is used. numericFirst ordering always returns finite values first, followed by NaN, and infinite values last. | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidArithmeticPostAggregatorAllOf = Initialize-IntersightTelemetryDruidArithmeticPostAggregatorAllOf  -Name null `
 -Fn null `
 -Fields null `
 -Ordering null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidArithmeticPostAggregatorAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

