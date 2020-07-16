# StorageBaseSnapshotAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedTime** | **System.DateTime** | Exact date and time at which snapshot was created. | [optional] [readonly] 
**Name** | **String** | Name of the snapshot which represents point-in-time copy of volume. | [optional] [readonly] 
**ProtectionGroupName** | **String** | Name of the protection group to which the snapshot belongs. Value is empty, if the snapshot is created directly on volume. | [optional] [readonly] 
**Size** | **Int64** | Snapshot size represented in bytes. | [optional] [readonly] 
**Source** | **String** | Source object on which the snapshot is created. It is the name of the originating volume. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageBaseSnapshotAllOf  -CreatedTime null `
 -Name null `
 -ProtectionGroupName null `
 -Size null `
 -Source null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

