# MacpoolPoolAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "macpool.Pool"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "macpool.Pool"]
**MacBlocks** | [**MacpoolBlock[]**](MacpoolBlock.md) |  | [optional] 
**BlockHeads** | [**MacpoolIdBlockRelationship[]**](MacpoolIdBlockRelationship.md) | An array of relationships to macpoolIdBlock resources. | [optional] [readonly] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$MacpoolPoolAllOf = Initialize-IntersightMacpoolPoolAllOf  -ClassId null `
 -ObjectType null `
 -MacBlocks null `
 -BlockHeads null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$MacpoolPoolAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

