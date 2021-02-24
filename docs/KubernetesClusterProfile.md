# KubernetesClusterProfile
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "kubernetes.ClusterProfile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "kubernetes.ClusterProfile"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
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
**Action** | **String** | User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign. | [optional] 
**ConfigContext** | [**PolicyConfigContext**](PolicyConfigContext.md) |  | [optional] 
**ActionInfo** | [**KubernetesActionInfo**](KubernetesActionInfo.md) |  | [optional] 
**CertConfig** | [**KubernetesClusterCertificateConfiguration**](KubernetesClusterCertificateConfiguration.md) |  | [optional] 
**KubeConfig** | [**KubernetesConfiguration**](KubernetesConfiguration.md) |  | [optional] 
**ManagedMode** | **String** | Management mode for the cluster. In some cases Intersight kubernetes service is not required to provision and manage the management entities and endpoints (for e.g. EKS). In most other cases it will be required to provision and manage these entities and endpoints. * &#x60;Provided&#x60; - Cluster management entities and endpoints are provided by the infrastructure platform. * &#x60;Managed&#x60; - Cluster management entities and endpoints are provisioned and managed by Intersight kubernetes service. | [optional] [default to "Provided"]
**ManagementConfig** | [**KubernetesClusterManagementConfig**](KubernetesClusterManagementConfig.md) |  | [optional] 
**Status** | **String** | Status of the Kubernetes cluster and its nodes. * &#x60;Configuring&#x60; - The cluster is being configured. * &#x60;Deploying&#x60; - The cluster is being deployed. * &#x60;Undeploying&#x60; - The cluster is being undeployed. * &#x60;DeployFailed&#x60; - The cluster deployment failed. * &#x60;Upgrading&#x60; - The cluster is being upgraded. * &#x60;Deleting&#x60; - The cluster is being deleted. * &#x60;DeleteFailed&#x60; - The cluster delete failed. * &#x60;Ready&#x60; - The cluster is ready for use. * &#x60;Active&#x60; - The cluster is being active. * &#x60;Shutdown&#x60; - All the nodes in the cluster are powered off. * &#x60;Terminated&#x60; - The cluster is terminated. * &#x60;Deployed&#x60; - The cluster is deployed. The cluster may not yet be ready for use. * &#x60;UndeployFailed&#x60; - The cluster undeploy action failed. * &#x60;NotReady&#x60; - The cluster is created and some nodes are not ready. | [optional] [default to "Configuring"]
**AciCniProfile** | [**KubernetesAciCniProfileRelationship**](KubernetesAciCniProfileRelationship.md) |  | [optional] 
**Addons** | [**KubernetesAddonPolicyRelationship[]**](KubernetesAddonPolicyRelationship.md) | An array of relationships to kubernetesAddonPolicy resources. | [optional] 
**AssociatedCluster** | [**KubernetesClusterRelationship**](KubernetesClusterRelationship.md) |  | [optional] 
**ClusterIpPools** | [**IppoolPoolRelationship[]**](IppoolPoolRelationship.md) | An array of relationships to ippoolPool resources. | [optional] 
**ContainerRuntimeConfig** | [**KubernetesContainerRuntimePolicyRelationship**](KubernetesContainerRuntimePolicyRelationship.md) |  | [optional] 
**LoadbalancerIpLeases** | [**IppoolIpLeaseRelationship[]**](IppoolIpLeaseRelationship.md) | An array of relationships to ippoolIpLease resources. | [optional] 
**MasterVipLease** | [**IppoolIpLeaseRelationship**](IppoolIpLeaseRelationship.md) |  | [optional] 
**NetConfig** | [**KubernetesNetworkPolicyRelationship**](KubernetesNetworkPolicyRelationship.md) |  | [optional] 
**NodeGroups** | [**KubernetesNodeGroupProfileRelationship[]**](KubernetesNodeGroupProfileRelationship.md) | An array of relationships to kubernetesNodeGroupProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**SysConfig** | [**KubernetesSysConfigPolicyRelationship**](KubernetesSysConfigPolicyRelationship.md) |  | [optional] 
**TrustedRegistries** | [**KubernetesTrustedRegistriesPolicyRelationship**](KubernetesTrustedRegistriesPolicyRelationship.md) |  | [optional] 
**WorkflowInfo** | [**WorkflowWorkflowInfoRelationship**](WorkflowWorkflowInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$KubernetesClusterProfile = Initialize-IntersightKubernetesClusterProfile  -ClassId null `
 -ObjectType null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
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
 -Action null `
 -ConfigContext null `
 -ActionInfo null `
 -CertConfig null `
 -KubeConfig null `
 -ManagedMode null `
 -ManagementConfig null `
 -Status null `
 -AciCniProfile null `
 -Addons null `
 -AssociatedCluster null `
 -ClusterIpPools null `
 -ContainerRuntimeConfig null `
 -LoadbalancerIpLeases null `
 -MasterVipLease null `
 -NetConfig null `
 -NodeGroups null `
 -Organization null `
 -SysConfig null `
 -TrustedRegistries null `
 -WorkflowInfo null
```

- Convert the resource to JSON
```powershell
$KubernetesClusterProfile | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

