# AssetUsernamePasswordCredentialAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] 
**Password** | **String** | The password used to authenticate with a managed target. | [optional] 
**Username** | **String** | The username used to authenticate with a managed target. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAssetUsernamePasswordCredentialAllOf  -IsPasswordSet null `
 -Password null `
 -Username null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

