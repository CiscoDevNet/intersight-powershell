# StorageEnclosureDiskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.EnclosureDisk"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.EnclosureDisk"]
**BlockSize** | **String** | The block size of the physical disk in bytes. | [optional] 
**DiskId** | **String** | This field represents the disk Id in the storage enclosure. | [optional] 
**DiskState** | **String** | This field identifies the current disk configuration applied in the physical disk. | [optional] 
**Health** | **String** | The current health state of the enclosure disk. | [optional] 
**NumBlocks** | **String** | The number of blocks present on the physical disk. | [optional] 
**VarPid** | **String** | This field identifies the Product ID for physicalDisk. | [optional] [readonly] 
**SasAddress1** | **String** | This field identifies the SAS address assigned to the disk SAS port-1. | [optional] 
**SasAddress2** | **String** | This field identifies the SAS address assigned to the disk SAS port-2. | [optional] 
**Size** | **String** | The size of the physical disk in MB. | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**PhysicalDisk** | [**StoragePhysicalDiskRelationship**](StoragePhysicalDiskRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StorageEnclosure** | [**StorageEnclosureRelationship**](StorageEnclosureRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageEnclosureDiskAllOf = Initialize-IntersightStorageEnclosureDiskAllOf  -ClassId null `
 -ObjectType null `
 -BlockSize null `
 -DiskId null `
 -DiskState null `
 -Health null `
 -NumBlocks null `
 -VarPid null `
 -SasAddress1 null `
 -SasAddress2 null `
 -Size null `
 -InventoryDeviceInfo null `
 -PhysicalDisk null `
 -RegisteredDevice null `
 -StorageEnclosure null
```

- Convert the resource to JSON
```powershell
$StorageEnclosureDiskAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

