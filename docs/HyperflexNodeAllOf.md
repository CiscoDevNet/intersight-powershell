# HyperflexNodeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.Node"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.Node"]
**BuildNumber** | **String** | The build number of the hypervisor running on the host. | [optional] [readonly] 
**DisplayVersion** | **String** | The user-friendly string representation of the hypervisor version of the host. | [optional] [readonly] 
**HostName** | **String** | The hostname configured for the hypervisor running on the host. | [optional] [readonly] 
**Hypervisor** | **String** | The type of hypervisor running on the host. | [optional] [readonly] 
**Identity** | [**HyperflexHxUuIdDt**](HyperflexHxUuIdDt.md) |  | [optional] 
**Ip** | [**HyperflexHxNetworkAddressDt**](HyperflexHxNetworkAddressDt.md) |  | [optional] 
**Lockdown** | **Boolean** | The admin state of lockdown mode on the host. If &#39;true&#39;, lockdown mode is enabled. | [optional] [readonly] 
**ModelNumber** | **String** | The model of the host server. | [optional] [readonly] 
**Role** | **String** | The role of the host in the HyperFlex cluster. Specifies whether this host is used for compute or for both compute and storage. * &#x60;UNKNOWN&#x60; - The role of the HyperFlex cluster node is not known. * &#x60;STORAGE&#x60; - The HyperFlex cluster node provides both storage and compute resources for the cluster. * &#x60;COMPUTE&#x60; - The HyperFlex cluster node provides compute resources for the cluster. | [optional] [readonly] [default to "UNKNOWN"]
**SerialNumber** | **String** | The serial of the host server. | [optional] [readonly] 
**Status** | **String** | The status of the host. Indicates whether the hypervisor is online. * &#x60;UNKNOWN&#x60; - The host status cannot be determined. * &#x60;ONLINE&#x60; - The host is online and operational. * &#x60;OFFLINE&#x60; - The host is offline and is currently not participating in the HyperFlex cluster. * &#x60;INMAINTENANCE&#x60; - The host is not participating in the HyperFlex cluster because of a maintenance operation, such as firmware or data platform upgrade. * &#x60;DEGRADED&#x60; - The host is degraded and may not be performing in its full operational capacity. | [optional] [readonly] [default to "UNKNOWN"]
**Version** | **String** | The version of the hypervisor running on the host. | [optional] [readonly] 
**Cluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 
**ClusterMember** | [**AssetClusterMemberRelationship**](AssetClusterMemberRelationship.md) |  | [optional] 
**PhysicalServer** | [**ComputePhysicalRelationship**](ComputePhysicalRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexNodeAllOf = Initialize-IntersightHyperflexNodeAllOf  -ClassId null `
 -ObjectType null `
 -BuildNumber null `
 -DisplayVersion null `
 -HostName null `
 -Hypervisor null `
 -Identity null `
 -Ip null `
 -Lockdown null `
 -ModelNumber null `
 -Role null `
 -SerialNumber null `
 -Status null `
 -Version null `
 -Cluster null `
 -ClusterMember null `
 -PhysicalServer null
```

- Convert the resource to JSON
```powershell
$HyperflexNodeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

