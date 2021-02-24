# VirtualizationVmwareVirtualMachine
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.VmwareVirtualMachine"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.VmwareVirtualMachine"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Var0ClusterReplicationNetworkPolicy** | [**HyperflexClusterReplicationNetworkPolicyRelationship**](HyperflexClusterReplicationNetworkPolicyRelationship.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Capacity** | [**InfraHardwareInfo**](InfraHardwareInfo.md) |  | [optional] 
**GuestInfo** | [**VirtualizationGuestInfo**](VirtualizationGuestInfo.md) |  | [optional] 
**HypervisorType** | **String** | Type of hypervisor where the virtual machine is hosted for example ESXi. * &#x60;ESXi&#x60; - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version. * &#x60;HyperFlexAp&#x60; - The hypervisor running on the HyperFlex cluster is Cisco HyperFlex Application Platform. * &#x60;Hyper-V&#x60; - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V. * &#x60;Unknown&#x60; - The hypervisor running on the HyperFlex cluster is not known. | [optional] [default to "ESXi"]
**Identity** | **String** | The internally generated identity of this VM. This entity is not manipulated by users. It aids in uniquely identifying the virtual machine object. For VMware, this is MOR (managed object reference). | [optional] 
**IpAddress** | **String[]** |  | [optional] 
**MemoryCapacity** | [**VirtualizationMemoryCapacity**](VirtualizationMemoryCapacity.md) |  | [optional] 
**Name** | **String** | User-provided name to identify the virtual machine. | [optional] 
**PowerState** | **String** | Power state of the virtual machine. * &#x60;Unknown&#x60; - The entity&#39;s power state is unknown. * &#x60;PoweredOn&#x60; - The entity is powered on. * &#x60;PoweredOff&#x60; - The entity is powered down. * &#x60;StandBy&#x60; - The entity is in standby mode. * &#x60;Paused&#x60; - The entity is in pause state. | [optional] [default to "Unknown"]
**ProcessorCapacity** | [**VirtualizationComputeCapacity**](VirtualizationComputeCapacity.md) |  | [optional] 
**Uuid** | **String** | The uuid of this virtual machine. The uuid is internally generated and not user specified. | [optional] 
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
$VirtualizationVmwareVirtualMachine = Initialize-IntersightVirtualizationVmwareVirtualMachine  -ClassId null `
 -ObjectType null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Var0ClusterReplicationNetworkPolicy null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -RegisteredDevice null `
 -Capacity null `
 -GuestInfo null `
 -HypervisorType null `
 -Identity null `
 -IpAddress null `
 -MemoryCapacity null `
 -Name null `
 -PowerState null `
 -ProcessorCapacity null `
 -Uuid null `
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
$VirtualizationVmwareVirtualMachine | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

