# IamLdapGroupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.LdapGroup"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.LdapGroup"]
**Domain** | **String** | LDAP server domain the Group resides in. | [optional] 
**Name** | **String** | LDAP Group name in the LDAP server database. | [optional] 
**EndPointRole** | [**IamEndPointRoleRelationship[]**](IamEndPointRoleRelationship.md) | An array of relationships to iamEndPointRole resources. | [optional] 
**LdapPolicy** | [**IamLdapPolicyRelationship**](IamLdapPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamLdapGroupAllOf = Initialize-IntersightIamLdapGroupAllOf  -ClassId null `
 -ObjectType null `
 -Domain null `
 -Name null `
 -EndPointRole null `
 -LdapPolicy null
```

- Convert the resource to JSON
```powershell
$IamLdapGroupAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

