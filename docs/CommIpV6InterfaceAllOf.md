# CommIpV6InterfaceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gateway** | **String** | The IPv6 address of the default gateway. | [optional] 
**IpAddress** | **String** | The IPv6 Address, represented as eight groups of four hexadecimal digits, separated by colons. | [optional] 
**Prefix** | **String** | The IPv6 Prefix, represented as eight groups of four hexadecimal digits, separated by colons. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCommIpV6InterfaceAllOf  -Gateway null `
 -IpAddress null `
 -Prefix null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

