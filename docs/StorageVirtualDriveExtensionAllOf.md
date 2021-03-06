# StorageVirtualDriveExtensionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.VirtualDriveExtension"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.VirtualDriveExtension"]
**Bootable** | **String** | The ability to boot from the virtual drive. | [optional] [readonly] 
**ContainerId** | **Int64** | The container id of the virtual drive. | [optional] [readonly] 
**DriveState** | **String** | The state of the virtual drive. | [optional] [readonly] 
**Name** | **String** | The name of the Virtual drive. | [optional] [readonly] 
**OperDeviceId** | **String** | The operational device id of the virtual drive. | [optional] [readonly] 
**Uuid** | **String** | The UUID assigned to the virtual drive. | [optional] [readonly] 
**VendorUuid** | **String** | The UUID value of the vendor assigned to the virtual drive. | [optional] [readonly] 
**VirtualDriveDn** | **String** | The distinguished name of the virtual drive for which the extended data is provided. | [optional] [readonly] 
**VirtualDriveId** | **String** | The Id of the virtual drive. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StorageController** | [**StorageControllerRelationship**](StorageControllerRelationship.md) |  | [optional] 
**VirtualDrive** | [**StorageVirtualDriveRelationship**](StorageVirtualDriveRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageVirtualDriveExtensionAllOf = Initialize-IntersightStorageVirtualDriveExtensionAllOf  -ClassId null `
 -ObjectType null `
 -Bootable null `
 -ContainerId null `
 -DriveState null `
 -Name null `
 -OperDeviceId null `
 -Uuid null `
 -VendorUuid null `
 -VirtualDriveDn null `
 -VirtualDriveId null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -StorageController null `
 -VirtualDrive null
```

- Convert the resource to JSON
```powershell
$StorageVirtualDriveExtensionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

