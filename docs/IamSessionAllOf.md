# IamSessionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.Session"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.Session"]
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
$IamSessionAllOf = Initialize-IntersightIamSessionAllOf  -ClassId null `
 -ObjectType null `
 -AccountPermissions null `
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
$IamSessionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

