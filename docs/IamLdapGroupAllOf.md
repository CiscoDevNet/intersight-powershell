# IamLdapGroupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Domain** | **String** | LDAP server domain the Group resides in. | [optional] 
**Name** | **String** | LDAP Group name in the LDAP server database. | [optional] 
**EndPointRole** | [**IamEndPointRoleRelationship[]**](IamEndPointRoleRelationship.md) | An array of relationships to iamEndPointRole resources. | [optional] 
**LdapPolicy** | [**IamLdapPolicyRelationship**](IamLdapPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamLdapGroupAllOf  -Domain null `
 -Name null `
 -EndPointRole null `
 -LdapPolicy null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

