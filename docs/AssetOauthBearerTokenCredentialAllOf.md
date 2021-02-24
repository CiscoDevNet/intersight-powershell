# AssetOauthBearerTokenCredentialAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.OauthBearerTokenCredential"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.OauthBearerTokenCredential"]
**IsTokenSet** | **Boolean** | Indicates whether the value of the &#39;token&#39; property has been set. | [optional] [readonly] [default to $false]
**ScopeType** | **String** | Scope type for the crendetial i.e. User, Organization, Team. | [optional] 
**ScopeValue** | **String** | Scope value for the credential i.e. username, organization name or team name. | [optional] 
**Token** | **String** | The token used to authenticate with a managed target. | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetOauthBearerTokenCredentialAllOf = Initialize-IntersightAssetOauthBearerTokenCredentialAllOf  -ClassId null `
 -ObjectType null `
 -IsTokenSet null `
 -ScopeType null `
 -ScopeValue null `
 -Token null
```

- Convert the resource to JSON
```powershell
$AssetOauthBearerTokenCredentialAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

