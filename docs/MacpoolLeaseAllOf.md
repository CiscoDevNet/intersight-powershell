# MacpoolLeaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MacAddress** | **String** | MAC address allocated for pool-based allocation. | [optional] 
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**Pool** | [**MacpoolPoolRelationship**](MacpoolPoolRelationship.md) |  | [optional] 
**PoolMember** | [**MacpoolPoolMemberRelationship**](MacpoolPoolMemberRelationship.md) |  | [optional] 
**Universe** | [**MacpoolUniverseRelationship**](MacpoolUniverseRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMacpoolLeaseAllOf  -MacAddress null `
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

