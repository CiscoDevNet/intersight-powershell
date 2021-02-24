# KubernetesAciCniProfileRelationship
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.AciCniProfile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.AciCniProfile"]
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Selector** | **String** | An OData $filter expression which describes the REST resource to be referenced. This field may be set instead of &#39;moid&#39; by clients. 1. If &#39;moid&#39; is set this field is ignored. 1. If &#39;selector&#39; is set and &#39;moid&#39; is empty/absent from the request, Intersight determines the Moid of the resource matching the filter expression and populates it in the MoRef that is part of the object instance being inserted/updated to fulfill the REST request. An error is returned if the filter matches zero or more than one REST resource. An example filter string is: Serial eq &#39;3AA8B7T11&#39;. | [optional] [readonly] 
**Link** | **String** | A URL to an instance of the &#39;mo.MoRef&#39; class. | [optional] 
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Var0ClusterReplicationNetworkPolicy** | [**HyperflexClusterReplicationNetworkPolicyRelationship**](HyperflexClusterReplicationNetworkPolicyRelationship.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**Description** | **String** | Description of the profile. | [optional] 
**Name** | **String** | Name of the concrete profile. | [optional] 
**Type** | **String** | Defines the type of the profile. Accepted value is instance. * &#x60;instance&#x60; - The profile defines the configuration for a specific instance of a target. | [optional] [default to "instance"]
**SrcTemplate** | [**PolicyAbstractProfileRelationship**](PolicyAbstractProfileRelationship.md) |  | [optional] 
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
$KubernetesAciCniProfileRelationship = Initialize-IntersightKubernetesAciCniProfileRelationship  -ClassId null `
 -ObjectType null `
 -Moid null `
 -Selector null `
 -Link null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Var0ClusterReplicationNetworkPolicy null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -Description null `
 -Name null `
 -Type null `
 -SrcTemplate null `
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
$KubernetesAciCniProfileRelationship | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

