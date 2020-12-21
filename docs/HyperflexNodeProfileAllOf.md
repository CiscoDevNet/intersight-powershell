# HyperflexNodeProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.NodeProfile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.NodeProfile"]
**HxdpDataIp** | **String** | IP address for storage data network (Controller VM interface). | [optional] 
**HxdpMgmtIp** | **String** | IP address for HyperFlex management network. | [optional] 
**HypervisorControlIp** | **String** | IP address for hypervisor control such as VM migration or pod management. | [optional] 
**HypervisorDataIp** | **String** | IP address for storage data network (Hypervisor interface). | [optional] 
**HypervisorMgmtIp** | **String** | IP address for Hypervisor management network. | [optional] 
**AssignedServer** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**ClusterProfile** | [**HyperflexClusterProfileRelationship**](HyperflexClusterProfileRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexNodeProfileAllOf = Initialize-IntersightHyperflexNodeProfileAllOf  -ClassId null `
 -ObjectType null `
 -HxdpDataIp null `
 -HxdpMgmtIp null `
 -HypervisorControlIp null `
 -HypervisorDataIp null `
 -HypervisorMgmtIp null `
 -AssignedServer null `
 -ClusterProfile null
```

- Convert the resource to JSON
```powershell
$HyperflexNodeProfileAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

