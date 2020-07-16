# VnicRssHashSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ipv4Hash** | **Boolean** | When enabled, the IPv4 address is used for traffic distribution. | [optional] 
**Ipv6ExtHash** | **Boolean** | When enabled, the IPv6 extensions are used for traffic distribution. | [optional] 
**Ipv6Hash** | **Boolean** | When enabled, the IPv6 address is used for traffic distribution. | [optional] 
**TcpIpv4Hash** | **Boolean** | When enabled, both the IPv4 address and TCP port number are used for traffic distribution. | [optional] 
**TcpIpv6ExtHash** | **Boolean** | When enabled, both the IPv6 extensions and TCP port number are used for traffic distribution. | [optional] 
**TcpIpv6Hash** | **Boolean** | When enabled, both the IPv6 address and TCP port number are used for traffic distribution. | [optional] 
**UdpIpv4Hash** | **Boolean** | When enabled, both the IPv4 address and UDP port number are used for traffic distribution. | [optional] 
**UdpIpv6Hash** | **Boolean** | When enabled, both the IPv6 address and UDP port number are used for traffic distribution. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicRssHashSettingsAllOf  -Ipv4Hash null `
 -Ipv6ExtHash null `
 -Ipv6Hash null `
 -TcpIpv4Hash null `
 -TcpIpv6ExtHash null `
 -TcpIpv6Hash null `
 -UdpIpv4Hash null `
 -UdpIpv6Hash null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

