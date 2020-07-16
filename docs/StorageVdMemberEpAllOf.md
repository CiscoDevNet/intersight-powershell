# StorageVdMemberEpAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OperQualifierReason** | **String** | For certain states, indicates the reason why the operState is in that state. | [optional] [readonly] 
**Presence** | **String** | The presence state of the local disk. | [optional] [readonly] 
**Role** | **String** | Role of the disk normal or hot-spare, used by virtual-drive. | [optional] [readonly] 
**SpanId** | **String** | The span id number of the virtual drive. | [optional] [readonly] 
**VdMemberEpId** | **Int64** | The local disk slot number as id. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StorageVirtualDrive** | [**StorageVirtualDriveRelationship**](StorageVirtualDriveRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageVdMemberEpAllOf  -OperQualifierReason null `
 -Presence null `
 -Role null `
 -SpanId null `
 -VdMemberEpId null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -StorageVirtualDrive null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

