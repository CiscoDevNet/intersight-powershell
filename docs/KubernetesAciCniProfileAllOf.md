# KubernetesAciCniProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.AciCniProfile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.AciCniProfile"]
**AaepName** | **String** | Name of ACI AAEP (Attachable Access Entity Profile) to be used for all Kubernetes clusters using this policy. | [optional] 
**ExtSvcDynSubnetStart** | **String** | Start of range of IP subnets for external services with dynamic IP allocation for use by Kubernetes clusters using this ACI CNI policy. | [optional] 
**ExtSvcStaticSubnetStart** | **String** | Start of range of IP subnets for external services with static IP allocation for use by Kubernetes clusters using this ACI CNI policy. | [optional] 
**InfraVlanId** | **Int64** | Value of ACI infrastructuere VLAN ID for the ACI fabric. | [optional] [readonly] 
**L3OutNetworkName** | **String** | Name of ACI L3Out network to be used for all Kubernetes clusters using this policy. | [optional] 
**L3OutPolicyName** | **String** | Name of ACI L3Out policy to be used for all Kubernetes clusters using this policy. | [optional] 
**L3OutTenant** | **String** | Tenant in ACI used by this L3Out and Common VRF. | [optional] 
**NestedVmmDomain** | **String** | VMM domain within which Kubernetes clusters using this policy are nested. | [optional] 
**NodeSvcSubnetStart** | **String** | Start of range of ACI Node Service IP subnets to use by Kubernetes clusters using this ACI CNI policy This is used for the service graph which is used for ACI PBR based load balancing. | [optional] 
**NodeVlanRangeEnd** | **Int64** | Ending value of VLAN range used to assign Node VLAN Ids for each Kubernetes cluster using this policy. | [optional] 
**NodeVlanRangeStart** | **Int64** | Starting value of VLAN range used to assign Node VLAN Ids for each Kubernetes cluster using this policy. | [optional] 
**NumberOfKubernetesClusters** | **Int64** | Number of k8s clusters currently using this ACI CNI profile. | [optional] [readonly] 
**OpflexMulticastAddressRange** | **String** | Range of IP Multicast addresses to be used by the Opflex protocol for Kubernetes clusters using this policy. | [optional] 
**PodSubnetStart** | **String** | Start of range of Kubernetes pod IP subnets to use by Kubernetes clusters using this ACI CNI policy This should be a /8 IP subnet so that multiple /16 subnets can be assigned for pod subnets of Kubernetes clusters using this profile. | [optional] 
**SvcSubnetStart** | **String** | Start of range of Kubernetes Service IP subnets to use by Kubernetes clusters using this ACI CNI policy Currently this is fixed internally and read-only. | [optional] [readonly] 
**Vrf** | **String** | VRF (Virtual Routing and Forwarding) domain to be used within ACI fabric by all k8s clusters using this policy. | [optional] 
**ClusterAciAllocations** | [**KubernetesAciCniTenantClusterAllocationRelationship[]**](KubernetesAciCniTenantClusterAllocationRelationship.md) | An array of relationships to kubernetesAciCniTenantClusterAllocation resources. | [optional] [readonly] 
**ClusterProfiles** | [**KubernetesClusterProfileRelationship[]**](KubernetesClusterProfileRelationship.md) | An array of relationships to kubernetesClusterProfile resources. | [optional] [readonly] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesAciCniProfileAllOf = Initialize-IntersightKubernetesAciCniProfileAllOf  -ClassId null `
 -ObjectType null `
 -AaepName null `
 -ExtSvcDynSubnetStart null `
 -ExtSvcStaticSubnetStart null `
 -InfraVlanId null `
 -L3OutNetworkName null `
 -L3OutPolicyName null `
 -L3OutTenant null `
 -NestedVmmDomain null `
 -NodeSvcSubnetStart null `
 -NodeVlanRangeEnd null `
 -NodeVlanRangeStart null `
 -NumberOfKubernetesClusters null `
 -OpflexMulticastAddressRange null `
 -PodSubnetStart null `
 -SvcSubnetStart null `
 -Vrf null `
 -ClusterAciAllocations null `
 -ClusterProfiles null `
 -Organization null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$KubernetesAciCniProfileAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

