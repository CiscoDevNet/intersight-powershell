# IamUser
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
**ClientIpAddress** | **String** | IP address from which the user last logged in to Intersight. | [optional] [readonly] 
**Email** | **String** | Email of the user. Users are added to Intersight using the email configured in the IdP. | [optional] 
**FirstName** | **String** | First name of the user. This field is populated from the IdP attributes received after authentication. | [optional] [readonly] 
**LastLoginTime** | **System.DateTime** | Last successful login time for user. | [optional] [readonly] 
**LastName** | **String** | Last name of the user. This field is populated from the IdP attributes received after authentication. | [optional] [readonly] 
**Name** | **String** | Name as configured in the IdP. | [optional] [readonly] 
**UserIdOrEmail** | **String** | UserID or email as configured in the IdP. | [optional] 
**UserType** | **String** | Type of the User. If a user is added manually by specifying the email address, or has logged in using groups, based on the IdP attributes received during authentication. If added manually, the user type will be static, otherwise dynamic. | [optional] [readonly] 
**UserUniqueIdentifier** | **String** | Unique id of the user used by the identity provider to store the user. | [optional] [readonly] 
**ApiKeys** | [**IamApiKeyRelationship[]**](IamApiKeyRelationship.md) | An array of relationships to iamApiKey resources. | [optional] [readonly] 
**AppRegistrations** | [**IamAppRegistrationRelationship[]**](IamAppRegistrationRelationship.md) | An array of relationships to iamAppRegistration resources. | [optional] [readonly] 
**Idp** | [**IamIdpRelationship**](IamIdpRelationship.md) |  | [optional] 
**Idpreference** | [**IamIdpReferenceRelationship**](IamIdpReferenceRelationship.md) |  | [optional] 
**LocalUserPassword** | [**IamLocalUserPasswordRelationship**](IamLocalUserPasswordRelationship.md) |  | [optional] 
**OauthTokens** | [**IamOAuthTokenRelationship[]**](IamOAuthTokenRelationship.md) | An array of relationships to iamOAuthToken resources. | [optional] [readonly] 
**Permissions** | [**IamPermissionRelationship[]**](IamPermissionRelationship.md) | An array of relationships to iamPermission resources. | [optional] 
**Sessions** | [**IamSessionRelationship[]**](IamSessionRelationship.md) | An array of relationships to iamSession resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamUser  -AccountMoid null `
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
 -ClientIpAddress null `
 -Email null `
 -FirstName null `
 -LastLoginTime null `
 -LastName null `
 -Name null `
 -UserIdOrEmail null `
 -UserType null `
 -UserUniqueIdentifier null `
 -ApiKeys null `
 -AppRegistrations null `
 -Idp null `
 -Idpreference null `
 -LocalUserPassword null `
 -OauthTokens null `
 -Permissions null `
 -Sessions null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

