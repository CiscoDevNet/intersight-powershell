# AssetApiKeyCredential
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.ApiKeyCredential"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.ApiKeyCredential"]
**ApiKey** | **String** | This a secret API key which can be used for authentication purposes for different targets like Azure Enterprise Agreement. | [optional] 
**IsApiKeySet** | **Boolean** | Indicates whether the value of the &#39;apiKey&#39; property has been set. | [optional] [readonly] [default to $false]

## Examples

- Prepare the resource
```powershell
$AssetApiKeyCredential = Initialize-IntersightAssetApiKeyCredential  -ClassId null `
 -ObjectType null `
 -ApiKey null `
 -IsApiKeySet null
```

- Convert the resource to JSON
```powershell
$AssetApiKeyCredential | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

