# TelemetryDruidFragmentSearchSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **String** | null | 
**Values** | **String[]** | The value to match.  If any part of a dimension value contains all of the values specified in this search query spec a &quot;&quot;match&quot;&quot; occurs. | 
**CaseSensitive** | **Boolean** | Whether or not search is case sensitive | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidFragmentSearchSpec = Initialize-IntersightTelemetryDruidFragmentSearchSpec  -Type null `
 -Values null `
 -CaseSensitive null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidFragmentSearchSpec | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

