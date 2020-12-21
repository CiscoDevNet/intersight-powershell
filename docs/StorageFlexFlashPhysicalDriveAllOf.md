# StorageFlexFlashPhysicalDriveAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.FlexFlashPhysicalDrive"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.FlexFlashPhysicalDrive"]
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
$StorageFlexFlashPhysicalDriveAllOf = Initialize-IntersightStorageFlexFlashPhysicalDriveAllOf  -ClassId null `
 -ObjectType null `
 -CardStatus null `
 -CardType null `
 -OemId null `
 -PdStatus null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -StorageFlexFlashController null
```

- Convert the resource to JSON
```powershell
$StorageFlexFlashPhysicalDriveAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

