# IppoolIpLeaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpV4Address** | **String** | IPv4 Address given as a lease to an external entity like server profiles. | [optional] [readonly] 
**IpV4Config** | [**IppoolIpV4Config**](IppoolIpV4Config.md) |  | [optional] 
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**Pool** | [**IppoolPoolRelationship**](IppoolPoolRelationship.md) |  | [optional] 
**PoolMember** | [**IppoolPoolMemberRelationship**](IppoolPoolMemberRelationship.md) |  | [optional] 
**Universe** | [**IppoolUniverseRelationship**](IppoolUniverseRelationship.md) |  | [optional] 
**Vrf** | [**VrfVrfRelationship**](VrfVrfRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIppoolIpLeaseAllOf  -IpV4Address null `
 -IpV4Config null `
 -AssignedToEntity null `
 -Pool null `
 -PoolMember null `
 -Universe null `
 -Vrf null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

