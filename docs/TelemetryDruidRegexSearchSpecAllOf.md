# TelemetryDruidRegexSearchSpecAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Regex** | **String** | The regular expression to match.  If any part of a dimension value contains the pattern specified in this search query a &quot;&quot;match&quot;&quot; occurs. | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidRegexSearchSpecAllOf = Initialize-IntersightTelemetryDruidRegexSearchSpecAllOf  -Regex null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidRegexSearchSpecAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

