# IamIdpAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.Idp"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.Idp"]
**DomainName** | **String** | Email domain name of the user for this IdP. When a user enters an email during login in the Intersight home page, the IdP is picked by matching this domain name with the email domain name for authentication. | [optional] 
**EnableSingleLogout** | **Boolean** | Setting that indicates whether &#39;Single Logout (SLO)&#39; has been enabled for this IdP. | [optional] 
**IdpEntityId** | **String** | The Entity ID of the IdP. In SAML, the entity ID uniquely identifies the IdP or Service Provider. | [optional] [readonly] 
**Metadata** | **String** | SAML metadata of the IdP. | [optional] 
**Name** | **String** | The name of the Identity Provider, for example Cisco, Okta, or OneID. | [optional] 
**Type** | **String** | Authentication protocol used by the IdP. * &#x60;saml&#x60; - Use SAML as the authentication protocol for sign-on. * &#x60;oidc&#x60; - Open ID connect to be used as an authentication protocol for sign-on. * &#x60;local&#x60; - The local authentication method to be used for sign-on. Local type is set to default for the Intersight Appliance IdP. | [optional] [default to "saml"]
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**LdapPolicy** | [**IamLdapPolicyRelationship**](IamLdapPolicyRelationship.md) |  | [optional] 
**System** | [**IamSystemRelationship**](IamSystemRelationship.md) |  | [optional] 
**UserPreferences** | [**IamUserPreferenceRelationship[]**](IamUserPreferenceRelationship.md) | An array of relationships to iamUserPreference resources. | [optional] [readonly] 
**Usergroups** | [**IamUserGroupRelationship[]**](IamUserGroupRelationship.md) | An array of relationships to iamUserGroup resources. | [optional] 
**Users** | [**IamUserRelationship[]**](IamUserRelationship.md) | An array of relationships to iamUser resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$IamIdpAllOf = Initialize-IntersightIamIdpAllOf  -ClassId null `
 -ObjectType null `
 -DomainName null `
 -EnableSingleLogout null `
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
$IamIdpAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

