# StorageFlexFlashControllerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ControllerState** | **String** | State of the Flex Flash Storage Controller. | [optional] [readonly] 
**FfControllerId** | **String** | Identifier for the Flex Flash Storage Controller. | [optional] [readonly] 
**ComputeBoard** | [**ComputeBoardRelationship**](ComputeBoardRelationship.md) |  | [optional] 
**FlexFlashControllerProps** | [**StorageFlexFlashControllerPropsRelationship[]**](StorageFlexFlashControllerPropsRelationship.md) | An array of relationships to storageFlexFlashControllerProps resources. | [optional] [readonly] 
**FlexFlashPhysicalDrives** | [**StorageFlexFlashPhysicalDriveRelationship[]**](StorageFlexFlashPhysicalDriveRelationship.md) | An array of relationships to storageFlexFlashPhysicalDrive resources. | [optional] [readonly] 
**FlexFlashVirtualDrives** | [**StorageFlexFlashVirtualDriveRelationship[]**](StorageFlexFlashVirtualDriveRelationship.md) | An array of relationships to storageFlexFlashVirtualDrive resources. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**RunningFirmware** | [**FirmwareRunningFirmwareRelationship[]**](FirmwareRunningFirmwareRelationship.md) | An array of relationships to firmwareRunningFirmware resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageFlexFlashControllerAllOf  -ControllerState null `
 -FfControllerId null `
 -ComputeBoard null `
 -FlexFlashControllerProps null `
 -FlexFlashPhysicalDrives null `
 -FlexFlashVirtualDrives null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -RunningFirmware null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

