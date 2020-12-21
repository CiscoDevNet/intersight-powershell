# UuidpoolPoolMemberAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "uuidpool.PoolMember"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "uuidpool.PoolMember"]
**Uuid** | **String** | UUID Prefix+Suffix of this PoolMember. | [optional] 
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**BlockHead** | [**UuidpoolBlockRelationship**](UuidpoolBlockRelationship.md) |  | [optional] 
**Peer** | [**UuidpoolUuidLeaseRelationship**](UuidpoolUuidLeaseRelationship.md) |  | [optional] 
**Pool** | [**UuidpoolPoolRelationship**](UuidpoolPoolRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$UuidpoolPoolMemberAllOf = Initialize-IntersightUuidpoolPoolMemberAllOf  -ClassId null `
 -ObjectType null `
 -Uuid null `
 -AssignedToEntity null `
 -BlockHead null `
 -Peer null `
 -Pool null
```

- Convert the resource to JSON
```powershell
$UuidpoolPoolMemberAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

