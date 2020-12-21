# IamResourcePermissionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.ResourcePermission"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.ResourcePermission"]
**PermissionRoles** | [**IamPermissionToRoles[]**](IamPermissionToRoles.md) |  | [optional] 
**TargetApp** | **String** | Name of the service owning the resource. | [optional] [readonly] 
**Holder** | [**IamSecurityHolderRelationship**](IamSecurityHolderRelationship.md) |  | [optional] 
**Resource** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamResourcePermissionAllOf = Initialize-IntersightIamResourcePermissionAllOf  -ClassId null `
 -ObjectType null `
 -PermissionRoles null `
 -TargetApp null `
 -Holder null `
 -Resource null
```

- Convert the resource to JSON
```powershell
$IamResourcePermissionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

