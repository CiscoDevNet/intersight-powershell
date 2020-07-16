# IamSystemAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndPointPrivileges** | [**IamEndPointPrivilegeRelationship[]**](IamEndPointPrivilegeRelationship.md) | An array of relationships to iamEndPointPrivilege resources. | [optional] [readonly] 
**EndPointRoles** | [**IamEndPointRoleRelationship[]**](IamEndPointRoleRelationship.md) | An array of relationships to iamEndPointRole resources. | [optional] [readonly] 
**Idp** | [**IamIdpRelationship**](IamIdpRelationship.md) |  | [optional] 
**PrivilegeSets** | [**IamPrivilegeSetRelationship[]**](IamPrivilegeSetRelationship.md) | An array of relationships to iamPrivilegeSet resources. | [optional] [readonly] 
**Privileges** | [**IamPrivilegeRelationship[]**](IamPrivilegeRelationship.md) | An array of relationships to iamPrivilege resources. | [optional] [readonly] 
**Roles** | [**IamRoleRelationship[]**](IamRoleRelationship.md) | An array of relationships to iamRole resources. | [optional] [readonly] 
**ServiceProvider** | [**IamServiceProviderRelationship**](IamServiceProviderRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamSystemAllOf  -EndPointPrivileges null `
 -EndPointRoles null `
 -Idp null `
 -PrivilegeSets null `
 -Privileges null `
 -Roles null `
 -ServiceProvider null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

