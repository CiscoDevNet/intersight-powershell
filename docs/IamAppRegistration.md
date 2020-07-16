# IamAppRegistration
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | a map of display names for a resource. | [optional] [readonly] 
**ClientId** | **String** | A unique identifier for the OAuth2 client application. The client ID is auto-generated when the AppRegistration object is created. | [optional] [readonly] 
**ClientName** | **String** | App Registration name specified by user. | [optional] 
**ClientSecret** | **String** | The OAuth2 client secret. The value of this property is generated when grantType includes &#39;client-credentials&#39;. Otherwise, no client-secret is generated. | [optional] 
**ClientType** | **String** | The type of the OAuth2 client (public or confidential), as specified in https://tools.ietf.org/html/rfc6749#section-2.1. | [optional] [default to "public"]
**Description** | **String** | Description of the application. | [optional] 
**GrantTypes** | **String[]** |  | [optional] 
**RedirectUris** | **String[]** |  | [optional] 
**RenewClientSecret** | **Boolean** | Set value to true to renew the client-secret. Applicable to client_credentials grant type. | [optional] 
**ResponseTypes** | **String[]** |  | [optional] 
**RevocationTimestamp** | **System.DateTime** | Used to perform revocation for tokens of AppRegistration. Updated only internally is case Revoke property come from UI with value true. On each request with OAuth2 access token the CreationTime of the OAuth2 token will be compared to RevokationTimestamp of the corresponding App Registration. | [optional] [readonly] 
**Revoke** | **Boolean** | Used to trigger update the revocationTimestamp value. If UI sent updating request with the Revoke value is true, then update RevocationTimestamp. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**OauthTokens** | [**IamOAuthTokenRelationship[]**](IamOAuthTokenRelationship.md) | An array of relationships to iamOAuthToken resources. | [optional] [readonly] 
**Permission** | [**IamPermissionRelationship**](IamPermissionRelationship.md) |  | [optional] 
**Roles** | [**IamRoleRelationship[]**](IamRoleRelationship.md) | An array of relationships to iamRole resources. | [optional] 
**User** | [**IamUserRelationship**](IamUserRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamAppRegistration  -AccountMoid null `
 -ClassId null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -ObjectType null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -ClientId null `
 -ClientName null `
 -ClientSecret null `
 -ClientType null `
 -Description null `
 -GrantTypes null `
 -RedirectUris null `
 -RenewClientSecret null `
 -ResponseTypes null `
 -RevocationTimestamp null `
 -Revoke null `
 -Account null `
 -OauthTokens null `
 -Permission null `
 -Roles null `
 -User null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

