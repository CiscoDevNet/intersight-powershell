# VnicEthQosPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.EthQosPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.EthQosPolicy"]
**Cos** | **Int64** | Class of Service to be associated to the traffic on the virtual interface. | [optional] [default to 0]
**Mtu** | **Int64** | The Maximum Transmission Unit (MTU) or packet size that the virtual interface accepts. | [optional] [default to 1500]
**Priority** | **String** | The priortity matching the System QoS specified in the fabric profile. * &#x60;Best Effort&#x60; - QoS Priority for Best-effort traffic. * &#x60;FC&#x60; - QoS Priority for FC traffic. * &#x60;Platinum&#x60; - QoS Priority for Platinum traffic. * &#x60;Gold&#x60; - QoS Priority for Gold traffic. * &#x60;Silver&#x60; - QoS Priority for Silver traffic. * &#x60;Bronze&#x60; - QoS Priority for Bronze traffic. | [optional] [default to "Best Effort"]
**RateLimit** | **Int64** | The value in Mbps (0-10G/40G/100G depending on Adapter Model) to use for limiting the data rate on the virtual interface. Setting this to zero will turn rate limiting off. | [optional] [default to 0]
**TrustHostCos** | **Boolean** | Enables usage of the Class of Service provided by the operating system. | [optional] [default to $false]
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$VnicEthQosPolicyAllOf = Initialize-IntersightVnicEthQosPolicyAllOf  -ClassId null `
 -ObjectType null `
 -Cos null `
 -Mtu null `
 -Priority null `
 -RateLimit null `
 -TrustHostCos null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$VnicEthQosPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

