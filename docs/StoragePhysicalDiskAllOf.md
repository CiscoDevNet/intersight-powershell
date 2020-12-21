# StoragePhysicalDiskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.PhysicalDisk"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.PhysicalDisk"]
**BlockSize** | **String** | The block size of the physical disk in bytes. | [optional] [readonly] 
**Bootable** | **String** | This field identifies the disk drive as bootable if set to true. | [optional] [readonly] 
**ConfigurationCheckpoint** | **String** | The current configuration checkpoint of the physical disk. | [optional] [readonly] 
**ConfigurationState** | **String** | The current configuration state of the physical disk. | [optional] [readonly] 
**DiscoveredPath** | **String** | The discovered path of the physical disk. | [optional] [readonly] 
**DiskId** | **String** | This field identifies the ID assigned to physical disks. | [optional] [readonly] 
**DiskState** | **String** | This field identifies the health of the disk. | [optional] [readonly] 
**DriveFirmware** | **String** | This field identifies the disk firmware running in the disk. | [optional] 
**DriveState** | **String** | The drive state as reported by the controller. | [optional] [readonly] 
**FdeCapable** | **String** | Full-Disk Encryption capability parameter of the physical disk. | [optional] 
**HotSpareType** | **String** | Type of hotspare configured on the physical disk. | [optional] 
**LinkSpeed** | **String** | The speed of the link between the drive and the controller. | [optional] [readonly] 
**LinkState** | **String** | The current link state of the physical disk. | [optional] [readonly] 
**NumBlocks** | **String** | The number of blocks present on the physical disk. | [optional] [readonly] 
**OperPowerState** | **String** | Operational power of the physical disk. | [optional] [readonly] 
**OperQualifierReason** | **String** | This reason for the operational status of the disk. | [optional] [readonly] 
**Operability** | **String** | This field identifies the disk operability of the disk. | [optional] [readonly] 
**PhysicalBlockSize** | **String** | The block size of the installed physical disk. | [optional] [readonly] 
**VarPid** | **String** | This field identifies the Product ID for physicalDisk. | [optional] [readonly] 
**Presence** | **String** | The presence state of the physical disk. | [optional] [readonly] 
**Protocol** | **String** | This field identifies the disk protocol used for communication. | [optional] [readonly] 
**RawSize** | **String** | The raw size of the physical disk in MB. | [optional] [readonly] 
**Secured** | **String** | This field identifies whether the disk is encrypted. | [optional] 
**Size** | **String** | The size of the physical disk in MB. | [optional] [readonly] 
**Thermal** | **String** | Thermal state of the physical disk. | [optional] [readonly] 
**Type** | **String** | This field identifies the type of the physical disk. | [optional] [readonly] 
**VariantType** | **String** | The variant type of the physical disk. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**LocatorLed** | [**EquipmentLocatorLedRelationship**](EquipmentLocatorLedRelationship.md) |  | [optional] 
**PhysicalDiskExtensions** | [**StoragePhysicalDiskExtensionRelationship[]**](StoragePhysicalDiskExtensionRelationship.md) | An array of relationships to storagePhysicalDiskExtension resources. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**RunningFirmware** | [**FirmwareRunningFirmwareRelationship[]**](FirmwareRunningFirmwareRelationship.md) | An array of relationships to firmwareRunningFirmware resources. | [optional] [readonly] 
**SasPorts** | [**StorageSasPortRelationship[]**](StorageSasPortRelationship.md) | An array of relationships to storageSasPort resources. | [optional] [readonly] 
**StorageController** | [**StorageControllerRelationship**](StorageControllerRelationship.md) |  | [optional] 
**StorageEnclosure** | [**StorageEnclosureRelationship**](StorageEnclosureRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StoragePhysicalDiskAllOf = Initialize-IntersightStoragePhysicalDiskAllOf  -ClassId null `
 -ObjectType null `
 -BlockSize null `
 -Bootable null `
 -ConfigurationCheckpoint null `
 -ConfigurationState null `
 -DiscoveredPath null `
 -DiskId null `
 -DiskState null `
 -DriveFirmware null `
 -DriveState null `
 -FdeCapable null `
 -HotSpareType null `
 -LinkSpeed null `
 -LinkState null `
 -NumBlocks null `
 -OperPowerState null `
 -OperQualifierReason null `
 -Operability null `
 -PhysicalBlockSize null `
 -VarPid null `
 -Presence null `
 -Protocol null `
 -RawSize null `
 -Secured null `
 -Size null `
 -Thermal null `
 -Type null `
 -VariantType null `
 -InventoryDeviceInfo null `
 -LocatorLed null `
 -PhysicalDiskExtensions null `
 -RegisteredDevice null `
 -RunningFirmware null `
 -SasPorts null `
 -StorageController null `
 -StorageEnclosure null
```

- Convert the resource to JSON
```powershell
$StoragePhysicalDiskAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

