# VirtualizationBaseVirtualMachineAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capacity** | [**InfraHardwareInfo**](InfraHardwareInfo.md) |  | [optional] 
**GuestInfo** | [**VirtualizationGuestInfo**](VirtualizationGuestInfo.md) |  | [optional] 
**HypervisorType** | **String** | Type of hypervisor where the virtual machine is hosted for example ESXi. | [optional] [default to "Unknown"]
**Identity** | **String** | The internally generated identity of this VM. This entity is not manipulated by users. It aids in uniquely identifying the virtual machine object. For VMware, this is MOR (managed object reference). | [optional] 
**IpAddress** | **String[]** |  | [optional] 
**MemoryCapacity** | [**VirtualizationMemoryCapacity**](VirtualizationMemoryCapacity.md) |  | [optional] 
**Name** | **String** | User-provided name to identify the virtual machine. | [optional] 
**PowerState** | **String** | Power state of the virtual machine. | [optional] [default to "Unknown"]
**ProcessorCapacity** | [**VirtualizationComputeCapacity**](VirtualizationComputeCapacity.md) |  | [optional] 
**Uuid** | **String** | The uuid of this virtual machine. The uuid is internally generated and not user specified. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationBaseVirtualMachineAllOf  -Capacity null `
 -GuestInfo null `
 -HypervisorType null `
 -Identity null `
 -IpAddress null `
 -MemoryCapacity null `
 -Name null `
 -PowerState null `
 -ProcessorCapacity null `
 -Uuid null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

