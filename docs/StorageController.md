# StorageController
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.Controller"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.Controller"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**DeviceMoId** | **String** | The database identifier of the registered device of an object. | [optional] [readonly] 
**Dn** | **String** | The Distinguished Name unambiguously identifies an object in the system. | [optional] [readonly] 
**Rn** | **String** | The Relative Name uniquely identifies an object within a given context. | [optional] [readonly] 
**Model** | **String** | This field identifies the model of the given component. | [optional] [readonly] 
**Revision** | **String** | This field identifies the revision of the given component. | [optional] [readonly] 
**Serial** | **String** | This field identifies the serial of the given component. | [optional] [readonly] 
**Vendor** | **String** | This field identifies the vendor of the given component. | [optional] [readonly] 
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
$StorageController = Initialize-IntersightStorageController  -ClassId null `
 -ObjectType null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -DeviceMoId null `
 -Dn null `
 -Rn null `
 -Model null `
 -Revision null `
 -Serial null `
 -Vendor null `
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
$StorageController | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

