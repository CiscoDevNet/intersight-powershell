# HyperflexVirtualMachineRuntimeInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.VirtualMachineRuntimeInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.VirtualMachineRuntimeInfo"]
**BiosUuid** | **String** | BiosUuid of the Protected Virtual Machine. | [optional] [readonly] 
**ConnectionState** | **String** | Connection state of the VM. | [optional] [readonly] 
**CpuUsage** | **Int64** | CPU Usage of Virtual Machine. | [optional] [readonly] 
**Folder** | **String** | Folder which VM belongs to. | [optional] [readonly] 
**GuestFamily** | **String** | Guest operating system family, if known. | [optional] [readonly] 
**GuestFullName** | **String** | Guest operating system full name, if known. | [optional] [readonly] 
**GuestId** | **String** | Guest operating system identifier (short name), if known. | [optional] [readonly] 
**GuestState** | **String** | VMware guest reset, powercycle, or boot action states. | [optional] [readonly] 
**HostName** | **String** | Hostname of Virtual Machine. | [optional] [readonly] 
**InstanceUuid** | **String** | InstanceUuid of the Protected Virtual Machine. | [optional] [readonly] 
**MemoryMb** | **Int64** | CPU Memory in MB of Virtual Machine. | [optional] [readonly] 
**MemoryUsage** | **Int64** | Memory usage of Virtual Machine. | [optional] [readonly] 
**Moid** | **String** | Virtual Machine unique MOID. | [optional] [readonly] 
**Name** | **String** | Name of the Virtual Machine. | [optional] [readonly] 
**Networks** | **String[]** |  | [optional] 
**NumCpu** | **Int64** | Number of CPUs for the VM. | [optional] [readonly] 
**PowerState** | **String** | Power state of the Virtual Machine. | [optional] [readonly] 
**ProvisionedSize** | **Int64** | Provisioned Size of Virtual Machine. | [optional] [readonly] 
**ResourcePool** | **String** | Resource pool which VM belongs to. | [optional] [readonly] 
**UsedSize** | **Int64** | Used Size of Virtual Machine. | [optional] [readonly] 
**Version** | **String** | Version of the Virtual Machine. | [optional] [readonly] 
**VmxPath** | **String** | Vmx Path in VC datastore format. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexVirtualMachineRuntimeInfo = Initialize-IntersightHyperflexVirtualMachineRuntimeInfo  -ClassId null `
 -ObjectType null `
 -BiosUuid null `
 -ConnectionState null `
 -CpuUsage null `
 -Folder null `
 -GuestFamily null `
 -GuestFullName null `
 -GuestId null `
 -GuestState null `
 -HostName null `
 -InstanceUuid null `
 -MemoryMb null `
 -MemoryUsage null `
 -Moid null `
 -Name null `
 -Networks null `
 -NumCpu null `
 -PowerState null `
 -ProvisionedSize null `
 -ResourcePool null `
 -UsedSize null `
 -Version null `
 -VmxPath null
```

- Convert the resource to JSON
```powershell
$HyperflexVirtualMachineRuntimeInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

