# HyperflexClusterProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
Initialize-IntersightHyperflexClusterProfileAllOf  -DataIpAddress null `
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

