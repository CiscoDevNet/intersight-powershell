# MoTagKeySummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **String** | The tag key for which usage information is provided. | [optional] 
**NumKeys** | **Int32** | The number of times this tag Key has been set in an API resource. | [optional] 
**Values** | **String[]** | A list of all Tag values that have been assigned to this tag Key. | [optional] 

## Examples

- Prepare the resource
```powershell
$MoTagKeySummary = Initialize-IntersightMoTagKeySummary  -Key null `
 -NumKeys null `
 -Values null
```

- Convert the resource to JSON
```powershell
$MoTagKeySummary | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

