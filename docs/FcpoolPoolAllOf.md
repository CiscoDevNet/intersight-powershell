# FcpoolPoolAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fcpool.Pool"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fcpool.Pool"]
**IdBlocks** | [**FcpoolBlock[]**](FcpoolBlock.md) |  | [optional] 
**PoolPurpose** | **String** | Purpose of this WWN pool. | [optional] 
**BlockHeads** | [**FcpoolFcBlockRelationship[]**](FcpoolFcBlockRelationship.md) | An array of relationships to fcpoolFcBlock resources. | [optional] [readonly] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FcpoolPoolAllOf = Initialize-IntersightFcpoolPoolAllOf  -ClassId null `
 -ObjectType null `
 -IdBlocks null `
 -PoolPurpose null `
 -BlockHeads null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$FcpoolPoolAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

