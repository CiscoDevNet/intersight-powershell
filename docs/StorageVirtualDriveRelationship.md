# StorageVirtualDriveRelationship
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Selector** | **String** | An OData $filter expression which describes the REST resource to be referenced. This field may be set instead of &#39;moid&#39; by clients. 1. If &#39;moid&#39; is set this field is ignored. 1. If &#39;selector&#39; is set and &#39;moid&#39; is empty/absent from the request, Intersight determines the Moid of the resource matching the filter expression and populates it in the MoRef that is part of the object instance being inserted/updated to fulfill the REST request. An error is returned if the filter matches zero or more than one REST resource. An example filter string is: Serial eq &#39;3AA8B7T11&#39;. | [optional] [readonly] 
**Link** | **String** | A URL to an instance of the &#39;mo.MoRef&#39; class. | [optional] 
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | a map of display names for a resource. | [optional] [readonly] 
**DeviceMoId** | **String** | The database identifier of the registered device of an object. | [optional] [readonly] 
**Dn** | **String** | The Distinguished Name unambiguously identifies an object in the system. | [optional] [readonly] 
**Rn** | **String** | The Relative Name uniquely identifies an object within a given context. | [optional] [readonly] 
**Model** | **String** | This field identifies the model of the given component. | [optional] [readonly] 
**Revision** | **String** | This field identifies the revision of the given component. | [optional] [readonly] 
**Serial** | **String** | This field identifies the serial of the given component. | [optional] [readonly] 
**Vendor** | **String** | This field identifies the vendor of the given component. | [optional] [readonly] 
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
**VdMemberEps** | [**StorageVdMemberEpRelationship[]**](StorageVdMemberEpRelationship.md) | An array of relationships to storageVdMemberEp resources. | [optional] [readonly] 
**VirtualDriveExtension** | [**StorageVirtualDriveExtensionRelationship**](StorageVirtualDriveExtensionRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageVirtualDriveRelationship  -ClassId null `
 -ObjectType null `
 -Moid null `
 -Selector null `
 -Link null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
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
 -VdMemberEps null `
 -VirtualDriveExtension null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

