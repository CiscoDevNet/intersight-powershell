# ComputeIpAddress
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "compute.IpAddress"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "compute.IpAddress"]
**Address** | **String** | IP Address to be used for KVM. | [optional] [readonly] 
**Category** | **String** | Category of the Kvm IP Address. * &#x60;Equipment&#x60; - Ip Address assigned to an equipment. * &#x60;ServiceProfile&#x60; - Ip Address assigned to a Service Profile. | [optional] [readonly] [default to "Equipment"]
**DefaultGateway** | **String** | Default gateway property of KVM IP Address. | [optional] [readonly] 
**Dn** | **String** | The distinguished name for this managed object. | [optional] [readonly] 
**HttpPort** | **Int64** | HTTP port of an IP Address. | [optional] [readonly] [default to 80]
**HttpsPort** | **Int64** | Secured HTTP port of an IP Address. | [optional] [readonly] [default to 443]
**KvmPort** | **Int64** | Port number on which the KVM is running and used for connecting to KVM console. | [optional] [readonly] [default to 2068]
**KvmVlan** | **Int64** | VLAN Identifier of Inband IP Address. | [optional] [readonly] 
**Name** | **String** | Name to identify the KVM IP Address. * &#x60;Outband&#x60; - The user assigned Out of band IP Address. * &#x60;Inband&#x60; - The user assigned Inband IP Address. | [optional] [readonly] [default to "Outband"]
**Subnet** | **String** | Subnet detail of a KVM IP Address. | [optional] [readonly] 
**Type** | **String** | Type of the KVM IP Address. * &#x60;MgmtInterface&#x60; - Ip Address of a Management Interface. * &#x60;VnicIpV4StaticAddr&#x60; - Static Ipv4 Address of a Virtual Network Interface. * &#x60;VnicIpV4PooledAddr&#x60; - Ipv4 Address of a Virtual Network Interface from an address pool. * &#x60;VnicIpV4MgmtPooledAddr&#x60; - Ipv4 Address of a Virtual Network Interface from a Managed address pool. * &#x60;VnicIpV6StaticAddr&#x60; - Static Ipv6 Address of a Virtual Network Interface. * &#x60;VnicIpV6MgmtPooledAddr&#x60; - Ipv6 Address of a Virtual Network Interface from a Managed address pool. * &#x60;VnicIpV4ProfDerivedAddr&#x60; - Server Profile derived Ipv4 Address of a Virtual Network Interface. * &#x60;MgmtIpV6ProfDerivedAddr&#x60; - Server Profile derived Ipv6 Address used for accessing server management services. | [optional] [readonly] [default to "MgmtInterface"]

## Examples

- Prepare the resource
```powershell
$ComputeIpAddress = Initialize-IntersightComputeIpAddress  -ClassId null `
 -ObjectType null `
 -Address null `
 -Category null `
 -DefaultGateway null `
 -Dn null `
 -HttpPort null `
 -HttpsPort null `
 -KvmPort null `
 -KvmVlan null `
 -Name null `
 -Subnet null `
 -Type null
```

- Convert the resource to JSON
```powershell
$ComputeIpAddress | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

