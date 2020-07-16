# UuidpoolPoolAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Prefix** | **String** | The UUID prefix must be in hexadecimal format xxxxxxxx-xxxx-xxxx. | [optional] 
**UuidSuffixBlocks** | [**UuidpoolUuidBlock[]**](UuidpoolUuidBlock.md) |  | [optional] 
**BlockHeads** | [**UuidpoolBlockRelationship[]**](UuidpoolBlockRelationship.md) | An array of relationships to uuidpoolBlock resources. | [optional] [readonly] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightUuidpoolPoolAllOf  -Prefix null `
 -UuidSuffixBlocks null `
 -BlockHeads null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

