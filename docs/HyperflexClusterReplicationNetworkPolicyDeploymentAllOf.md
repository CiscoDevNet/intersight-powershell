# HyperflexClusterReplicationNetworkPolicyDeploymentAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ClusterReplicationNetworkPolicyDeployment"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ClusterReplicationNetworkPolicyDeployment"]
**ClusterUuid** | **String** | Uuid of the HyperFlex cluster. | [optional] [readonly] 
**Description** | **String** | Description from corresponding ClusterReplicationNetworkPolicy. | [optional] [readonly] 
**Discovered** | **Boolean** | True if record created by discovery on HyperFlex cluster. | [optional] 
**Name** | **String** | Name from corresponding ClusterReplicationNetworkPolicy. | [optional] [readonly] 
**PolicyMoid** | **String** | Deployed network policy moid. | [optional] [readonly] 
**ProfileMoid** | **String** | Deployed cluster profile moid. | [optional] [readonly] 
**ReplicationBandwidthMbps** | **Int64** | Bandwidth for the Replication network in Mbps. | [optional] [readonly] [default to 0]
**ReplicationIpranges** | [**HyperflexIpAddrRange[]**](HyperflexIpAddrRange.md) |  | [optional] 
**ReplicationMtu** | **Int64** | MTU for the Replication network. | [optional] [readonly] [default to 1500]
**ReplicationVlan** | [**HyperflexNamedVlan**](HyperflexNamedVlan.md) |  | [optional] 
**RequestId** | **String** | Unique request ID allowing retry of the same logical request following a transient communication failure. | [optional] [readonly] 
**Cluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexClusterReplicationNetworkPolicyDeploymentAllOf = Initialize-IntersightHyperflexClusterReplicationNetworkPolicyDeploymentAllOf  -ClassId null `
 -ObjectType null `
 -ClusterUuid null `
 -Description null `
 -Discovered null `
 -Name null `
 -PolicyMoid null `
 -ProfileMoid null `
 -ReplicationBandwidthMbps null `
 -ReplicationIpranges null `
 -ReplicationMtu null `
 -ReplicationVlan null `
 -RequestId null `
 -Cluster null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$HyperflexClusterReplicationNetworkPolicyDeploymentAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

