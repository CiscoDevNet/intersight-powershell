# StorageBaseProtectionGroupSnapshotAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedTime** | **System.DateTime** | Protection group snapshot creation time. | [optional] [readonly] 
**Name** | **String** | Protection group snapshot name which represents point-in-time copy of all members in protection group. | [optional] [readonly] 
**Size** | **Int64** | Snapshot size represented in bytes. It is a cumulative size of all snapshots in a set. | [optional] [readonly] 
**Source** | **String** | Source protection group name on which the snapshot is created. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageBaseProtectionGroupSnapshotAllOf  -CreatedTime null `
 -Name null `
 -Size null `
 -Source null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

