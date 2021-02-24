# HyperflexClusterBackupPolicyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ClusterBackupPolicy"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ClusterBackupPolicy"]
**BackupDataStoreName** | **String** | Backup datastore name prefix used during the auto creation of the datastore. All VMs created in this datastore will be automatically backed up. | [optional] [default to "backup-source-ds"]
**BackupDataStoreSize** | **Int64** | Replication data store size in backupDataStoreSizeUnit. | [optional] [default to 2]
**BackupDataStoreSizeUnit** | **String** | Replication data store size. | [optional] [default to "TB"]
**ReplicationPairNamePrefix** | **String** | Replication cluster pairing name prefix. | [optional] [default to "backup"]
**ReplicationSchedule** | [**HyperflexReplicationSchedule**](HyperflexReplicationSchedule.md) |  | [optional] 
**SnapshotRetentionCount** | **Int64** | Number of snapshots that will be retained as part of the Multi Point in Time support. | [optional] [default to 4]
**BackupTarget** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 
**ClusterProfiles** | [**HyperflexClusterProfileRelationship[]**](HyperflexClusterProfileRelationship.md) | An array of relationships to hyperflexClusterProfile resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexClusterBackupPolicyAllOf = Initialize-IntersightHyperflexClusterBackupPolicyAllOf  -ClassId null `
 -ObjectType null `
 -BackupDataStoreName null `
 -BackupDataStoreSize null `
 -BackupDataStoreSizeUnit null `
 -ReplicationPairNamePrefix null `
 -ReplicationSchedule null `
 -SnapshotRetentionCount null `
 -BackupTarget null `
 -ClusterProfiles null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$HyperflexClusterBackupPolicyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

