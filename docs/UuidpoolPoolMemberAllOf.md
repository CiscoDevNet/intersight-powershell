# UuidpoolPoolMemberAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **String** | UUID Prefix+Suffix of this PoolMember. | [optional] 
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**BlockHead** | [**UuidpoolBlockRelationship**](UuidpoolBlockRelationship.md) |  | [optional] 
**Peer** | [**UuidpoolUuidLeaseRelationship**](UuidpoolUuidLeaseRelationship.md) |  | [optional] 
**Pool** | [**UuidpoolPoolRelationship**](UuidpoolPoolRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightUuidpoolPoolMemberAllOf  -Uuid null `
 -AssignedToEntity null `
 -BlockHead null `
 -Peer null `
 -Pool null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

