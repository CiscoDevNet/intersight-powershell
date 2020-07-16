# VirtualizationBaseClusterAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HypervisorType** | **String** | Identifies the broad type of the underlying hypervisor. | [optional] [default to "Unknown"]
**Identity** | **String** | The internally generated identity of this cluster. This entity is not manipulated by users. It aids in uniquely identifying the cluster object. In case of VMware, this is a MOR (managed object reference). | [optional] [readonly] 
**MemoryCapacity** | [**VirtualizationMemoryCapacity**](VirtualizationMemoryCapacity.md) |  | [optional] 
**Name** | **String** | The user-provided name for this cluster to facilitate identification. | [optional] [readonly] 
**ProcessorCapacity** | [**VirtualizationComputeCapacity**](VirtualizationComputeCapacity.md) |  | [optional] 
**Status** | **String** | Cluster health status as reported by the hypervisor platform. | [optional] [readonly] [default to "Unknown"]
**TotalCores** | **Int64** | Total number of CPU cores in this cluster. It is a cumulative number across all hosts in the cluster. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightVirtualizationBaseClusterAllOf  -HypervisorType null `
 -Identity null `
 -MemoryCapacity null `
 -Name null `
 -ProcessorCapacity null `
 -Status null `
 -TotalCores null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

