# TelemetryDruidIntervalResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **System.DateTime** | The ISO 8601 timestamp. | [optional] 
**Result** | [**SystemCollectionsHashtable**](.md) | A map of output field names to metric values (long or double). | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidIntervalResult = Initialize-IntersightTelemetryDruidIntervalResult  -Timestamp null `
 -Result null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidIntervalResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

