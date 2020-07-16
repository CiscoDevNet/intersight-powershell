# IppoolIpV4ConfigAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gateway** | **String** | IP address of the default IPv4 gateway. | [optional] [readonly] 
**Netmask** | **String** | A subnet mask is a 32-bit number that masks an IP address and divides the IP address into network address and host address. | [optional] [readonly] 
**PrimaryDns** | **String** | IP Address of the primary Domain Name System (DNS) server. | [optional] [readonly] 
**SecondaryDns** | **String** | IP Address of the secondary Domain Name System (DNS) server. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIppoolIpV4ConfigAllOf  -Gateway null `
 -Netmask null `
 -PrimaryDns null `
 -SecondaryDns null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

