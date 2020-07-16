# StoragePhysicalDiskExtensionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bootable** | **String** | The whether disk is bootable or not. | [optional] [readonly] 
**DiskDn** | **String** | The distinguished name of the Physical drive. | [optional] [readonly] 
**DiskId** | **Int64** | The storage Enclosure slotId. | [optional] [readonly] 
**DiskState** | **String** | The current drive state of disk. | [optional] [readonly] 
**Health** | **String** | The current drive state of disk. | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**PhysicalDisk** | [**StoragePhysicalDiskRelationship**](StoragePhysicalDiskRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StorageController** | [**StorageControllerRelationship**](StorageControllerRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStoragePhysicalDiskExtensionAllOf  -Bootable null `
 -DiskDn null `
 -DiskId null `
 -DiskState null `
 -Health null `
 -InventoryDeviceInfo null `
 -PhysicalDisk null `
 -RegisteredDevice null `
 -StorageController null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

