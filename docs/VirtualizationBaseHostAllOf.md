# VirtualizationBaseHostAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CpuInfo** | [**VirtualizationCpuInfo**](VirtualizationCpuInfo.md) |  | [optional] 
**HardwareInfo** | [**InfraHardwareInfo**](InfraHardwareInfo.md) |  | [optional] 
**HypervisorType** | **String** | Identifies the broad type of the underlying hypervisor. | [optional] [default to "Unknown"]
**Identity** | **String** | The internally generated identity of this host. This entity is not manipulated by users. It aids in uniquely identifying the datacenter object. For VMware, this is an MOR (managed object reference). | [optional] 
**MaintenanceMode** | **Boolean** | Is this host in maintenance mode. Set to true or false. | [optional] 
**MemoryCapacity** | [**VirtualizationMemoryCapacity**](VirtualizationMemoryCapacity.md) |  | [optional] 
**Model** | **String** | Commercial model information about this hardware. | [optional] 
**Name** | **String** | Name of this host supplied by user. It is not the identity of the host. The name is subject to user manipulations. | [optional] 
**ProcessorCapacity** | [**VirtualizationComputeCapacity**](VirtualizationComputeCapacity.md) |  | [optional] 
**ProductInfo** | [**VirtualizationProductInfo**](VirtualizationProductInfo.md) |  | [optional] 
**Serial** | **String** | Serial number of this host (internally generated). | [optional] 
**Status** | **String** | Host health status, as reported by the hypervisor platform. | [optional] [default to "Unknown"]
**UpTime** | **String** | The uptime of the host, stored as Duration (from w3c). | [optional] 
**Uuid** | **String** | Universally unique identity of this host (example b3d4483b-5560-9342-8309-b486c9236610). Internally generated. | [optional] 
**Vendor** | **String** | Commercial vendor details of this hardware. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationBaseHostAllOf  -CpuInfo null `
 -HardwareInfo null `
 -HypervisorType null `
 -Identity null `
 -MaintenanceMode null `
 -MemoryCapacity null `
 -Model null `
 -Name null `
 -ProcessorCapacity null `
 -ProductInfo null `
 -Serial null `
 -Status null `
 -UpTime null `
 -Uuid null `
 -Vendor null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

