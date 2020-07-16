# IamResourceRolesAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndPointRoles** | [**IamEndPointRoleRelationship[]**](IamEndPointRoleRelationship.md) | An array of relationships to iamEndPointRole resources. | [optional] [readonly] 
**Permission** | [**IamPermissionRelationship**](IamPermissionRelationship.md) |  | [optional] 
**Resource** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**Roles** | [**IamRoleRelationship[]**](IamRoleRelationship.md) | An array of relationships to iamRole resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamResourceRolesAllOf  -EndPointRoles null `
 -Permission null `
 -Resource null `
 -Roles null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

