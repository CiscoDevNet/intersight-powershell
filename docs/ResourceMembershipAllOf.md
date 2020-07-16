# ResourceMembershipAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupPermissionRoles** | [**IamGroupPermissionToRoles[]**](IamGroupPermissionToRoles.md) |  | [optional] 
**TargetApp** | **String** | Name of the Service owning the resource. | [optional] [readonly] 
**Holder** | [**ResourceMembershipHolderRelationship**](ResourceMembershipHolderRelationship.md) |  | [optional] 
**Resource** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightResourceMembershipAllOf  -GroupPermissionRoles null `
 -TargetApp null `
 -Holder null `
 -Resource null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

