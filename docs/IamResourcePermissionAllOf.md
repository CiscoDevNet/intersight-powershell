# IamResourcePermissionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PermissionRoles** | [**IamPermissionToRoles[]**](IamPermissionToRoles.md) |  | [optional] 
**TargetApp** | **String** | Name of the service owning the resource. | [optional] [readonly] 
**Holder** | [**IamSecurityHolderRelationship**](IamSecurityHolderRelationship.md) |  | [optional] 
**Resource** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamResourcePermissionAllOf  -PermissionRoles null `
 -TargetApp null `
 -Holder null `
 -Resource null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

