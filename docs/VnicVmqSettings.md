# VnicVmqSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Enabled** | **Boolean** | Enables VMQ feature on the virtual interface. | [optional] 
**MultiQueueSupport** | **Boolean** | Enables Virtual Machine Multi-Queue feature on the virtual interface. VMMQ allows configuration of multiple I/O queues for a single VM and, thus, distributes traffic across multiple CPU cores in a VM. | [optional] 
**NumInterrupts** | **Int64** | The number of interrupt resources to be allocated. Recommended value is the number of CPU threads or logical processors available in the server. | [optional] 
**NumSubVnics** | **Int64** | The number of sub vnics to be created. | [optional] 
**NumVmqs** | **Int64** | The number of hardware Virtual Machine Queues to be allocated. The number of VMQs per adapter must be one more than the maximum number of VM NICs. | [optional] 
**VmmqAdapterPolicy** | **String** | Ethernet Adapter policy to be associated with the subVnics. The Transmit Queue and Receive Queue resource value of VMMQ adapter policy should be greater than or equal to the configured number of sub vnics. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVnicVmqSettings  -ClassId null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

