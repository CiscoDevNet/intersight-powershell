# TelemetryDruidInsensitiveContainsSearchSpecAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **String** | The value to match.  If any part of a dimension value contains the value specified in this search query spec, regardless of case, a &quot;&quot;match&quot;&quot; occurs. | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidInsensitiveContainsSearchSpecAllOf = Initialize-IntersightTelemetryDruidInsensitiveContainsSearchSpecAllOf  -Value null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidInsensitiveContainsSearchSpecAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

