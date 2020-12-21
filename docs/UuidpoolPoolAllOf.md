# UuidpoolPoolAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "uuidpool.Pool"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "uuidpool.Pool"]
**Prefix** | **String** | The UUID prefix must be in hexadecimal format xxxxxxxx-xxxx-xxxx. | [optional] 
**UuidSuffixBlocks** | [**UuidpoolUuidBlock[]**](UuidpoolUuidBlock.md) |  | [optional] 
**BlockHeads** | [**UuidpoolBlockRelationship[]**](UuidpoolBlockRelationship.md) | An array of relationships to uuidpoolBlock resources. | [optional] [readonly] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$UuidpoolPoolAllOf = Initialize-IntersightUuidpoolPoolAllOf  -ClassId null `
 -ObjectType null `
 -Prefix null `
 -UuidSuffixBlocks null `
 -BlockHeads null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$UuidpoolPoolAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

