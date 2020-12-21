# VirtualizationVmwareVirtualMachineAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.VmwareVirtualMachine"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.VmwareVirtualMachine"]
**Annotation** | **String** | List of annotations provided to this VM by user. Can be long. | [optional] 
**BootTime** | **System.DateTime** | Time when this VM booted up. | [optional] 
**ConfigName** | **String** | The configuration name for this VM. This maybe the same as the guest hostname. | [optional] 
**ConnectionState** | **String** | Shows if virtual machine is connected to vCenter. Values are Connected, Disconnected, Orphaned, Inaccessible, and Invalid. | [optional] 
**CpuHotAddEnabled** | **Boolean** | Indicates if the capability to add CPUs to a running VM is enabled. | [optional] 
**CpuShares** | [**VirtualizationVmwareVmCpuShareInfo**](VirtualizationVmwareVmCpuShareInfo.md) |  | [optional] 
**CpuSocketInfo** | [**VirtualizationVmwareVmCpuSocketInfo**](VirtualizationVmwareVmCpuSocketInfo.md) |  | [optional] 
**CustomAttributes** | **String[]** |  | [optional] 
**DefaultPowerOffType** | **String** | Indicates how the VM will be powered off (soft, hard etc.). | [optional] 
**DhcpEnabled** | **Boolean** | Shows if DHCP is used for IP/DNS on this VM. | [optional] 
**DiskCommitInfo** | [**VirtualizationVmwareVmDiskCommitInfo**](VirtualizationVmwareVmDiskCommitInfo.md) |  | [optional] 
**DnsServerList** | **String[]** |  | [optional] 
**DnsSuffixList** | **String[]** |  | [optional] 
**Folder** | **String** | The folder name associated with this VM. | [optional] 
**GuestState** | **String** | The state of the guest OS running on this VM. Could be running, not running etc. * &#x60;Unknown&#x60; - Indicates that the guest OS state cannot be determined. * &#x60;NotRunning&#x60; - Indicates that the guest OS is not running. * &#x60;Resetting&#x60; - Indicates that the guest OS is resetting. * &#x60;Running&#x60; - Indicates that the guest OS is running normally. * &#x60;ShuttingDown&#x60; - Indicates that the guest OS is shutting down. * &#x60;Standby&#x60; - Indicates that the guest OS is in standby mode. | [optional] [default to "Unknown"]
**InstanceUuid** | **String** | UUID assigned by vCenter to every VM. | [optional] 
**InventoryPath** | **String** | Inventory path to the VM. Example - /DC/vm/folder/VMName. | [optional] 
**IsTemplate** | **Boolean** | If true, indicates that the entity refers to a template of a virtual machine and not a real virtual machine. | [optional] 
**MacAddress** | **String[]** |  | [optional] 
**MemShares** | [**VirtualizationVmwareVmMemoryShareInfo**](VirtualizationVmwareVmMemoryShareInfo.md) |  | [optional] 
**MemoryHotAddEnabled** | **Boolean** | Adding memory to a running VM. | [optional] 
**NetworkCount** | **Int64** | Indicates how many networks are used by this VM. | [optional] 
**PortGroups** | **String[]** |  | [optional] 
**ProtectedVm** | **Boolean** | Shows if this is a protected VM. VMs can be in protection groups. | [optional] 
**RemoteDisplayInfo** | [**VirtualizationVmwareRemoteDisplayInfo**](VirtualizationVmwareRemoteDisplayInfo.md) |  | [optional] 
**RemoteDisplayVncEnabled** | **Boolean** | Shows if support for a remote VNC access is enabled. | [optional] 
**ResourcePool** | **String** | Name of the resource pool to which this VM belongs (optional). | [optional] 
**ResourcePoolOwner** | **String** | Who owns the resource pool. | [optional] 
**ResourcePoolParent** | **String** | The parent of the current resource pool to which this VM belongs. | [optional] 
**ToolRunningStatus** | **String** | Indicates if guest tools are running on this VM. Could be set to guestToolNotRunning or guestToolsRunning. | [optional] 
**ToolsVersion** | **String** | The version of the guest tools, usually not specified. | [optional] 
**VmDiskCount** | **Int64** | Shows the number of disks assigned to this VM. | [optional] 
**VmOverallStatus** | **String** | The operational state of the VM. Could be Available, Provisioned, Maintenance mode, Deleting, etc. | [optional] 
**VmPath** | **String** | Example - [datastore3] VCSA-134/VCSA-134.vmx. | [optional] 
**VmVersion** | **String** | Information about the version of this VM (vmx-09, vmx-11 etc.). | [optional] 
**VmVnicCount** | **Int64** | How many vnics are present. | [optional] 
**VnicDeviceConfigId** | **String** | Information related to the guest info&#39;s VNIC virtual device. It is a comma-separated list. | [optional] 
**Cluster** | [**VirtualizationVmwareClusterRelationship**](VirtualizationVmwareClusterRelationship.md) |  | [optional] 
**Datacenter** | [**VirtualizationVmwareDatacenterRelationship**](VirtualizationVmwareDatacenterRelationship.md) |  | [optional] 
**Datastores** | [**VirtualizationVmwareDatastoreRelationship[]**](VirtualizationVmwareDatastoreRelationship.md) | An array of relationships to virtualizationVmwareDatastore resources. | [optional] [readonly] 
**VarHost** | [**VirtualizationVmwareHostRelationship**](VirtualizationVmwareHostRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationVmwareVirtualMachineAllOf = Initialize-IntersightVirtualizationVmwareVirtualMachineAllOf  -ClassId null `
 -ObjectType null `
 -Annotation null `
 -BootTime null `
 -ConfigName null `
 -ConnectionState null `
 -CpuHotAddEnabled null `
 -CpuShares null `
 -CpuSocketInfo null `
 -CustomAttributes null `
 -DefaultPowerOffType null `
 -DhcpEnabled null `
 -DiskCommitInfo null `
 -DnsServerList null `
 -DnsSuffixList null `
 -Folder null `
 -GuestState null `
 -InstanceUuid null `
 -InventoryPath null `
 -IsTemplate null `
 -MacAddress null `
 -MemShares null `
 -MemoryHotAddEnabled null `
 -NetworkCount null `
 -PortGroups null `
 -ProtectedVm null `
 -RemoteDisplayInfo null `
 -RemoteDisplayVncEnabled null `
 -ResourcePool null `
 -ResourcePoolOwner null `
 -ResourcePoolParent null `
 -ToolRunningStatus null `
 -ToolsVersion null `
 -VmDiskCount null `
 -VmOverallStatus null `
 -VmPath null `
 -VmVersion null `
 -VmVnicCount null `
 -VnicDeviceConfigId null `
 -Cluster null `
 -Datacenter null `
 -Datastores null `
 -VarHost null
```

- Convert the resource to JSON
```powershell
$VirtualizationVmwareVirtualMachineAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

