# NetworkconfigPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "networkconfig.Policy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "networkconfig.Policy"]
**AlternateIpv4dnsServer** | **String** | IP address of the secondary DNS server. | [optional] 
**AlternateIpv6dnsServer** | **String** | IP address of the secondary DNS server. | [optional] 
**DynamicDnsDomain** | **String** | The domain name appended to a hostname for a Dynamic DNS (DDNS) update. If left blank, only a hostname is sent to the DDNS update request. | [optional] 
**EnableDynamicDns** | **Boolean** | If enabled, updates the resource records to the DNS from Cisco IMC. | [optional] 
**EnableIpv4dnsFromDhcp** | **Boolean** | If enabled, Cisco IMC retrieves the DNS server addresses from DHCP. Use DHCP field must be enabled for IPv4 in Cisco IMC to enable it. | [optional] 
**EnableIpv6** | **Boolean** | If enabled, allows to configure IPv6 properties. | [optional] 
**EnableIpv6dnsFromDhcp** | **Boolean** | If enabled, Cisco IMC retrieves the DNS server addresses from DHCP. Use DHCP field must be enabled for IPv6 in Cisco IMC to enable it. | [optional] 
**PreferredIpv4dnsServer** | **String** | IP address of the primary DNS server. | [optional] 
**PreferredIpv6dnsServer** | **String** | IP address of the primary DNS server. | [optional] 
**ApplianceAccount** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Profiles** | [**PolicyAbstractConfigProfileRelationship[]**](PolicyAbstractConfigProfileRelationship.md) | An array of relationships to policyAbstractConfigProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$NetworkconfigPolicyAllOf = Initialize-IntersightNetworkconfigPolicyAllOf  -ClassId null `
 -ObjectType null `
 -AlternateIpv4dnsServer null `
 -AlternateIpv6dnsServer null `
 -DynamicDnsDomain null `
 -EnableDynamicDns null `
 -EnableIpv4dnsFromDhcp null `
 -EnableIpv6 null `
 -EnableIpv6dnsFromDhcp null `
 -PreferredIpv4dnsServer null `
 -PreferredIpv6dnsServer null `
 -ApplianceAccount null `
 -Organization null `
 -Profiles null
```

- Convert the resource to JSON
```powershell
$NetworkconfigPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

