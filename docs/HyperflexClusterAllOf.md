# HyperflexClusterAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CapacityRunway** | **Int64** | The number of days remaining before the cluster&#39;s storage utilization reaches the recommended capacity limit of 76%. Default value is math.MaxInt32 to indicate that the capacity runway is &quot;&quot;Unknown&quot;&quot; for a cluster that is not connected or with not sufficient data. | [optional] [readonly] 
**ClusterName** | **String** | The name of this HyperFlex cluster. | [optional] [readonly] 
**ClusterType** | **Int64** | The storage type of this cluster (All Flash or Hybrid). | [optional] [readonly] 
**ClusterUuid** | **String** | The unique identifier for this HyperFlex cluster. | [optional] [readonly] 
**ComputeNodeCount** | **Int64** | The number of compute nodes that belong to this cluster. | [optional] [readonly] 
**ConvergedNodeCount** | **Int64** | The number of converged nodes that belong to this cluster. | [optional] [readonly] 
**DeploymentType** | **String** | The deployment type of the HyperFlex cluster. The cluster can have one of the following configurations: 1. Datacenter: The HyperFlex cluster consists of UCS Fabric Interconnect-attached nodes on a single site. 2. Stretched Cluster: The HyperFlex cluster consists of UCS Fabric Interconnect-attached nodes distributed across multiple sites. 3. Edge: The HyperFlex cluster consists of 2-4 standalone nodes. If the cluster is running a HyperFlex Data Platform version less than 4.0 or if the deployment type cannot be determined, the deployment type is set as &#39;NA&#39; (not available). | [optional] [readonly] [default to "NA"]
**DeviceId** | **String** | The unique identifier of the device registration that represents this HyperFlex cluster&#39;s connection to Intersight. | [optional] [readonly] 
**FltAggr** | **Int64** | The number of yellow (warning) and red (critical) alarms stored as an aggregate. The first 16 bits indicate the number of red alarms, and the last 16 bits contain the number of yellow alarms. | [optional] [readonly] 
**HxVersion** | **String** | The HyperFlex Data Platform version of this cluster. | [optional] [readonly] 
**HxdpBuildVersion** | **String** | The version and build number of the HyperFlex Data Platform for this cluster. After a cluster upgrade, this version string will be updated on the next inventory cycle to reflect the newly installed version. | [optional] [readonly] 
**HypervisorType** | **String** | The type of hypervisor running on this cluster. | [optional] [readonly] [default to "ESXi"]
**HypervisorVersion** | **String** | The version of hypervisor running on this cluster. | [optional] [readonly] 
**Summary** | [**HyperflexSummary**](HyperflexSummary.md) |  | [optional] 
**UtilizationPercentage** | **Double** | The storage utilization percentage is computed based on total capacity and current capacity utilization. | [optional] [readonly] 
**UtilizationTrendPercentage** | **Double** | The storage utilization trend percentage represents the trend in percentage computed using the first and last point from historical data. | [optional] [readonly] 
**VmCount** | **Int64** | The number of virtual machines present on this cluster. | [optional] [readonly] 
**Alarm** | [**HyperflexAlarmRelationship[]**](HyperflexAlarmRelationship.md) | An array of relationships to hyperflexAlarm resources. | [optional] [readonly] 
**Health** | [**HyperflexHealthRelationship**](HyperflexHealthRelationship.md) |  | [optional] 
**Nodes** | [**HyperflexNodeRelationship[]**](HyperflexNodeRelationship.md) | An array of relationships to hyperflexNode resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexClusterAllOf  -CapacityRunway null `
 -ClusterName null `
 -ClusterType null `
 -ClusterUuid null `
 -ComputeNodeCount null `
 -ConvergedNodeCount null `
 -DeploymentType null `
 -DeviceId null `
 -FltAggr null `
 -HxVersion null `
 -HxdpBuildVersion null `
 -HypervisorType null `
 -HypervisorVersion null `
 -Summary null `
 -UtilizationPercentage null `
 -UtilizationTrendPercentage null `
 -VmCount null `
 -Alarm null `
 -Health null `
 -Nodes null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

