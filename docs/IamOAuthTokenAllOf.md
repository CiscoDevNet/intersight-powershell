# IamOAuthTokenAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
Initialize-IntersightIamOAuthTokenAllOf  -AccessExpirationTime null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

