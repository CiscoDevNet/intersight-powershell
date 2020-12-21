# MacpoolPoolMemberAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "macpool.PoolMember"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "macpool.PoolMember"]
**MacAddress** | **String** | MAC Address of this pool member. | [optional] 
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**BlockHead** | [**MacpoolIdBlockRelationship**](MacpoolIdBlockRelationship.md) |  | [optional] 
**Peer** | [**MacpoolLeaseRelationship**](MacpoolLeaseRelationship.md) |  | [optional] 
**Pool** | [**MacpoolPoolRelationship**](MacpoolPoolRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$MacpoolPoolMemberAllOf = Initialize-IntersightMacpoolPoolMemberAllOf  -ClassId null `
 -ObjectType null `
 -MacAddress null `
 -AssignedToEntity null `
 -BlockHead null `
 -Peer null `
 -Pool null
```

- Convert the resource to JSON
```powershell
$MacpoolPoolMemberAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

