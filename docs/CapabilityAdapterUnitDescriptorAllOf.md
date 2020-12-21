# CapabilityAdapterUnitDescriptorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.AdapterUnitDescriptor"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.AdapterUnitDescriptor"]
**ConnectivityOrder** | **String** | Order in which the ports are connected; sequential or cyclic. | [optional] 
**EthernetPortSpeed** | **Int64** | The port speed for ethernet ports in Mbps. | [optional] 
**FibreChannelPortSpeed** | **Int64** | The port speed for fibre channel ports in Mbps. | [optional] 
**NumDcePorts** | **Int64** | Number of Dce Ports for the adaptor. | [optional] 
**PromCardType** | **String** | Prom card type for the adaptor. | [optional] 

## Examples

- Prepare the resource
```powershell
$CapabilityAdapterUnitDescriptorAllOf = Initialize-IntersightCapabilityAdapterUnitDescriptorAllOf  -ClassId null `
 -ObjectType null `
 -ConnectivityOrder null `
 -EthernetPortSpeed null `
 -FibreChannelPortSpeed null `
 -NumDcePorts null `
 -PromCardType null
```

- Convert the resource to JSON
```powershell
$CapabilityAdapterUnitDescriptorAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

