# IppoolPoolMemberAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IpV4Address** | **String** | IPv4 Address of this pool member. | [optional] 
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**IpV4Block** | [**IppoolShadowBlockRelationship**](IppoolShadowBlockRelationship.md) |  | [optional] 
**Peer** | [**IppoolIpLeaseRelationship**](IppoolIpLeaseRelationship.md) |  | [optional] 
**Pool** | [**IppoolShadowPoolRelationship**](IppoolShadowPoolRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIppoolPoolMemberAllOf  -IpV4Address null `
 -AssignedToEntity null `
 -IpV4Block null `
 -Peer null `
 -Pool null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

