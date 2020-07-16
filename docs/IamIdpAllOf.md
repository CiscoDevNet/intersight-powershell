# IamIdpAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DomainName** | **String** | Email domain name of the user for this IdP. When a user enters an email during login in the Intersight home page, the IdP is picked by matching this domain name with the email domain name for authentication. | [optional] 
**IdpEntityId** | **String** | The Entity ID of the IdP. In SAML, the entity ID uniquely identifies the IdP or Service Provider. | [optional] [readonly] 
**Metadata** | **String** | SAML metadata of the IdP. | [optional] 
**Name** | **String** | The name of the Identity Provider, for example Cisco, Okta, or OneID. | [optional] 
**Type** | **String** | Authentication protocol used by the IdP. | [optional] [default to "saml"]
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**LdapPolicy** | [**IamLdapPolicyRelationship**](IamLdapPolicyRelationship.md) |  | [optional] 
**System** | [**IamSystemRelationship**](IamSystemRelationship.md) |  | [optional] 
**UserPreferences** | [**IamUserPreferenceRelationship[]**](IamUserPreferenceRelationship.md) | An array of relationships to iamUserPreference resources. | [optional] [readonly] 
**Usergroups** | [**IamUserGroupRelationship[]**](IamUserGroupRelationship.md) | An array of relationships to iamUserGroup resources. | [optional] 
**Users** | [**IamUserRelationship[]**](IamUserRelationship.md) | An array of relationships to iamUser resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamIdpAllOf  -DomainName null `
 -IdpEntityId null `
 -Metadata null `
 -Name null `
 -Type null `
 -Account null `
 -LdapPolicy null `
 -System null `
 -UserPreferences null `
 -Usergroups null `
 -Users null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

