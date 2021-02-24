# VirtualizationVirtualMachineAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "virtualization.VirtualMachine"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "virtualization.VirtualMachine"]
**Action** | **String** | Action to be performed on a virtual machine (Create, PowerState, Migrate, Clone etc). * &#x60;None&#x60; - A place holder for the default value. * &#x60;PowerState&#x60; - Power action is performed on the virtual machine. * &#x60;Migrate&#x60; - The virtual machine will be migrated from existing node to a different node in cluster. The behavior depends on the underlying hypervisor. * &#x60;Create&#x60; - The virtual machine will be created on the specified hypervisor. This action is also useful if the virtual machine creation failed during first POST operation on VirtualMachine managed object. User can set this action to retry the virtual machine creation. * &#x60;Delete&#x60; - The virtual machine will be deleted from the specified hypervisor. User can either set this action or can do a DELETE operation on the VirtualMachine managed object. | [optional] [default to "None"]
**ActionInfo** | [**VirtualizationActionInfo**](VirtualizationActionInfo.md) |  | [optional] 
**AffinitySelectors** | [**InfraMetaData[]**](InfraMetaData.md) |  | [optional] 
**AntiAffinitySelectors** | [**InfraMetaData[]**](InfraMetaData.md) |  | [optional] 
**CloudInitConfig** | [**VirtualizationCloudInitConfig**](VirtualizationCloudInitConfig.md) |  | [optional] 
**ClusterEsxi** | **String** | Cluster where virtual machine is deployed. | [optional] 
**Cpu** | **Int64** | Number of vCPUs allocated to virtual machine. | [optional] 
**Discovered** | **Boolean** | Flag to indicate whether the configuration is created from inventory object. | [optional] [readonly] 
**Disk** | [**VirtualizationVirtualMachineDisk[]**](VirtualizationVirtualMachineDisk.md) |  | [optional] 
**GuestOs** | **String** | Guest operating system running on virtual machine. * &#x60;linux&#x60; - A Linux operating system. * &#x60;windows&#x60; - A Windows operating system. | [optional] [default to "linux"]
**HostEsxi** | **String** | Host where virtual machine is deployed. | [optional] 
**HypervisorType** | **String** | Identifies the broad product type of the hypervisor but without any version information. It is here to easily identify the type of the virtual machine. There are other entities (Host, Cluster, etc.) that can be indirectly used to determine the hypervisor but a direct attribute makes it easier to work with. * &#x60;ESXi&#x60; - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version. * &#x60;HyperFlexAp&#x60; - The hypervisor running on the HyperFlex cluster is Cisco HyperFlex Application Platform. * &#x60;Hyper-V&#x60; - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V. * &#x60;Unknown&#x60; - The hypervisor running on the HyperFlex cluster is not known. | [optional] [readonly] [default to "ESXi"]
**Interfaces** | [**VirtualizationNetworkInterface[]**](VirtualizationNetworkInterface.md) |  | [optional] 
**Labels** | [**InfraMetaData[]**](InfraMetaData.md) |  | [optional] 
**Memory** | **Int64** | Virtual machine memory defined in mega bytes. | [optional] 
**Name** | **String** | Virtual machine name contains only letters, numbers, allowed special character and must be unique. | [optional] 
**PowerState** | **String** | Expected power state of virtual machine (PowerOn, PowerOff, Restart). * &#x60;PowerOff&#x60; - The virtual machine will be powered off if it is already not in powered off state. If it is already powered off, no side-effects are expected. * &#x60;PowerOn&#x60; - The virtual machine will be powered on if it is already not in powered on state. If it is already powered on, no side-effects are expected. * &#x60;Suspend&#x60; - The virtual machine will be put into  a suspended state. * &#x60;ShutDownGuestOS&#x60; - The guest operating system is shut down gracefully. * &#x60;RestartGuestOS&#x60; - It can either act as a reset switch and abruptly reset the guest operating system, or it can send a restart signal to the guest operating system so that it shuts down gracefully and restarts. * &#x60;Reset&#x60; - Resets the virtual machine abruptly, with no consideration for work in progress. * &#x60;Restart&#x60; - The virtual machine will be restarted only if it is in powered on state. If it is powered off, it will not be started up. * &#x60;Unknown&#x60; - Power state of the entity is unknown. | [optional] [default to "PowerOff"]
**ProvisionType** | **String** | Identifies the provision type to create a new virtual machine. * &#x60;OVA&#x60; - Deploy virtual machine using OVA/F file. * &#x60;Template&#x60; - Provision virtual machine using a template file. | [optional] [default to "OVA"]
**VmConfig** | [**VirtualizationBaseVmConfiguration**](VirtualizationBaseVmConfiguration.md) |  | [optional] 
**Var0VirtualMachineNodeProfile** | [**KubernetesVirtualMachineNodeProfileRelationship**](KubernetesVirtualMachineNodeProfileRelationship.md) |  | [optional] 
**Cluster** | [**VirtualizationBaseClusterRelationship**](VirtualizationBaseClusterRelationship.md) |  | [optional] 
**VarHost** | [**VirtualizationBaseHostRelationship**](VirtualizationBaseHostRelationship.md) |  | [optional] 
**Inventory** | [**VirtualizationBaseVirtualMachineRelationship**](VirtualizationBaseVirtualMachineRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**WorkflowInfo** | [**WorkflowWorkflowInfoRelationship**](WorkflowWorkflowInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$VirtualizationVirtualMachineAllOf = Initialize-IntersightVirtualizationVirtualMachineAllOf  -ClassId null `
 -ObjectType null `
 -Action null `
 -ActionInfo null `
 -AffinitySelectors null `
 -AntiAffinitySelectors null `
 -CloudInitConfig null `
 -ClusterEsxi null `
 -Cpu null `
 -Discovered null `
 -Disk null `
 -GuestOs null `
 -HostEsxi null `
 -HypervisorType null `
 -Interfaces null `
 -Labels null `
 -Memory null `
 -Name null `
 -PowerState null `
 -ProvisionType null `
 -VmConfig null `
 -Var0VirtualMachineNodeProfile null `
 -Cluster null `
 -VarHost null `
 -Inventory null `
 -RegisteredDevice null `
 -WorkflowInfo null
```

- Convert the resource to JSON
```powershell
$VirtualizationVirtualMachineAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

