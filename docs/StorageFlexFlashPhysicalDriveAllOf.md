# StorageFlexFlashPhysicalDriveAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardStatus** | **String** | The status of the flex flash physical drive. | [optional] 
**CardType** | **String** | The card type of the flex flash physical drive. | [optional] 
**OemId** | **String** | The OEM Identifier of the flex flash physical drive. | [optional] 
**PdStatus** | **String** | The drive status of the flex flash physical drive. | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StorageFlexFlashController** | [**StorageFlexFlashControllerRelationship**](StorageFlexFlashControllerRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageFlexFlashPhysicalDriveAllOf  -CardStatus null `
 -CardType null `
 -OemId null `
 -PdStatus null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -StorageFlexFlashController null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

