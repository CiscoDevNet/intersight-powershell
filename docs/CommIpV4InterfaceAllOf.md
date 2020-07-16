# CommIpV4InterfaceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gateway** | **String** | The IPv4 address of the default gateway. | [optional] 
**IpAddress** | **String** | The IPv4 Address, represented in the standard dot-decimal notation, e.g. 192.168.1.3. | [optional] 
**Netmask** | **String** | The IPv4 Netmask, represented in the standard dot-decimal notation, e.g. 255.255.255.0. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCommIpV4InterfaceAllOf  -Gateway null `
 -IpAddress null `
 -Netmask null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

