# ResourceMembershipAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "resource.Membership"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "resource.Membership"]
**GroupPermissionRoles** | [**IamGroupPermissionToRoles[]**](IamGroupPermissionToRoles.md) |  | [optional] 
**TargetApp** | **String** | Name of the Service owning the resource. | [optional] [readonly] 
**Holder** | [**ResourceMembershipHolderRelationship**](ResourceMembershipHolderRelationship.md) |  | [optional] 
**Resource** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ResourceMembershipAllOf = Initialize-IntersightResourceMembershipAllOf  -ClassId null `
 -ObjectType null `
 -GroupPermissionRoles null `
 -TargetApp null `
 -Holder null `
 -Resource null
```

- Convert the resource to JSON
```powershell
$ResourceMembershipAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

