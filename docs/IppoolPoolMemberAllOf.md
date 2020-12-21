# IppoolPoolMemberAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "ippool.PoolMember"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "ippool.PoolMember"]
**IpType** | **String** | Type of the IP address requested. * &#x60;IPv4&#x60; - IP V4 address type requested. * &#x60;IPv6&#x60; - IP V6 address type requested. | [optional] [default to "IPv4"]
**IpV4Address** | **String** | IPv4 Address of this pool member. | [optional] 
**IpV6Address** | **String** | IPv6 Address of this pool member. | [optional] 
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**IpBlock** | [**IppoolShadowBlockRelationship**](IppoolShadowBlockRelationship.md) |  | [optional] 
**Peer** | [**IppoolIpLeaseRelationship**](IppoolIpLeaseRelationship.md) |  | [optional] 
**Pool** | [**IppoolShadowPoolRelationship**](IppoolShadowPoolRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IppoolPoolMemberAllOf = Initialize-IntersightIppoolPoolMemberAllOf  -ClassId null `
 -ObjectType null `
 -IpType null `
 -IpV4Address null `
 -IpV6Address null `
 -AssignedToEntity null `
 -IpBlock null `
 -Peer null `
 -Pool null
```

- Convert the resource to JSON
```powershell
$IppoolPoolMemberAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

