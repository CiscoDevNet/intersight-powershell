# StorageFlexUtilControllerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ControllerName** | **String** | Name of the Flex Util Controller. | [optional] 
**ControllerStatus** | **String** | The current status of the controller. | [optional] 
**FfControllerId** | **String** | Identifier for the Storage Flex Util Controller. | [optional] 
**InternalState** | **String** | The internal state of the controller. | [optional] 
**ComputeBoard** | [**ComputeBoardRelationship**](ComputeBoardRelationship.md) |  | [optional] 
**FlexUtilPhysicalDrives** | [**StorageFlexUtilPhysicalDriveRelationship[]**](StorageFlexUtilPhysicalDriveRelationship.md) | An array of relationships to storageFlexUtilPhysicalDrive resources. | [optional] [readonly] 
**FlexUtilVirtualDrives** | [**StorageFlexUtilVirtualDriveRelationship[]**](StorageFlexUtilVirtualDriveRelationship.md) | An array of relationships to storageFlexUtilVirtualDrive resources. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageFlexUtilControllerAllOf  -ControllerName null `
 -ControllerStatus null `
 -FfControllerId null `
 -InternalState null `
 -ComputeBoard null `
 -FlexUtilPhysicalDrives null `
 -FlexUtilVirtualDrives null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

