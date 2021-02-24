# HyperflexHxapHostAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.HxapHost"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.HxapHost"]
**Age** | **String** | Denotes age or life time of the Host in nano seconds. | [optional] 
**ClusterUuid** | **String** | The UUID of the cluster to which this Host belongs to. | [optional] 
**FailureReason** | **String** | Reason of the failure when host is in failed state. | [optional] 
**HwPowerState** | **String** | Is the host Powered-up or Powered-down. * &#x60;Unknown&#x60; - The entity&#39;s power state is unknown. * &#x60;PoweredOn&#x60; - The entity is powered on. * &#x60;PoweredOff&#x60; - The entity is powered down. * &#x60;StandBy&#x60; - The entity is in standby mode. * &#x60;Paused&#x60; - The entity is in pause state. | [optional] [default to "Unknown"]
**InternalIpAddress** | **String** | Internal IP Address of the Host. | [optional] 
**ManagementIpAddress** | **String** | Management IP Address of the Host. | [optional] 
**MasterRole** | **Boolean** | Is the role of this host is master in the cluster? true or false. | [optional] 
**Version** | **String** | Product version of the Host. | [optional] 
**Cluster** | [**HyperflexHxapClusterRelationship**](HyperflexHxapClusterRelationship.md) |  | [optional] 
**ClusterMember** | [**AssetClusterMemberRelationship**](AssetClusterMemberRelationship.md) |  | [optional] 
**PhysicalServer** | [**ComputePhysicalRelationship**](ComputePhysicalRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexHxapHostAllOf = Initialize-IntersightHyperflexHxapHostAllOf  -ClassId null `
 -ObjectType null `
 -Age null `
 -ClusterUuid null `
 -FailureReason null `
 -HwPowerState null `
 -InternalIpAddress null `
 -ManagementIpAddress null `
 -MasterRole null `
 -Version null `
 -Cluster null `
 -ClusterMember null `
 -PhysicalServer null
```

- Convert the resource to JSON
```powershell
$HyperflexHxapHostAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

