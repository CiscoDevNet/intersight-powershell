# HyperflexClusterProfileRelationship
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
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
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | a map of display names for a resource. | [optional] [readonly] 
**Description** | **String** | Description of the profile. | [optional] 
**Name** | **String** | Name of the concrete profile. | [optional] 
**Type** | **String** | Defines the type of the profile. Accepted value is instance. | [optional] [default to "instance"]
**SrcTemplate** | [**PolicyAbstractProfileRelationship**](PolicyAbstractProfileRelationship.md) |  | [optional] 
**Action** | **String** | User initiated action. Each profile type has its own supported actions. For HyperFlex cluster profile, the supported actions are -- Validate, Deploy, Continue, Retry, Abort, Unassign For server profile, the support actions are -- Deploy, Unassign. | [optional] 
**ConfigContext** | [**PolicyConfigContext**](PolicyConfigContext.md) |  | [optional] 
**DataIpAddress** | **String** | The storage data IP address for the HyperFlex cluster. | [optional] 
**HypervisorType** | **String** | The hypervisor type for the HyperFlex cluster. | [optional] [default to "ESXi"]
**MacAddressPrefix** | **String** | The MAC address prefix in the form of 00:25:B5:XX. | [optional] 
**MgmtIpAddress** | **String** | The management IP address for the HyperFlex cluster. | [optional] 
**MgmtPlatform** | **String** | The management platform for the HyperFlex cluster. | [optional] [default to "FI"]
**Replication** | **Int64** | The number of copies of each data block written. | [optional] 
**StorageDataVlan** | [**HyperflexNamedVlan**](HyperflexNamedVlan.md) |  | [optional] 
**WwxnPrefix** | **String** | The WWxN prefix in the form of 20:00:00:25:B5:XX. | [optional] 
**AssociatedCluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 
**AutoSupport** | [**HyperflexAutoSupportPolicyRelationship**](HyperflexAutoSupportPolicyRelationship.md) |  | [optional] 
**ClusterNetwork** | [**HyperflexClusterNetworkPolicyRelationship**](HyperflexClusterNetworkPolicyRelationship.md) |  | [optional] 
**ClusterStorage** | [**HyperflexClusterStoragePolicyRelationship**](HyperflexClusterStoragePolicyRelationship.md) |  | [optional] 
**ConfigResult** | [**HyperflexConfigResultRelationship**](HyperflexConfigResultRelationship.md) |  | [optional] 
**ExtFcStorage** | [**HyperflexExtFcStoragePolicyRelationship**](HyperflexExtFcStoragePolicyRelationship.md) |  | [optional] 
**ExtIscsiStorage** | [**HyperflexExtIscsiStoragePolicyRelationship**](HyperflexExtIscsiStoragePolicyRelationship.md) |  | [optional] 
**LocalCredential** | [**HyperflexLocalCredentialPolicyRelationship**](HyperflexLocalCredentialPolicyRelationship.md) |  | [optional] 
**NodeConfig** | [**HyperflexNodeConfigPolicyRelationship**](HyperflexNodeConfigPolicyRelationship.md) |  | [optional] 
**NodeProfileConfig** | [**HyperflexNodeProfileRelationship[]**](HyperflexNodeProfileRelationship.md) | An array of relationships to hyperflexNodeProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**ProxySetting** | [**HyperflexProxySettingPolicyRelationship**](HyperflexProxySettingPolicyRelationship.md) |  | [optional] 
**RunningWorkflows** | [**WorkflowWorkflowInfoRelationship[]**](WorkflowWorkflowInfoRelationship.md) | An array of relationships to workflowWorkflowInfo resources. | [optional] [readonly] 
**SoftwareVersion** | [**HyperflexSoftwareVersionPolicyRelationship**](HyperflexSoftwareVersionPolicyRelationship.md) |  | [optional] 
**SysConfig** | [**HyperflexSysConfigPolicyRelationship**](HyperflexSysConfigPolicyRelationship.md) |  | [optional] 
**UcsmConfig** | [**HyperflexUcsmConfigPolicyRelationship**](HyperflexUcsmConfigPolicyRelationship.md) |  | [optional] 
**VcenterConfig** | [**HyperflexVcenterConfigPolicyRelationship**](HyperflexVcenterConfigPolicyRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexClusterProfileRelationship  -ClassId null `
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
 -DataIpAddress null `
 -HypervisorType null `
 -MacAddressPrefix null `
 -MgmtIpAddress null `
 -MgmtPlatform null `
 -Replication null `
 -StorageDataVlan null `
 -WwxnPrefix null `
 -AssociatedCluster null `
 -AutoSupport null `
 -ClusterNetwork null `
 -ClusterStorage null `
 -ConfigResult null `
 -ExtFcStorage null `
 -ExtIscsiStorage null `
 -LocalCredential null `
 -NodeConfig null `
 -NodeProfileConfig null `
 -Organization null `
 -ProxySetting null `
 -RunningWorkflows null `
 -SoftwareVersion null `
 -SysConfig null `
 -UcsmConfig null `
 -VcenterConfig null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

