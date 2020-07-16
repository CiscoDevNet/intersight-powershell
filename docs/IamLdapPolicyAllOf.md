# IamLdapPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseProperties** | [**IamLdapBaseProperties**](IamLdapBaseProperties.md) |  | [optional] 
**DnsParameters** | [**IamLdapDnsParameters**](IamLdapDnsParameters.md) |  | [optional] 
**EnableDns** | **Boolean** | Enables DNS to access LDAP servers. | [optional] 
**Enabled** | **Boolean** | LDAP server performs authentication. | [optional] 
**UserSearchPrecedence** | **String** | Search precedence between local user database and LDAP user database. | [optional] [default to "LocalUserDb"]
**Var0Idp** | [**IamIdpRelationship**](IamIdpRelationship.md) |  | [optional] 
**ApplianceAccount** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Groups** | [**IamLdapGroupRelationship[]**](IamLdapGroupRelationship.md) | An array of relationships to iamLdapGroup resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 
**Providers** | [**IamLdapProviderRelationship[]**](IamLdapProviderRelationship.md) | An array of relationships to iamLdapProvider resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamLdapPolicyAllOf  -BaseProperties null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

