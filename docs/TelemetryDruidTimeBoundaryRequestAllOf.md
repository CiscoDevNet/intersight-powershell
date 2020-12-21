# TelemetryDruidTimeBoundaryRequestAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataSource** | [**TelemetryDruidDataSource**](TelemetryDruidDataSource.md) |  | 
**Bound** | **String** | Optional, set to maxTime or minTime to return only the latest or earliest timestamp. Default to returning both if not set. | [optional] 
**VarFilter** | [**TelemetryDruidFilter**](TelemetryDruidFilter.md) |  | [optional] 
**Context** | [**TelemetryDruidQueryContext**](TelemetryDruidQueryContext.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidTimeBoundaryRequestAllOf = Initialize-IntersightTelemetryDruidTimeBoundaryRequestAllOf  -DataSource null `
 -Bound null `
 -VarFilter null `
 -Context null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidTimeBoundaryRequestAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

