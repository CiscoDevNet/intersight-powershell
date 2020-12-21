# IamUserAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.User"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.User"]
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
$IamUserAllOf = Initialize-IntersightIamUserAllOf  -ClassId null `
 -ObjectType null `
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
$IamUserAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

