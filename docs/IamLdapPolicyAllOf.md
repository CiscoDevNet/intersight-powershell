# IamLdapPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.LdapPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.LdapPolicy"]
**BaseProperties** | [**IamLdapBaseProperties**](IamLdapBaseProperties.md) |  | [optional] 
**DnsParameters** | [**IamLdapDnsParameters**](IamLdapDnsParameters.md) |  | [optional] 
**EnableDns** | **Boolean** | Enables DNS to access LDAP servers. | [optional] 
**Enabled** | **Boolean** | LDAP server performs authentication. | [optional] [default to $true]
**UserSearchPrecedence** | **String** | Search precedence between local user database and LDAP user database. * &#x60;LocalUserDb&#x60; - Precedence is given to local user database while searching. * &#x60;LDAPUserDb&#x60; - Precedence is given to LADP user database while searching. | [optional] [default to "LocalUserDb"]
**Var0Idp** | [**IamIdpRelationship**](IamIdpRelationship.md) |  | [optional] 
**ApplianceAccount** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Groups** | [**IamLdapGroupRelationship[]**](IamLdapGroupRelationship.md) | An array of relationships to iamLdapGroup resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 
**Providers** | [**IamLdapProviderRelationship[]**](IamLdapProviderRelationship.md) | An array of relationships to iamLdapProvider resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$IamLdapPolicyAllOf = Initialize-IntersightIamLdapPolicyAllOf  -ClassId null `
 -ObjectType null `
 -BaseProperties null `
 -DnsParameters null `
 -EnableDns null `
 -Enabled null `
 -UserSearchPrecedence null `
 -Var0Idp null `
 -ApplianceAccount null `
 -Groups null `
 -Organization null `
 -Profiles null `
 -Providers null
```

- Convert the resource to JSON
```powershell
$IamLdapPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

