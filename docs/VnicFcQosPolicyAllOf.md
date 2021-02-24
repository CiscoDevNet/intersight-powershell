# VnicFcQosPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.FcQosPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.FcQosPolicy"]
**Burst** | **Int64** | The burst traffic, in bytes, allowed on the vNIC. | [optional] [default to 1024]
**Cos** | **Int64** | Class of Service to be associated to the traffic on the virtual interface. | [optional] [default to 3]
**MaxDataFieldSize** | **Int64** | The maximum size of the Fibre Channel frame payload bytes that the virtual interface supports. | [optional] [default to 2112]
**Priority** | **String** | The priortity matching the System QoS specified in the fabric profile. * &#x60;Best Effort&#x60; - QoS Priority for Best-effort traffic. * &#x60;FC&#x60; - QoS Priority for FC traffic. * &#x60;Platinum&#x60; - QoS Priority for Platinum traffic. * &#x60;Gold&#x60; - QoS Priority for Gold traffic. * &#x60;Silver&#x60; - QoS Priority for Silver traffic. * &#x60;Bronze&#x60; - QoS Priority for Bronze traffic. | [optional] [readonly] [default to "Best Effort"]
**RateLimit** | **Int64** | The value in Mbps to use for limiting the data rate on the virtual interface. Setting this to zero will turn rate limiting off. | [optional] [default to 0]
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$VnicFcQosPolicyAllOf = Initialize-IntersightVnicFcQosPolicyAllOf  -ClassId null `
 -ObjectType null `
 -Burst null `
 -Cos null `
 -MaxDataFieldSize null `
 -Priority null `
 -RateLimit null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$VnicFcQosPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

