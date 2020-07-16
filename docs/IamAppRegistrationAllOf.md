# IamAppRegistrationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
Initialize-IntersightIamAppRegistrationAllOf  -ClientId null `
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

