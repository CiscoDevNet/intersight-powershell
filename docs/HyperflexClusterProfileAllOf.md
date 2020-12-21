# HyperflexClusterProfileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ClusterProfile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ClusterProfile"]
**DataIpAddress** | **String** | The storage data IP address for the HyperFlex cluster. | [optional] 
**HostNamePrefix** | **String** | The node name prefix that is used to automatically generate the default hostname for each server. A dash (-) will be appended to the prefix followed by the node number to form a hostname. This default naming scheme can be manually overridden in the node configuration. The maximum length of a prefix is 60, must only contain alphanumeric characters or dash (-), and must start with an alphanumeric character. | [optional] 
**HypervisorControlIpAddress** | **String** | The hypervisor control virtual IP address for the HyperFlex compute cluster that is used for node/pod management. | [optional] 
**HypervisorType** | **String** | The hypervisor type for the HyperFlex cluster. * &#x60;ESXi&#x60; - The hypervisor running on the HyperFlex cluster is a Vmware ESXi hypervisor of any version. * &#x60;HyperFlexAp&#x60; - The hypervisor running on the HyperFlex cluster is Cisco HyperFlex Application Platform. * &#x60;Hyper-V&#x60; - The hypervisor running on the HyperFlex cluster is Microsoft Hyper-V. * &#x60;Unknown&#x60; - The hypervisor running on the HyperFlex cluster is not known. | [optional] [default to "ESXi"]
**MacAddressPrefix** | **String** | The MAC address prefix in the form of 00:25:B5:XX. | [optional] 
**MgmtIpAddress** | **String** | The management IP address for the HyperFlex cluster. | [optional] 
**MgmtPlatform** | **String** | The management platform for the HyperFlex cluster. * &#x60;FI&#x60; - The host servers used in the cluster deployment are managed by a UCS Fabric Interconnect. * &#x60;EDGE&#x60; - The host servers used in the cluster deployment are standalone severs. | [optional] [default to "FI"]
**Replication** | **Int64** | The number of copies of each data block written. | [optional] 
**StorageDataVlan** | [**HyperflexNamedVlan**](HyperflexNamedVlan.md) |  | [optional] 
**StorageType** | **String** | The storage type used for the HyperFlex cluster (HyperFlex Storage or 3rd party). * &#x60;HyperFlexDp&#x60; - The type of storage is HyperFlex Data Platform. * &#x60;ThirdParty&#x60; - The type of storage is 3rd Party Storage (PureStorage, etc..). | [optional] [default to "HyperFlexDp"]
**WwxnPrefix** | **String** | The WWxN prefix in the form of 20:00:00:25:B5:XX. | [optional] 
**AssociatedCluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 
**AssociatedComputeCluster** | [**HyperflexHxapClusterRelationship**](HyperflexHxapClusterRelationship.md) |  | [optional] 
**AutoSupport** | [**HyperflexAutoSupportPolicyRelationship**](HyperflexAutoSupportPolicyRelationship.md) |  | [optional] 
**ClusterNetwork** | [**HyperflexClusterNetworkPolicyRelationship**](HyperflexClusterNetworkPolicyRelationship.md) |  | [optional] 
**ClusterStorage** | [**HyperflexClusterStoragePolicyRelationship**](HyperflexClusterStoragePolicyRelationship.md) |  | [optional] 
**ConfigResult** | [**HyperflexConfigResultRelationship**](HyperflexConfigResultRelationship.md) |  | [optional] 
**ExtFcStorage** | [**HyperflexExtFcStoragePolicyRelationship**](HyperflexExtFcStoragePolicyRelationship.md) |  | [optional] 
**ExtIscsiStorage** | [**HyperflexExtIscsiStoragePolicyRelationship**](HyperflexExtIscsiStoragePolicyRelationship.md) |  | [optional] 
**Httpproxypolicy** | [**CommHttpProxyPolicyRelationship**](CommHttpProxyPolicyRelationship.md) |  | [optional] 
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
$HyperflexClusterProfileAllOf = Initialize-IntersightHyperflexClusterProfileAllOf  -ClassId null `
 -ObjectType null `
 -DataIpAddress null `
 -HostNamePrefix null `
 -HypervisorControlIpAddress null `
 -HypervisorType null `
 -MacAddressPrefix null `
 -MgmtIpAddress null `
 -MgmtPlatform null `
 -Replication null `
 -StorageDataVlan null `
 -StorageType null `
 -WwxnPrefix null `
 -AssociatedCluster null `
 -AssociatedComputeCluster null `
 -AutoSupport null `
 -ClusterNetwork null `
 -ClusterStorage null `
 -ConfigResult null `
 -ExtFcStorage null `
 -ExtIscsiStorage null `
 -Httpproxypolicy null `
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
$HyperflexClusterProfileAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

