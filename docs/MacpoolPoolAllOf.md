# MacpoolPoolAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MacBlocks** | [**MacpoolBlock[]**](MacpoolBlock.md) |  | [optional] 
**BlockHeads** | [**MacpoolIdBlockRelationship[]**](MacpoolIdBlockRelationship.md) | An array of relationships to macpoolIdBlock resources. | [optional] [readonly] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMacpoolPoolAllOf  -MacBlocks null `
 -BlockHeads null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

