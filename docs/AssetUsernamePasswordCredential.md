# AssetUsernamePasswordCredential
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.UsernamePasswordCredential"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.UsernamePasswordCredential"]
**IsPasswordSet** | **Boolean** | Indicates whether the value of the &#39;password&#39; property has been set. | [optional] [readonly] [default to $false]
**Password** | **String** | The password used to authenticate with a managed target. | [optional] 
**Username** | **String** | The username used to authenticate with a managed target. | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetUsernamePasswordCredential = Initialize-IntersightAssetUsernamePasswordCredential  -ClassId null `
 -ObjectType null `
 -IsPasswordSet null `
 -Password null `
 -Username null
```

- Convert the resource to JSON
```powershell
$AssetUsernamePasswordCredential | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

