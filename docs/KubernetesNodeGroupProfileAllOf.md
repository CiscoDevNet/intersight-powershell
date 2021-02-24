# KubernetesNodeGroupProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.NodeGroupProfile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.NodeGroupProfile"]
**Currentsize** | **Int64** | Current number of nodes in this node group at any given point in time. | [optional] 
**Desiredsize** | **Int64** | Desired number of nodes in this node group, same as minsize initially and is updated by the auto-scaler. | [optional] [default to 3]
**Labels** | [**KubernetesNodeGroupLabel[]**](KubernetesNodeGroupLabel.md) |  | [optional] 
**Maxsize** | **Int64** | Maximum number of nodes desired in this node group. | [optional] 
**Minsize** | **Int64** | Minimum number of nodes desired in this node group. | [optional] 
**NodeType** | **String** | The node type Master, Worker or EmbeddedMaster. * &#x60;Worker&#x60; - Node will be marked as a worker node. * &#x60;Master&#x60; - Node will be marked as a master node. * &#x60;EmbeddedMaster&#x60; - Node will be both a master and a worker. | [optional] [default to "Worker"]
**Taints** | [**KubernetesNodeGroupTaint[]**](KubernetesNodeGroupTaint.md) |  | [optional] 
**ClusterProfile** | [**KubernetesClusterProfileRelationship**](KubernetesClusterProfileRelationship.md) |  | [optional] 
**InfraProvider** | [**KubernetesInfrastructureProviderRelationship**](KubernetesInfrastructureProviderRelationship.md) |  | [optional] 
**IpPools** | [**IppoolPoolRelationship[]**](IppoolPoolRelationship.md) | An array of relationships to ippoolPool resources. | [optional] 
**KubernetesVersion** | [**KubernetesVersionPolicyRelationship**](KubernetesVersionPolicyRelationship.md) |  | [optional] 
**Nodes** | [**KubernetesNodeProfileRelationship[]**](KubernetesNodeProfileRelationship.md) | An array of relationships to kubernetesNodeProfile resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesNodeGroupProfileAllOf = Initialize-IntersightKubernetesNodeGroupProfileAllOf  -ClassId null `
 -ObjectType null `
 -Currentsize null `
 -Desiredsize null `
 -Labels null `
 -Maxsize null `
 -Minsize null `
 -NodeType null `
 -Taints null `
 -ClusterProfile null `
 -InfraProvider null `
 -IpPools null `
 -KubernetesVersion null `
 -Nodes null
```

- Convert the resource to JSON
```powershell
$KubernetesNodeGroupProfileAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

