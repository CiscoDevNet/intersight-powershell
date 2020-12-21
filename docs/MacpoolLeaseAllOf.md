# MacpoolLeaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "macpool.Lease"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "macpool.Lease"]
**MacAddress** | **String** | MAC address allocated for pool-based allocation. | [optional] 
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**Pool** | [**MacpoolPoolRelationship**](MacpoolPoolRelationship.md) |  | [optional] 
**PoolMember** | [**MacpoolPoolMemberRelationship**](MacpoolPoolMemberRelationship.md) |  | [optional] 
**Universe** | [**MacpoolUniverseRelationship**](MacpoolUniverseRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$MacpoolLeaseAllOf = Initialize-IntersightMacpoolLeaseAllOf  -ClassId null `
 -ObjectType null `
 -MacAddress null `
 -AssignedToEntity null `
 -Pool null `
 -PoolMember null `
 -Universe null
```

- Convert the resource to JSON
```powershell
$MacpoolLeaseAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

