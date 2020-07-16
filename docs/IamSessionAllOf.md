# IamSessionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountPermissions** | [**IamAccountPermissions[]**](IamAccountPermissions.md) |  | [optional] 
**ClientIpAddress** | **String** | The user agent IP address from which the session is launched. | [optional] [readonly] 
**Expiration** | **System.DateTime** | Expiration time for the session. | [optional] [readonly] 
**IdleTimeExpiration** | **System.DateTime** | Idle time expiration for the session. | [optional] [readonly] 
**LastLoginClient** | **String** | The client address from which last login is initiated. | [optional] [readonly] 
**LastLoginTime** | **System.DateTime** | The last login time for user. | [optional] [readonly] 
**Permission** | [**IamPermissionRelationship**](IamPermissionRelationship.md) |  | [optional] 
**User** | [**IamUserRelationship**](IamUserRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamSessionAllOf  -AccountPermissions null `
 -ClientIpAddress null `
 -Expiration null `
 -IdleTimeExpiration null `
 -LastLoginClient null `
 -LastLoginTime null `
 -Permission null `
 -User null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

