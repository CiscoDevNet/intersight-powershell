# FcpoolPoolMemberAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fcpool.PoolMember"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fcpool.PoolMember"]
**WwnId** | **String** | WWN ID of this pool member. | [optional] 
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**BlockHead** | [**FcpoolFcBlockRelationship**](FcpoolFcBlockRelationship.md) |  | [optional] 
**Peer** | [**FcpoolLeaseRelationship**](FcpoolLeaseRelationship.md) |  | [optional] 
**Pool** | [**FcpoolPoolRelationship**](FcpoolPoolRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FcpoolPoolMemberAllOf = Initialize-IntersightFcpoolPoolMemberAllOf  -ClassId null `
 -ObjectType null `
 -WwnId null `
 -AssignedToEntity null `
 -BlockHead null `
 -Peer null `
 -Pool null
```

- Convert the resource to JSON
```powershell
$FcpoolPoolMemberAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

