# IamOAuthTokenAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.OAuthToken"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.OAuthToken"]
**AccessExpirationTime** | **System.DateTime** | Expiration time for the JWT token to which it can be used for api calls. | [optional] [readonly] 
**ClientId** | **String** | The identifier of the registered application to which the token belongs. | [optional] 
**ClientIpAddress** | **String** | The user agent IP address from which the auth token is launched. | [optional] [readonly] 
**ClientName** | **String** | The name of the registered application to which the token belongs. | [optional] 
**ExpirationTime** | **System.DateTime** | Expiration time for the JWT token to which it can be refreshed. | [optional] [readonly] 
**LastLoginClient** | **String** | The client address from which last login is initiated. | [optional] [readonly] 
**LastLoginTime** | **System.DateTime** | The last login time for user. | [optional] [readonly] 
**TokenId** | **String** | Token identifier. Not the Access Token itself. | [optional] [readonly] 
**UserMeta** | [**IamClientMeta**](IamClientMeta.md) |  | [optional] 
**AppRegistration** | [**IamAppRegistrationRelationship**](IamAppRegistrationRelationship.md) |  | [optional] 
**Permission** | [**IamPermissionRelationship**](IamPermissionRelationship.md) |  | [optional] 
**User** | [**IamUserRelationship**](IamUserRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamOAuthTokenAllOf = Initialize-IntersightIamOAuthTokenAllOf  -ClassId null `
 -ObjectType null `
 -AccessExpirationTime null `
 -ClientId null `
 -ClientIpAddress null `
 -ClientName null `
 -ExpirationTime null `
 -LastLoginClient null `
 -LastLoginTime null `
 -TokenId null `
 -UserMeta null `
 -AppRegistration null `
 -Permission null `
 -User null
```

- Convert the resource to JSON
```powershell
$IamOAuthTokenAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

