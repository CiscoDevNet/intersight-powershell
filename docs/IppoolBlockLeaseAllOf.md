# IppoolBlockLeaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "ippool.BlockLease"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "ippool.BlockLease"]
**IpType** | **String** | Type of the IP address requested. * &#x60;IPv4&#x60; - IP V4 address type requested. * &#x60;IPv6&#x60; - IP V6 address type requested. | [optional] [default to "IPv4"]
**AssignedToEntity** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**IpLeases** | [**IppoolIpLeaseRelationship[]**](IppoolIpLeaseRelationship.md) | An array of relationships to ippoolIpLease resources. | [optional] 
**Pool** | [**IppoolPoolRelationship**](IppoolPoolRelationship.md) |  | [optional] 
**Universe** | [**IppoolUniverseRelationship**](IppoolUniverseRelationship.md) |  | [optional] 
**Vrf** | [**VrfVrfRelationship**](VrfVrfRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IppoolBlockLeaseAllOf = Initialize-IntersightIppoolBlockLeaseAllOf  -ClassId null `
 -ObjectType null `
 -IpType null `
 -AssignedToEntity null `
 -IpLeases null `
 -Pool null `
 -Universe null `
 -Vrf null
```

- Convert the resource to JSON
```powershell
$IppoolBlockLeaseAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

