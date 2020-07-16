# CapabilityAdapterUnitDescriptorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConnectivityOrder** | **String** | Order in which the ports are connected; sequential or cyclic. | [optional] 
**EthernetPortSpeed** | **Int64** | The port speed for ethernet ports in Mbps. | [optional] 
**FibreChannelPortSpeed** | **Int64** | The port speed for fibre channel ports in Mbps. | [optional] 
**NumDcePorts** | **Int64** | Number of Dce Ports for the adaptor. | [optional] 
**PromCardType** | **String** | Prom card type for the adaptor. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCapabilityAdapterUnitDescriptorAllOf  -ConnectivityOrder null `
 -EthernetPortSpeed null `
 -FibreChannelPortSpeed null `
 -NumDcePorts null `
 -PromCardType null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

