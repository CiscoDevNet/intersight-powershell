# StorageControllerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.Controller"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.Controller"]
**ControllerFlags** | **String** | The flags for the storage controller. | [optional] [readonly] 
**ControllerId** | **String** | The Id of the storage controller. | [optional] [readonly] 
**ControllerStatus** | **String** | The current status of controller. | [optional] [readonly] 
**ForeignConfigPresent** | **Boolean** | Storage controller has detected disks in foreign config. | [optional] 
**HwRevision** | **String** | The hardware revision of controller. | [optional] [readonly] 
**InterfaceType** | **String** | Interface types are Sas, Sata, PCH. | [optional] 
**MaxVolumesSupported** | **Int64** | Maximum virtual drives that can be created on this Storage Controller. | [optional] 
**OobInterfaceSupported** | **String** | The CIMC support for out-of-band configuration of controller. | [optional] [readonly] 
**OperState** | **String** | The current operational state of controller. | [optional] [readonly] 
**Operability** | **String** | Operability state of the storage controller. | [optional] [readonly] 
**PciAddr** | **String** | The current pci address of controller. | [optional] [readonly] 
**PciSlot** | **String** | The pci slot name for the controller. | [optional] [readonly] 
**Presence** | **String** | Physical Presence State for the Storage Controller. | [optional] [readonly] 
**RaidSupport** | **String** | The RAID levels supported by controller. | [optional] [readonly] 
**RebuildRate** | **String** | Logical volume or RAID rebuild rate of Storage Controller. | [optional] [readonly] 
**SelfEncryptEnabled** | **String** | Storage controller disk self encryption state. | [optional] 
**Type** | **String** | Controller types are Raid, FlexFlash. | [optional] [readonly] 
**ComputeBlade** | [**ComputeBladeRelationship**](ComputeBladeRelationship.md) |  | [optional] 
**ComputeBoard** | [**ComputeBoardRelationship**](ComputeBoardRelationship.md) |  | [optional] 
**ComputeRackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**DiskGroup** | [**StorageDiskGroupRelationship[]**](StorageDiskGroupRelationship.md) | An array of relationships to storageDiskGroup resources. | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**PhysicalDiskExtensions** | [**StoragePhysicalDiskExtensionRelationship[]**](StoragePhysicalDiskExtensionRelationship.md) | An array of relationships to storagePhysicalDiskExtension resources. | [optional] [readonly] 
**PhysicalDisks** | [**StoragePhysicalDiskRelationship[]**](StoragePhysicalDiskRelationship.md) | An array of relationships to storagePhysicalDisk resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**RunningFirmware** | [**FirmwareRunningFirmwareRelationship[]**](FirmwareRunningFirmwareRelationship.md) | An array of relationships to firmwareRunningFirmware resources. | [optional] [readonly] 
**VirtualDriveExtensions** | [**StorageVirtualDriveExtensionRelationship[]**](StorageVirtualDriveExtensionRelationship.md) | An array of relationships to storageVirtualDriveExtension resources. | [optional] [readonly] 
**VirtualDrives** | [**StorageVirtualDriveRelationship[]**](StorageVirtualDriveRelationship.md) | An array of relationships to storageVirtualDrive resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$StorageControllerAllOf = Initialize-IntersightStorageControllerAllOf  -ClassId null `
 -ObjectType null `
 -ControllerFlags null `
 -ControllerId null `
 -ControllerStatus null `
 -ForeignConfigPresent null `
 -HwRevision null `
 -InterfaceType null `
 -MaxVolumesSupported null `
 -OobInterfaceSupported null `
 -OperState null `
 -Operability null `
 -PciAddr null `
 -PciSlot null `
 -Presence null `
 -RaidSupport null `
 -RebuildRate null `
 -SelfEncryptEnabled null `
 -Type null `
 -ComputeBlade null `
 -ComputeBoard null `
 -ComputeRackUnit null `
 -DiskGroup null `
 -InventoryDeviceInfo null `
 -PhysicalDiskExtensions null `
 -PhysicalDisks null `
 -RegisteredDevice null `
 -RunningFirmware null `
 -VirtualDriveExtensions null `
 -VirtualDrives null
```

- Convert the resource to JSON
```powershell
$StorageControllerAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

