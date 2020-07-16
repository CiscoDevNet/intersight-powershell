# ResourceGroupMemberAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Group** | [**ResourceGroupRelationship**](ResourceGroupRelationship.md) |  | [optional] 
**Resource** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightResourceGroupMemberAllOf  -Group null `
 -Resource null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

