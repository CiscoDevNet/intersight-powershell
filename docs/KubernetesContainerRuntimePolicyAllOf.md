# KubernetesContainerRuntimePolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.ContainerRuntimePolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.ContainerRuntimePolicy"]
**DockerBridgeNetworkCidr** | **String** | The DNS Search Domain Name. | [optional] 
**DockerHttpProxy** | [**KubernetesProxyConfig**](KubernetesProxyConfig.md) |  | [optional] 
**DockerHttpsProxy** | [**KubernetesProxyConfig**](KubernetesProxyConfig.md) |  | [optional] 
**DockerNoProxy** | **String[]** |  | [optional] 
**ClusterProfiles** | [**KubernetesClusterProfileRelationship[]**](KubernetesClusterProfileRelationship.md) | An array of relationships to kubernetesClusterProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesContainerRuntimePolicyAllOf = Initialize-IntersightKubernetesContainerRuntimePolicyAllOf  -ClassId null `
 -ObjectType null `
 -DockerBridgeNetworkCidr null `
 -DockerHttpProxy null `
 -DockerHttpsProxy null `
 -DockerNoProxy null `
 -ClusterProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$KubernetesContainerRuntimePolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

