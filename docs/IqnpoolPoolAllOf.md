# IqnpoolPoolAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iqnpool.Pool"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iqnpool.Pool"]
**IqnSuffixBlocks** | [**IqnpoolIqnSuffixBlock[]**](IqnpoolIqnSuffixBlock.md) |  | [optional] 
**Prefix** | **String** | The prefix for IQN blocks created for this pool. | [optional] 
**BlockHeads** | [**IqnpoolBlockRelationship[]**](IqnpoolBlockRelationship.md) | An array of relationships to iqnpoolBlock resources. | [optional] [readonly] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IqnpoolPoolAllOf = Initialize-IntersightIqnpoolPoolAllOf  -ClassId null `
 -ObjectType null `
 -IqnSuffixBlocks null `
 -Prefix null `
 -BlockHeads null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$IqnpoolPoolAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

