# StoragePureVolumeSnapshotAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.PureVolumeSnapshot"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.PureVolumeSnapshot"]
**Serial** | **String** | Unique serial number of the snapshot allocated by the storage array. | [optional] [readonly] 
**Array** | [**StoragePureArrayRelationship**](StoragePureArrayRelationship.md) |  | [optional] 
**ProtectionGroupSnapshot** | [**StoragePureProtectionGroupSnapshotRelationship**](StoragePureProtectionGroupSnapshotRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Volume** | [**StoragePureVolumeRelationship**](StoragePureVolumeRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StoragePureVolumeSnapshotAllOf = Initialize-IntersightStoragePureVolumeSnapshotAllOf  -ClassId null `
 -ObjectType null `
 -Serial null `
 -Array null `
 -ProtectionGroupSnapshot null `
 -RegisteredDevice null `
 -Volume null
```

- Convert the resource to JSON
```powershell
$StoragePureVolumeSnapshotAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

