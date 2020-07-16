# HyperflexNodeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BuildNumber** | **String** |  | [optional] [readonly] 
**DisplayVersion** | **String** |  | [optional] [readonly] 
**HostName** | **String** |  | [optional] [readonly] 
**Hypervisor** | **String** |  | [optional] [readonly] 
**Identity** | [**HyperflexHxUuIdDt**](HyperflexHxUuIdDt.md) |  | [optional] 
**Ip** | [**HyperflexHxNetworkAddressDt**](HyperflexHxNetworkAddressDt.md) |  | [optional] 
**Lockdown** | **Boolean** |  | [optional] [readonly] 
**ModelNumber** | **String** |  | [optional] [readonly] 
**Role** | **String** |  | [optional] [readonly] [default to "UNKNOWN"]
**SerialNumber** | **String** |  | [optional] [readonly] 
**Status** | **String** |  | [optional] [readonly] [default to "UNKNOWN"]
**Version** | **String** |  | [optional] [readonly] 
**Cluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 
**ClusterMember** | [**AssetClusterMemberRelationship**](AssetClusterMemberRelationship.md) |  | [optional] 
**PhysicalServer** | [**ComputePhysicalRelationship**](ComputePhysicalRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexNodeAllOf  -BuildNumber null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

