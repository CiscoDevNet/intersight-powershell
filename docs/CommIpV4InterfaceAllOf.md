# CommIpV4InterfaceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "comm.IpV4Interface"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "comm.IpV4Interface"]
**Gateway** | **String** | The IPv4 address of the default gateway. | [optional] 
**IpAddress** | **String** | The IPv4 Address, represented in the standard dot-decimal notation, e.g. 192.168.1.3. | [optional] 
**Netmask** | **String** | The IPv4 Netmask, represented in the standard dot-decimal notation, e.g. 255.255.255.0. | [optional] 

## Examples

- Prepare the resource
```powershell
$CommIpV4InterfaceAllOf = Initialize-IntersightCommIpV4InterfaceAllOf  -ClassId null `
 -ObjectType null `
 -Gateway null `
 -IpAddress null `
 -Netmask null
```

- Convert the resource to JSON
```powershell
$CommIpV4InterfaceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

