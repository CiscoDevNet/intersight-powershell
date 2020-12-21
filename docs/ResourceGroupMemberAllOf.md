# ResourceGroupMemberAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "resource.GroupMember"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "resource.GroupMember"]
**Group** | [**ResourceGroupRelationship**](ResourceGroupRelationship.md) |  | [optional] 
**Resource** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ResourceGroupMemberAllOf = Initialize-IntersightResourceGroupMemberAllOf  -ClassId null `
 -ObjectType null `
 -Group null `
 -Resource null
```

- Convert the resource to JSON
```powershell
$ResourceGroupMemberAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

