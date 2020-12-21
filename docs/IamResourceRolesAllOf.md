# IamResourceRolesAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.ResourceRoles"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.ResourceRoles"]
**EndPointRoles** | [**IamEndPointRoleRelationship[]**](IamEndPointRoleRelationship.md) | An array of relationships to iamEndPointRole resources. | [optional] [readonly] 
**Permission** | [**IamPermissionRelationship**](IamPermissionRelationship.md) |  | [optional] 
**PrivilegeSets** | [**IamPrivilegeSetRelationship[]**](IamPrivilegeSetRelationship.md) | An array of relationships to iamPrivilegeSet resources. | [optional] [readonly] 
**Resource** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**Roles** | [**IamRoleRelationship[]**](IamRoleRelationship.md) | An array of relationships to iamRole resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$IamResourceRolesAllOf = Initialize-IntersightIamResourceRolesAllOf  -ClassId null `
 -ObjectType null `
 -EndPointRoles null `
 -Permission null `
 -PrivilegeSets null `
 -Resource null `
 -Roles null
```

- Convert the resource to JSON
```powershell
$IamResourceRolesAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

