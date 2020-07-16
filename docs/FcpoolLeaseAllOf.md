# FcpoolLeaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PoolPurpose** | **String** | Purpose of this WWN pool. | [optional] [readonly] 
**WwnId** | **String** | WWN ID allocated for pool based allocation. | [optional] 
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**Pool** | [**FcpoolPoolRelationship**](FcpoolPoolRelationship.md) |  | [optional] 
**PoolMember** | [**FcpoolPoolMemberRelationship**](FcpoolPoolMemberRelationship.md) |  | [optional] 
**Universe** | [**FcpoolUniverseRelationship**](FcpoolUniverseRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFcpoolLeaseAllOf  -PoolPurpose null `
 -WwnId null `
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

