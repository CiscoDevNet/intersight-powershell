# HyperflexClusterBackupPolicyDeployment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ClusterBackupPolicyDeployment"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ClusterBackupPolicyDeployment"]
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
**BackupDataStoreName** | **String** | Backup data store name used during the auto creation of the datastore. All VMs created in this data store will be automatically backed up. | [optional] [readonly] [default to "backup-source-ds"]
**BackupDataStoreSize** | **Int64** | Replication data store size in backupDataStoreSizeUnit. | [optional] [readonly] [default to 2]
**BackupDataStoreSizeUnit** | **String** | Replication data store size. | [optional] [readonly] [default to "TB"]
**Description** | **String** | Description from corresponding ClusterBackupPolicy. | [optional] [readonly] 
**Discovered** | **Boolean** | True if record created by discovery on HyperFlex cluster. | [optional] 
**Name** | **String** | Name from corresponding ClusterBackupPolicy. | [optional] [readonly] 
**PolicyMoid** | **String** | Deployed cluster policy moid. | [optional] [readonly] 
**ProfileMoid** | **String** | Deployed cluster profile moid. | [optional] [readonly] 
**ReplicationPairNamePrefix** | **String** | Replication cluster pairing name prefix. | [optional] [readonly] [default to "backup"]
**ReplicationSchedule** | [**HyperflexReplicationSchedule**](HyperflexReplicationSchedule.md) |  | [optional] 
**SnapshotRetentionCount** | **Int64** | Number of snapshots that will be retained as part of the Multi Point in Time support. | [optional] [readonly] [default to 4]
**SourceDetached** | **Boolean** | True if policy was detached from source Hyperflex Cluster. | [optional] 
**SourceRequestId** | **String** | Unique source cluster request ID allowing retry of the same logical request following a transient communication failure. | [optional] [readonly] 
**SourceUuid** | **String** | Uuid of the source Hyperflex Cluster. | [optional] [readonly] 
**TargetDetached** | **Boolean** | True if policy was detached from target Hyperflex Cluster. | [optional] 
**TargetRequestId** | **String** | Unique target cluster request ID allowing retry of the same logical request following a transient communication failure. | [optional] [readonly] 
**TargetUuid** | **String** | Uuid of the target Hyperflex Cluster. | [optional] [readonly] 
**BackupTarget** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**SourceCluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexClusterBackupPolicyDeployment = Initialize-IntersightHyperflexClusterBackupPolicyDeployment  -ClassId null `
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
 -BackupDataStoreName null `
 -BackupDataStoreSize null `
 -BackupDataStoreSizeUnit null `
 -Description null `
 -Discovered null `
 -Name null `
 -PolicyMoid null `
 -ProfileMoid null `
 -ReplicationPairNamePrefix null `
 -ReplicationSchedule null `
 -SnapshotRetentionCount null `
 -SourceDetached null `
 -SourceRequestId null `
 -SourceUuid null `
 -TargetDetached null `
 -TargetRequestId null `
 -TargetUuid null `
 -BackupTarget null `
 -Organization null `
 -SourceCluster null
```

- Convert the resource to JSON
```powershell
$HyperflexClusterBackupPolicyDeployment | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

