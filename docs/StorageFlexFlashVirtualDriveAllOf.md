# StorageFlexFlashVirtualDriveAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DriveScope** | **String** | The drive scope of the flex flash virtual drive. | [optional] 
**DriveStatus** | **String** | Status of virtual drive on the flex controller. | [optional] 
**PartitionId** | **String** | The partition Id of the flex flash virtual Drive. | [optional] 
**ResidentImage** | **String** | The resident image on the flex flash virtual Drive. | [optional] 
**Size** | **String** | Size of virtual drive on the flex controller. | [optional] 
**VirtualDrive** | **String** | Virtual drive on the flex flash controller. | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StorageFlexFlashController** | [**StorageFlexFlashControllerRelationship**](StorageFlexFlashControllerRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageFlexFlashVirtualDriveAllOf  -DriveScope null `
 -DriveStatus null `
 -PartitionId null `
 -ResidentImage null `
 -Size null `
 -VirtualDrive null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -StorageFlexFlashController null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

