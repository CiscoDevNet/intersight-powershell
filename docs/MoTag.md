# MoTag
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **String** | The string representation of a tag key. | [optional] 
**Value** | **String** | The string representation of a tag value. | [optional] 

## Examples

- Prepare the resource
```powershell
$MoTag = Initialize-IntersightMoTag  -Key null `
 -Value null
```

- Convert the resource to JSON
```powershell
$MoTag | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

