# UuidpoolUuidLeaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **String** | UUID Prefix+Suffix numbers. | [optional] 
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**Pool** | [**UuidpoolPoolRelationship**](UuidpoolPoolRelationship.md) |  | [optional] 
**PoolMember** | [**UuidpoolPoolMemberRelationship**](UuidpoolPoolMemberRelationship.md) |  | [optional] 
**Universe** | [**UuidpoolUniverseRelationship**](UuidpoolUniverseRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightUuidpoolUuidLeaseAllOf  -Uuid null `
 -AssignedToEntity null `
 -Pool null `
 -PoolMember null `
 -Universe null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

