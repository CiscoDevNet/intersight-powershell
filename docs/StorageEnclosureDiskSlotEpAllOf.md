# StorageEnclosureDiskSlotEpAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DrivePath** | **String** | This field identifies the zoning configuration applied to  this enclosure slot. | [optional] 
**Health** | **String** | This field identifies the health of the disk inserted in the slot. | [optional] 
**Presence** | **String** | This field identifies the disk is present in the enclosure slot. | [optional] 
**Slot** | **String** | This field represents the slot Id in the storage enclosure. | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StorageEnclosure** | [**StorageEnclosureRelationship**](StorageEnclosureRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageEnclosureDiskSlotEpAllOf  -DrivePath null `
 -Health null `
 -Presence null `
 -Slot null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -StorageEnclosure null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

