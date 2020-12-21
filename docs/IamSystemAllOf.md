# IamSystemAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.System"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.System"]
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
$IamSystemAllOf = Initialize-IntersightIamSystemAllOf  -ClassId null `
 -ObjectType null `
 -EndPointPrivileges null `
 -EndPointRoles null `
 -Idp null `
 -PrivilegeSets null `
 -Privileges null `
 -Roles null `
 -ServiceProvider null
```

- Convert the resource to JSON
```powershell
$IamSystemAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

