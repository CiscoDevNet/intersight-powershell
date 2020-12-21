# CommIpV6Interface
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "comm.IpV6Interface"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "comm.IpV6Interface"]
**Gateway** | **String** | The IPv6 address of the default gateway. | [optional] 
**IpAddress** | **String** | The IPv6 Address, represented as eight groups of four hexadecimal digits, separated by colons. | [optional] 
**Prefix** | **String** | The IPv6 Prefix, represented as eight groups of four hexadecimal digits, separated by colons. | [optional] 

## Examples

- Prepare the resource
```powershell
$CommIpV6Interface = Initialize-IntersightCommIpV6Interface  -ClassId null `
 -ObjectType null `
 -Gateway null `
 -IpAddress null `
 -Prefix null
```

- Convert the resource to JSON
```powershell
$CommIpV6Interface | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

