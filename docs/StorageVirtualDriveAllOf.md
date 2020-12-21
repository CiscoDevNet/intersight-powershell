# StorageVirtualDriveAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.VirtualDrive"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.VirtualDrive"]
**AccessPolicy** | **String** | The access policy of the virtual drive. | [optional] [readonly] 
**ActualWriteCachePolicy** | **String** | The current write cache policy of the virtual drive. | [optional] [readonly] 
**AvailableSize** | **String** | Available storage capacity of the virtual drive. | [optional] [readonly] 
**BlockSize** | **String** | Block size of the virtual drive. | [optional] [readonly] 
**Bootable** | **String** | The virtual drive bootable state. | [optional] [readonly] 
**ConfigState** | **String** | The configuration state of the virtual drive. | [optional] [readonly] 
**ConfiguredWriteCachePolicy** | **String** | The requested write cache policy of the virtual drive. | [optional] [readonly] 
**ConnectionProtocol** | **String** | The connection protocol of the virtual drive. | [optional] [readonly] 
**DriveCache** | **String** | The state of the drive cache of the virtual drive. | [optional] [readonly] 
**DriveSecurity** | **String** | The driveSecurity state of the Virtual drive. | [optional] [readonly] 
**DriveState** | **String** | The state of the Virtual drive. | [optional] [readonly] 
**IoPolicy** | **String** | The Input/Output Policy defined on the Virtual drive. | [optional] [readonly] 
**Name** | **String** | The name of the Virtual drive. | [optional] [readonly] 
**NumBlocks** | **String** | Number of Blocks on the Physical Disk. | [optional] [readonly] 
**OperState** | **String** | The current operational state of Virtual drive. | [optional] [readonly] 
**Operability** | **String** | The current operability state of Virtual drive. | [optional] [readonly] 
**PhysicalBlockSize** | **String** | The block size of the the virtual drive. | [optional] [readonly] 
**Presence** | **String** | The presence status of the virtual drive. | [optional] [readonly] 
**ReadPolicy** | **String** | The read-ahead cache mode of the virtual drive. | [optional] [readonly] 
**SecurityFlags** | **String** | The security flags set for this virtual drive. | [optional] [readonly] 
**Size** | **String** | The size of the virtual drive in MB. | [optional] [readonly] 
**StripSize** | **String** | The strip size is the portion of a stripe that resides on a single drive in the drive group, this is measured in KB. | [optional] [readonly] 
**Type** | **String** | The raid type of the virtual drive. | [optional] [readonly] 
**Uuid** | **String** | The uuid of the virtual drive. | [optional] [readonly] 
**VendorUuid** | **String** | The UUID value of the vendor. | [optional] [readonly] 
**VirtualDriveId** | **String** | The identifier for this Virtual drive. | [optional] [readonly] 
**DiskGroup** | [**StorageDiskGroupRelationship**](StorageDiskGroupRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**PhysicalDiskUsages** | [**StoragePhysicalDiskUsageRelationship[]**](StoragePhysicalDiskUsageRelationship.md) | An array of relationships to storagePhysicalDiskUsage resources. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StorageController** | [**StorageControllerRelationship**](StorageControllerRelationship.md) |  | [optional] 
**StorageVirtualDriveContainer** | [**StorageVirtualDriveContainerRelationship**](StorageVirtualDriveContainerRelationship.md) |  | [optional] 
**VdMemberEps** | [**StorageVdMemberEpRelationship[]**](StorageVdMemberEpRelationship.md) | An array of relationships to storageVdMemberEp resources. | [optional] [readonly] 
**VirtualDriveExtension** | [**StorageVirtualDriveExtensionRelationship**](StorageVirtualDriveExtensionRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageVirtualDriveAllOf = Initialize-IntersightStorageVirtualDriveAllOf  -ClassId null `
 -ObjectType null `
 -AccessPolicy null `
 -ActualWriteCachePolicy null `
 -AvailableSize null `
 -BlockSize null `
 -Bootable null `
 -ConfigState null `
 -ConfiguredWriteCachePolicy null `
 -ConnectionProtocol null `
 -DriveCache null `
 -DriveSecurity null `
 -DriveState null `
 -IoPolicy null `
 -Name null `
 -NumBlocks null `
 -OperState null `
 -Operability null `
 -PhysicalBlockSize null `
 -Presence null `
 -ReadPolicy null `
 -SecurityFlags null `
 -Size null `
 -StripSize null `
 -Type null `
 -Uuid null `
 -VendorUuid null `
 -VirtualDriveId null `
 -DiskGroup null `
 -InventoryDeviceInfo null `
 -PhysicalDiskUsages null `
 -RegisteredDevice null `
 -StorageController null `
 -StorageVirtualDriveContainer null `
 -VdMemberEps null `
 -VirtualDriveExtension null
```

- Convert the resource to JSON
```powershell
$StorageVirtualDriveAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

