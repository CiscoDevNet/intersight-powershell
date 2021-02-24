# HyperflexClusterReplicationNetworkPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ClusterReplicationNetworkPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ClusterReplicationNetworkPolicy"]
**ReplicationBandwidthMbps** | **Int64** | Bandwidth for the Replication network in Mbps. | [optional] [default to 0]
**ReplicationIpranges** | [**HyperflexIpAddrRange[]**](HyperflexIpAddrRange.md) |  | [optional] 
**ReplicationMtu** | **Int64** | MTU for the Replication network. | [optional] [default to 1500]
**ReplicationVlan** | [**HyperflexNamedVlan**](HyperflexNamedVlan.md) |  | [optional] 
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 
**IpPoolMoReference** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexClusterReplicationNetworkPolicyAllOf = Initialize-IntersightHyperflexClusterReplicationNetworkPolicyAllOf  -ClassId null `
 -ObjectType null `
 -ReplicationBandwidthMbps null `
 -ReplicationIpranges null `
 -ReplicationMtu null `
 -ReplicationVlan null `
 -ClusterProfiles null `
 -IpPoolMoReference null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$HyperflexClusterReplicationNetworkPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

