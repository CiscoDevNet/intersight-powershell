# StorageFlexFlashVirtualDriveAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.FlexFlashVirtualDrive"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.FlexFlashVirtualDrive"]
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
$StorageFlexFlashVirtualDriveAllOf = Initialize-IntersightStorageFlexFlashVirtualDriveAllOf  -ClassId null `
 -ObjectType null `
 -DriveScope null `
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
$StorageFlexFlashVirtualDriveAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

