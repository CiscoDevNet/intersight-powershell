# FcpoolLeaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fcpool.Lease"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fcpool.Lease"]
**PoolPurpose** | **String** | Purpose of this WWN pool. | [optional] [readonly] 
**WwnId** | **String** | WWN ID allocated for pool based allocation. | [optional] 
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**Pool** | [**FcpoolPoolRelationship**](FcpoolPoolRelationship.md) |  | [optional] 
**PoolMember** | [**FcpoolPoolMemberRelationship**](FcpoolPoolMemberRelationship.md) |  | [optional] 
**Universe** | [**FcpoolUniverseRelationship**](FcpoolUniverseRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FcpoolLeaseAllOf = Initialize-IntersightFcpoolLeaseAllOf  -ClassId null `
 -ObjectType null `
 -PoolPurpose null `
 -WwnId null `
 -AssignedToEntity null `
 -Pool null `
 -PoolMember null `
 -Universe null
```

- Convert the resource to JSON
```powershell
$FcpoolLeaseAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

