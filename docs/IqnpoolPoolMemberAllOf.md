# IqnpoolPoolMemberAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iqnpool.PoolMember"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iqnpool.PoolMember"]
**IqnAddress** | **String** | IQN Address of this pool member. | [optional] 
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**BlockHead** | [**IqnpoolBlockRelationship**](IqnpoolBlockRelationship.md) |  | [optional] 
**Peer** | [**IqnpoolLeaseRelationship**](IqnpoolLeaseRelationship.md) |  | [optional] 
**Pool** | [**IqnpoolPoolRelationship**](IqnpoolPoolRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IqnpoolPoolMemberAllOf = Initialize-IntersightIqnpoolPoolMemberAllOf  -ClassId null `
 -ObjectType null `
 -IqnAddress null `
 -AssignedToEntity null `
 -BlockHead null `
 -Peer null `
 -Pool null
```

- Convert the resource to JSON
```powershell
$IqnpoolPoolMemberAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

