# HyperflexClusterBackupPolicyDeploymentAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ClusterBackupPolicyDeployment"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ClusterBackupPolicyDeployment"]
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
$HyperflexClusterBackupPolicyDeploymentAllOf = Initialize-IntersightHyperflexClusterBackupPolicyDeploymentAllOf  -ClassId null `
 -ObjectType null `
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
$HyperflexClusterBackupPolicyDeploymentAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

