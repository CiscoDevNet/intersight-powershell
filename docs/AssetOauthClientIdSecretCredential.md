# AssetOauthClientIdSecretCredential
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.OauthClientIdSecretCredential"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.OauthClientIdSecretCredential"]
**ClientId** | **String** | The client ID used to authenticate with a managed target. | [optional] 
**ClientSecret** | **String** | The client secret used to authenticate with a managed target. | [optional] 
**IsClientSecretSet** | **Boolean** | Indicates whether the value of the &#39;clientSecret&#39; property has been set. | [optional] [readonly] [default to $false]

## Examples

- Prepare the resource
```powershell
$AssetOauthClientIdSecretCredential = Initialize-IntersightAssetOauthClientIdSecretCredential  -ClassId null `
 -ObjectType null `
 -ClientId null `
 -ClientSecret null `
 -IsClientSecretSet null
```

- Convert the resource to JSON
```powershell
$AssetOauthClientIdSecretCredential | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

