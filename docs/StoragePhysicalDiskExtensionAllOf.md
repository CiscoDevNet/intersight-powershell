# StoragePhysicalDiskExtensionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.PhysicalDiskExtension"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.PhysicalDiskExtension"]
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
$StoragePhysicalDiskExtensionAllOf = Initialize-IntersightStoragePhysicalDiskExtensionAllOf  -ClassId null `
 -ObjectType null `
 -Bootable null `
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
$StoragePhysicalDiskExtensionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

