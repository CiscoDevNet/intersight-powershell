# HyperflexHxapVirtualMachineAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.HxapVirtualMachine"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.HxapVirtualMachine"]
**AffinitySelectors** | [**InfraMetaData[]**](InfraMetaData.md) |  | [optional] 
**Age** | **String** | Denotes age or life time of the VM in nano seconds. | [optional] 
**AntiAffinitySelectors** | [**InfraMetaData[]**](InfraMetaData.md) |  | [optional] 
**Disks** | [**HyperflexVmDisk[]**](HyperflexVmDisk.md) |  | [optional] 
**FailureReason** | **String** | Reason of the failure when VM is in failed state. | [optional] 
**GraphicConsoleUrl** | **String** | Graphical console URL of this VM. | [optional] 
**Interfaces** | [**HyperflexVmInterface[]**](HyperflexVmInterface.md) |  | [optional] 
**Labels** | [**InfraMetaData[]**](InfraMetaData.md) |  | [optional] 
**NetworkCount** | **Int64** | Number network interfaces associated with the virtual machine. | [optional] 
**StartTime** | **String** | Denotes the VM start timestamp. | [optional] 
**Status** | **String** | Status of virtual machine. * &#x60;Unknown&#x60; - Virtual machine state is not available. * &#x60;Running&#x60; - Virtual machine is running normally. * &#x60;Stopped&#x60; - Virtual machine has been stopped. * &#x60;WaitForLaunch&#x60; - Virtual machine is wating to be launched. * &#x60;Paused&#x60; - Virtual machine is currently paused. * &#x60;ImportInProgress&#x60; - Virtual machine image is being imported into the platform. * &#x60;ImportFailed&#x60; - Virtual machine image import operation failed. * &#x60;DiskCloneInProgress&#x60; - Disk clone operation for the virtual machine is in progress. * &#x60;DiskCloneFailed&#x60; - Disk clone operation for the virtual machine failed. * &#x60;Processing&#x60; - Virtual machine is being created. * &#x60;UnSchedulable&#x60; - Virtual machine cannot be scheduled to run, either due to insufficient resources or failure to match affinity specifications. * &#x60;Failed&#x60; - Some virtual machine operation has failed. More information is available as part of the results of the operation. | [optional] [default to "Unknown"]
**UpTime** | **String** | Denotes how long this VM has been running in nano seconds. | [optional] 
**Cluster** | [**HyperflexHxapClusterRelationship**](HyperflexHxapClusterRelationship.md) |  | [optional] 
**VarHost** | [**HyperflexHxapHostRelationship**](HyperflexHxapHostRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexHxapVirtualMachineAllOf = Initialize-IntersightHyperflexHxapVirtualMachineAllOf  -ClassId null `
 -ObjectType null `
 -AffinitySelectors null `
 -Age null `
 -AntiAffinitySelectors null `
 -Disks null `
 -FailureReason null `
 -GraphicConsoleUrl null `
 -Interfaces null `
 -Labels null `
 -NetworkCount null `
 -StartTime null `
 -Status null `
 -UpTime null `
 -Cluster null `
 -VarHost null
```

- Convert the resource to JSON
```powershell
$HyperflexHxapVirtualMachineAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

