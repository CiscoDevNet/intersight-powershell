# IamPermissionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** | The informative description about each permission. | [optional] 
**Name** | **String** | The name of the permission which has to be granted to user. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**EndPointRoles** | [**IamEndPointRoleRelationship[]**](IamEndPointRoleRelationship.md) | An array of relationships to iamEndPointRole resources. | [optional] [readonly] 
**ResourceRoles** | [**IamResourceRolesRelationship[]**](IamResourceRolesRelationship.md) | An array of relationships to iamResourceRoles resources. | [optional] 
**Roles** | [**IamRoleRelationship[]**](IamRoleRelationship.md) | An array of relationships to iamRole resources. | [optional] 
**SessionLimits** | [**IamSessionLimitsRelationship**](IamSessionLimitsRelationship.md) |  | [optional] 
**UserGroups** | [**IamUserGroupRelationship[]**](IamUserGroupRelationship.md) | An array of relationships to iamUserGroup resources. | [optional] 
**Users** | [**IamUserRelationship[]**](IamUserRelationship.md) | An array of relationships to iamUser resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamPermissionAllOf  -Description null `
 -Name null `
 -Account null `
 -EndPointRoles null `
 -ResourceRoles null `
 -Roles null `
 -SessionLimits null `
 -UserGroups null `
 -Users null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

