# HyperflexNodeProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HxdpDataIp** | **String** | IP address for storage data network (Controller VM interface). | [optional] 
**HxdpMgmtIp** | **String** | IP address for HyperFlex management network. | [optional] 
**HypervisorDataIp** | **String** | IP address for storage data network (Hypervisor interface). | [optional] 
**HypervisorMgmtIp** | **String** | IP address for Hypervisor management network. | [optional] 
**AssignedServer** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**ClusterProfile** | [**HyperflexClusterProfileRelationship**](HyperflexClusterProfileRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexNodeProfileAllOf  -HxdpDataIp null `
 -HxdpMgmtIp null `
 -HypervisorDataIp null `
 -HypervisorMgmtIp null `
 -AssignedServer null `
 -ClusterProfile null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

