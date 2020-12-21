# IamPermissionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.Permission"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.Permission"]
**Description** | **String** | The informative description about each permission. | [optional] 
**Name** | **String** | The name of the permission which has to be granted to user. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**EndPointRoles** | [**IamEndPointRoleRelationship[]**](IamEndPointRoleRelationship.md) | An array of relationships to iamEndPointRole resources. | [optional] [readonly] 
**PrivilegeSets** | [**IamPrivilegeSetRelationship[]**](IamPrivilegeSetRelationship.md) | An array of relationships to iamPrivilegeSet resources. | [optional] [readonly] 
**ResourceRoles** | [**IamResourceRolesRelationship[]**](IamResourceRolesRelationship.md) | An array of relationships to iamResourceRoles resources. | [optional] 
**Roles** | [**IamRoleRelationship[]**](IamRoleRelationship.md) | An array of relationships to iamRole resources. | [optional] 
**SessionLimits** | [**IamSessionLimitsRelationship**](IamSessionLimitsRelationship.md) |  | [optional] 
**UserGroups** | [**IamUserGroupRelationship[]**](IamUserGroupRelationship.md) | An array of relationships to iamUserGroup resources. | [optional] 
**Users** | [**IamUserRelationship[]**](IamUserRelationship.md) | An array of relationships to iamUser resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$IamPermissionAllOf = Initialize-IntersightIamPermissionAllOf  -ClassId null `
 -ObjectType null `
 -Description null `
 -Name null `
 -Account null `
 -EndPointRoles null `
 -PrivilegeSets null `
 -ResourceRoles null `
 -Roles null `
 -SessionLimits null `
 -UserGroups null `
 -Users null
```

- Convert the resource to JSON
```powershell
$IamPermissionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

