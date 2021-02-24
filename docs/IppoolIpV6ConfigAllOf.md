# IppoolIpV6ConfigAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "ippool.IpV6Config"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "ippool.IpV6Config"]
**Gateway** | **String** | IP address of the default IPv6 gateway. | [optional] 
**Prefix** | **Int64** | A prefix length which masks the  IP address and divides the IP address into network address and host address. | [optional] 
**PrimaryDns** | **String** | IP Address of the primary Domain Name System (DNS) server. | [optional] 
**SecondaryDns** | **String** | IP Address of the secondary Domain Name System (DNS) server. | [optional] 

## Examples

- Prepare the resource
```powershell
$IppoolIpV6ConfigAllOf = Initialize-IntersightIppoolIpV6ConfigAllOf  -ClassId null `
 -ObjectType null `
 -Gateway null `
 -Prefix null `
 -PrimaryDns null `
 -SecondaryDns null
```

- Convert the resource to JSON
```powershell
$IppoolIpV6ConfigAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

