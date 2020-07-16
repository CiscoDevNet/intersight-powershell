# HyperflexIpAddrRangeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndAddr** | **String** | The end IPv4 address of the range. | [optional] 
**Gateway** | **String** | The default gateway for the start and end IPv4 addresses. | [optional] 
**Netmask** | **String** | The netmask specified in dot decimal notation. The start address, end address, and gateway must all be within the network specified by this netmask. | [optional] 
**StartAddr** | **String** | The start IPv4 address of the range. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexIpAddrRangeAllOf  -EndAddr null `
 -Gateway null `
 -Netmask null `
 -StartAddr null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

