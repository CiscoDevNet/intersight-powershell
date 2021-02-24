# TelemetryDruidAggregateSearchSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | null | 
**Value** | **String** | The value to match.  If any part of a dimension value contains the value specified in this search query spec, regardless of case, a &quot;&quot;match&quot;&quot; occurs. | 
**Values** | **String[]** | The value to match.  If any part of a dimension value contains all of the values specified in this search query spec a &quot;&quot;match&quot;&quot; occurs. | 
**CaseSensitive** | **Boolean** | Whether or not search is case sensitive | [optional] 
**Regex** | **String** | The regular expression to match.  If any part of a dimension value contains the pattern specified in this search query a &quot;&quot;match&quot;&quot; occurs. | 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidAggregateSearchSpec = Initialize-IntersightTelemetryDruidAggregateSearchSpec  -Type null `
 -Value null `
 -Values null `
 -CaseSensitive null `
 -Regex null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidAggregateSearchSpec | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

