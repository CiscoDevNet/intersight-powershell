# StoragePureSnapshotScheduleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DailyLimit** | **Int64** | Total number of snapshots per day to be available on source above and over the specified retention time. PureStorage FlashArray maintains all created snapshot until retention period. Daily limit is applied only on the snapshots once retention time is expired. In case of, daily limit is less than the number of snapshot available on source, system select snapshots evenly spaced out throughout the day. | [optional] [readonly] 
**SnapshotExpiryTime** | **String** | Duration to keep the daily limit snapshots on source array. StorageArray deletes the snapshots permanently from source beyond this period. | [optional] [readonly] 
**Array** | [**StoragePureArrayRelationship**](StoragePureArrayRelationship.md) |  | [optional] 
**ProtectionGroup** | [**StoragePureProtectionGroupRelationship**](StoragePureProtectionGroupRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStoragePureSnapshotScheduleAllOf  -DailyLimit null `
 -SnapshotExpiryTime null `
 -Array null `
 -ProtectionGroup null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

