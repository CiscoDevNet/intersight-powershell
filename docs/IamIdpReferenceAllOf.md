# IamIdpReferenceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DomainName** | **String** | The email domain name for this IdP of the user. When a user enters an email during login in the Intersight home page, the IdP is picked by matching this domain name with the email domain name for authentication. | [optional] [readonly] 
**IdpEntityId** | **String** | Entity ID of the IdP. In SAML, the entity ID uniquely identifies the IdP/Service Provider. | [optional] [readonly] 
**MultiFactorAuthentication** | **Boolean** | The flag represents if the second factor of authentication is required for Cisco IdP users. | [optional] 
**Name** | **String** | Cisco IdP reference in an account. | [optional] [readonly] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Idp** | [**IamIdpRelationship**](IamIdpRelationship.md) |  | [optional] 
**UserPreferences** | [**IamUserPreferenceRelationship[]**](IamUserPreferenceRelationship.md) | An array of relationships to iamUserPreference resources. | [optional] [readonly] 
**Usergroups** | [**IamUserGroupRelationship[]**](IamUserGroupRelationship.md) | An array of relationships to iamUserGroup resources. | [optional] 
**Users** | [**IamUserRelationship[]**](IamUserRelationship.md) | An array of relationships to iamUser resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamIdpReferenceAllOf  -DomainName null `
 -IdpEntityId null `
 -MultiFactorAuthentication null `
 -Name null `
 -Account null `
 -Idp null `
 -UserPreferences null `
 -Usergroups null `
 -Users null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

