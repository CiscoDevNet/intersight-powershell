# TelemetryDruidSearchResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **System.DateTime** | The ISO 8601 timestamp. | [optional] 
**Result** | [**SystemCollectionsHashtable[]**](SystemCollectionsHashtable.md) | A list of dimension values | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidSearchResult = Initialize-IntersightTelemetryDruidSearchResult  -Timestamp null `
 -Result null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidSearchResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

