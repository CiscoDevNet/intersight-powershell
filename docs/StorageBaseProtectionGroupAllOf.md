# StorageBaseProtectionGroupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | Name of the protection Group. | [optional] 
**Prefix** | **String** | Prefix used for all generated snapshots from the protection group. | [optional] 
**ReplicationEnabled** | **Boolean** | Flag to determine if replication is enabled. Snapshots are replicated to the target array if this flag is set. | [optional] 
**SnapshotEnabled** | **Boolean** | Flag to determine if snapshot creation is enabled. Snapshots are created on local array if this flag is set. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageBaseProtectionGroupAllOf  -Name null `
 -Prefix null `
 -ReplicationEnabled null `
 -SnapshotEnabled null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

