# HyperflexVmBackupInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.VmBackupInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.VmBackupInfo"]
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
**BackupStatus** | **String** | Description of the backup status of this VmBackupInfo. * &#x60;InitializingProtection&#x60; - Protection has started, but not completed. * &#x60;Protected&#x60; - Protection has completed successfully. * &#x60;ExceedsInterval&#x60; - Protection has not completed successfully in over two times the backup interval. | [optional] [readonly] [default to "InitializingProtection"]
**ClusterEntityReference** | [**HyperflexEntityReference**](HyperflexEntityReference.md) |  | [optional] 
**ClusterIdProtectionInfoMap** | [**HyperflexMapClusterIdToProtectionInfo[]**](HyperflexMapClusterIdToProtectionInfo.md) |  | [optional] 
**VarError** | [**HyperflexErrorStack**](HyperflexErrorStack.md) |  | [optional] 
**ProtectionStatus** | **String** | Description of the protection status of this VmBackupInfo. * &#x60;PREPARE_FAILOVER_STARTED&#x60; - The protection status is prepare failover started. * &#x60;PREPARE_FAILOVER_FAILED&#x60; - The protection status is prepare failover failed. * &#x60;PREPARE_FAILOVER_COMPLETED&#x60; - The protection status is prepaire failover completed. * &#x60;FAILOVER_STARTED&#x60; - The protection status is failover started. * &#x60;FAILOVER_FAILED&#x60; - The protection status is failover failed. * &#x60;FAILOVER_COMPLETED&#x60; - The protection status is failover completed. * &#x60;PREPARE_REVERSEPROTECT_STARTED&#x60; - The protection status is prepare reverse protect started. * &#x60;PREPARE_REVERSEPROTECT_FAILED&#x60; - The protection status is prepare reverse protect failed. * &#x60;PREPARE_REVERSEPROTECT_COMPLETED&#x60; - The protection status is prepair reverse protect completed. * &#x60;REVERSEPROTECT_STARTED&#x60; - The protection status is reverse protect started. * &#x60;REVERSEPROTECT_FAILED&#x60; - The protection status is reverse protect failed. * &#x60;ACTIVE&#x60; - The protection status is active. * &#x60;CREATION_IN_PROGRESS&#x60; - The protection status is failover in progress. * &#x60;CREATION_FAILED&#x60; - The protection status is creation failed. * &#x60;LOCAL_RESTORE_STARTED&#x60; - The protection status is local restore started. * &#x60;LOCAL_RESTORE_FAILED&#x60; - The protection status is local restore failed. | [optional] [readonly] [default to "PREPARE_FAILOVER_STARTED"]
**Schedule** | [**HyperflexReplicationClusterReferenceToSchedule[]**](HyperflexReplicationClusterReferenceToSchedule.md) |  | [optional] 
**VmEntityReference** | [**HyperflexEntityReference**](HyperflexEntityReference.md) |  | [optional] 
**VmInfo** | [**HyperflexVirtualMachine**](HyperflexVirtualMachine.md) |  | [optional] 
**SrcBackupCluster** | [**HyperflexBackupClusterRelationship**](HyperflexBackupClusterRelationship.md) |  | [optional] 
**SrcCluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 
**TgtCluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexVmBackupInfo = Initialize-IntersightHyperflexVmBackupInfo  -ClassId null `
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
 -BackupStatus null `
 -ClusterEntityReference null `
 -ClusterIdProtectionInfoMap null `
 -VarError null `
 -ProtectionStatus null `
 -Schedule null `
 -VmEntityReference null `
 -VmInfo null `
 -SrcBackupCluster null `
 -SrcCluster null `
 -TgtCluster null
```

- Convert the resource to JSON
```powershell
$HyperflexVmBackupInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

