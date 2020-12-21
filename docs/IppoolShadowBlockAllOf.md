# IppoolShadowBlockAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "ippool.ShadowBlock"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "ippool.ShadowBlock"]
**IpType** | **String** | Type of this IP addresses blocks. * &#x60;IPv4&#x60; - IP V4 address type requested. * &#x60;IPv6&#x60; - IP V6 address type requested. | [optional] [default to "IPv4"]
**IpV4Block** | [**IppoolIpV4Block**](IppoolIpV4Block.md) |  | [optional] 
**IpV6Block** | [**IppoolIpV6Block**](IppoolIpV6Block.md) |  | [optional] 
**Pool** | [**IppoolShadowPoolRelationship**](IppoolShadowPoolRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IppoolShadowBlockAllOf = Initialize-IntersightIppoolShadowBlockAllOf  -ClassId null `
 -ObjectType null `
 -IpType null `
 -IpV4Block null `
 -IpV6Block null `
 -Pool null
```

- Convert the resource to JSON
```powershell
$IppoolShadowBlockAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

