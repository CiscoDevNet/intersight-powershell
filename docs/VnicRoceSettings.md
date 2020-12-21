# VnicRoceSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "vnic.RoceSettings"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "vnic.RoceSettings"]
**ClassOfService** | **Int32** | The Class of Service for RoCE on this virtual interface. * &#x60;5&#x60; - RDMA CoS Service Level 5. * &#x60;1&#x60; - RDMA CoS Service Level 1. * &#x60;2&#x60; - RDMA CoS Service Level 2. * &#x60;4&#x60; - RDMA CoS Service Level 4. * &#x60;6&#x60; - RDMA CoS Service Level 6. | [optional] [default to 5]
**Enabled** | **Boolean** | If enabled sets RDMA over Converged Ethernet (RoCE) on this virtual interface. | [optional] 
**MemoryRegions** | **Int64** | The number of memory regions per adapter. Recommended value &#x3D; integer power of 2. | [optional] [default to 131072]
**QueuePairs** | **Int64** | The number of queue pairs per adapter. Recommended value &#x3D; integer power of 2. | [optional] [default to 256]
**ResourceGroups** | **Int64** | The number of resource groups per adapter. Recommended value &#x3D; be an integer power of 2 greater than or equal to the number of CPU cores on the system for optimum performance. | [optional] [default to 4]
**Version** | **Int32** | Configure RDMA over Converged Ethernet (RoCE) version on the virtual interface. Only RoCEv1 is supported on Cisco VIC 13xx series adapters and only RoCEv2 is supported on Cisco VIC 14xx series adapters. * &#x60;1&#x60; - RDMA over Converged Ethernet Protocol Version 1. * &#x60;2&#x60; - RDMA over Converged Ethernet Protocol Version 2. | [optional] [default to 1]

## Examples

- Prepare the resource
```powershell
$VnicRoceSettings = Initialize-IntersightVnicRoceSettings  -ClassId null `
 -ObjectType null `
 -ClassOfService null `
 -Enabled null `
 -MemoryRegions null `
 -QueuePairs null `
 -ResourceGroups null `
 -Version null
```

- Convert the resource to JSON
```powershell
$VnicRoceSettings | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

