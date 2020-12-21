# UuidpoolUuidLeaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "uuidpool.UuidLease"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "uuidpool.UuidLease"]
**Uuid** | **String** | UUID Prefix+Suffix numbers. | [optional] 
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**Pool** | [**UuidpoolPoolRelationship**](UuidpoolPoolRelationship.md) |  | [optional] 
**PoolMember** | [**UuidpoolPoolMemberRelationship**](UuidpoolPoolMemberRelationship.md) |  | [optional] 
**Universe** | [**UuidpoolUniverseRelationship**](UuidpoolUniverseRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$UuidpoolUuidLeaseAllOf = Initialize-IntersightUuidpoolUuidLeaseAllOf  -ClassId null `
 -ObjectType null `
 -Uuid null `
 -AssignedToEntity null `
 -Pool null `
 -PoolMember null `
 -Universe null
```

- Convert the resource to JSON
```powershell
$UuidpoolUuidLeaseAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

