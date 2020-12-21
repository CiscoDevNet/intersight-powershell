# VnicRssHashSettingsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.RssHashSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.RssHashSettings"]
**Ipv4Hash** | **Boolean** | When enabled, the IPv4 address is used for traffic distribution. | [optional] [default to $true]
**Ipv6ExtHash** | **Boolean** | When enabled, the IPv6 extensions are used for traffic distribution. | [optional] [default to $false]
**Ipv6Hash** | **Boolean** | When enabled, the IPv6 address is used for traffic distribution. | [optional] [default to $true]
**TcpIpv4Hash** | **Boolean** | When enabled, both the IPv4 address and TCP port number are used for traffic distribution. | [optional] [default to $true]
**TcpIpv6ExtHash** | **Boolean** | When enabled, both the IPv6 extensions and TCP port number are used for traffic distribution. | [optional] [default to $false]
**TcpIpv6Hash** | **Boolean** | When enabled, both the IPv6 address and TCP port number are used for traffic distribution. | [optional] [default to $true]
**UdpIpv4Hash** | **Boolean** | When enabled, both the IPv4 address and UDP port number are used for traffic distribution. | [optional] [default to $false]
**UdpIpv6Hash** | **Boolean** | When enabled, both the IPv6 address and UDP port number are used for traffic distribution. | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$VnicRssHashSettingsAllOf = Initialize-IntersightVnicRssHashSettingsAllOf  -ClassId null `
 -ObjectType null `
 -Ipv4Hash null `
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
$VnicRssHashSettingsAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

