# HyperflexIpAddrRangeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.IpAddrRange"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.IpAddrRange"]
**EndAddr** | **String** | The end IPv4 address of the range. | [optional] 
**Gateway** | **String** | The default gateway for the start and end IPv4 addresses. | [optional] 
**Netmask** | **String** | The netmask specified in dot decimal notation. The start address, end address, and gateway must all be within the network specified by this netmask. | [optional] 
**StartAddr** | **String** | The start IPv4 address of the range. | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexIpAddrRangeAllOf = Initialize-IntersightHyperflexIpAddrRangeAllOf  -ClassId null `
 -ObjectType null `
 -EndAddr null `
 -Gateway null `
 -Netmask null `
 -StartAddr null
```

- Convert the resource to JSON
```powershell
$HyperflexIpAddrRangeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

