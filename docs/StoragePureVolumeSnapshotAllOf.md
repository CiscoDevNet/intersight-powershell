# StoragePureVolumeSnapshotAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Serial** | **String** | Unique serial number of the snapshot allocated by the storage array. | [optional] [readonly] 
**Array** | [**StoragePureArrayRelationship**](StoragePureArrayRelationship.md) |  | [optional] 
**ProtectionGroupSnapshot** | [**StoragePureProtectionGroupSnapshotRelationship**](StoragePureProtectionGroupSnapshotRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Volume** | [**StoragePureVolumeRelationship**](StoragePureVolumeRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStoragePureVolumeSnapshotAllOf  -Serial null `
 -Array null `
 -ProtectionGroupSnapshot null `
 -RegisteredDevice null `
 -Volume null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

