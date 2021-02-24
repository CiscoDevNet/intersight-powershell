# TelemetryDruidTimeBoundaryResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **System.DateTime** | The ISO 8601 timestamp. | [optional] 
**Result** | [**SystemCollectionsHashtable**](.md) | The corresponding timestamps for query. May contain maxTime, minTime, or both (default). | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidTimeBoundaryResult = Initialize-IntersightTelemetryDruidTimeBoundaryResult  -Timestamp null `
 -Result null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidTimeBoundaryResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

