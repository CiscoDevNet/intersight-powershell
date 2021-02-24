# KubernetesNetworkPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.NetworkPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.NetworkPolicy"]
**CniConfig** | [**KubernetesCniConfig**](KubernetesCniConfig.md) |  | [optional] 
**CniType** | **String** | Supported CNI type. Currently we only support Calico. * &#x60;Calico&#x60; - Calico CNI plugin as described in https://github.com/projectcalico/cni-plugin. * &#x60;Aci&#x60; - Cisco ACI Container Network Interface plugin. | [optional] [default to "Calico"]
**PodNetworkCidr** | **String** | CIDR block to allocate pod network IP addresses from. | [optional] 
**ServiceCidr** | **String** | CIDR block to allocate cluster service IP addresses from. | [optional] 
**ClusterProfiles** | [**KubernetesClusterProfileRelationship[]**](KubernetesClusterProfileRelationship.md) | An array of relationships to kubernetesClusterProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesNetworkPolicyAllOf = Initialize-IntersightKubernetesNetworkPolicyAllOf  -ClassId null `
 -ObjectType null `
 -CniConfig null `
 -CniType null `
 -PodNetworkCidr null `
 -ServiceCidr null `
 -ClusterProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$KubernetesNetworkPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

