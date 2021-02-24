# TelemetryDruidScanResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SegmentId** | **String** | The identifier for the row(s)&#39; segement | [optional] 
**Columns** | **String[]** | A list of columns returned in the row(s) | [optional] 
**Events** | [**SystemCollectionsHashtable[]**](SystemCollectionsHashtable.md) | Row results | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidScanResult = Initialize-IntersightTelemetryDruidScanResult  -SegmentId null `
 -Columns null `
 -Events null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidScanResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

