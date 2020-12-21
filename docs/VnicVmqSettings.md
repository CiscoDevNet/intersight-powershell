# VnicVmqSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.VmqSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.VmqSettings"]
**Enabled** | **Boolean** | Enables VMQ feature on the virtual interface. | [optional] [default to $false]
**MultiQueueSupport** | **Boolean** | Enables Virtual Machine Multi-Queue feature on the virtual interface. VMMQ allows configuration of multiple I/O queues for a single VM and thus distributes traffic across multiple CPU cores in a VM. | [optional] [default to $false]
**NumInterrupts** | **Int64** | The number of interrupt resources to be allocated. Recommended value is the number of CPU threads or logical processors available in the server. | [optional] [default to 16]
**NumSubVnics** | **Int64** | The number of sub vNICs to be created. | [optional] [default to 64]
**NumVmqs** | **Int64** | The number of hardware Virtual Machine Queues to be allocated. The number of VMQs per adapter must be one more than the maximum number of VM NICs. | [optional] [default to 4]
**VmmqAdapterPolicy** | **String** | Ethernet Adapter policy to be associated with the Sub vNICs. The Transmit Queue and Receive Queue resource value of VMMQ adapter policy should be greater than or equal to the configured number of sub vNICs. | [optional] 

## Examples

- Prepare the resource
```powershell
$VnicVmqSettings = Initialize-IntersightVnicVmqSettings  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -MultiQueueSupport null `
 -NumInterrupts null `
 -NumSubVnics null `
 -NumVmqs null `
 -VmmqAdapterPolicy null
```

- Convert the resource to JSON
```powershell
$VnicVmqSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

