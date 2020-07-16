# StorageFlexUtilPhysicalDriveAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlockSize** | **String** | Block size of the FlexUtil Physical drive. | [optional] 
**Capacity** | **String** | Capacity of the FlexUtil Physical drive. | [optional] 
**Controller** | **String** | Type of the Physical Drive Controller. | [optional] 
**DrivesEnabled** | **String** | The number of drives enabled in the FlexUtil Physical Drive. | [optional] 
**Health** | **String** | Health of the FlexUtil Physical drive. | [optional] 
**ManufacturerDate** | **String** | Manufacturing date of the FlexUtil Physical Drive. | [optional] 
**ManufacturerId** | **String** | Manufacturer identity of the FlexUtil Physical Drive. | [optional] 
**OemId** | **String** | The OEM Identifier of the FlexUtil physical drive. | [optional] 
**PartitionCount** | **String** | The number of partitions present on the FlexUtil Physical Drive. | [optional] 
**PdStatus** | **String** | Status of the FlexUtil Physical Drive. | [optional] 
**PhysicalDrive** | **String** | The type of physical drive. Example - microSD. | [optional] 
**ProductName** | **String** | Product name of the FlexUtil Physical Drive. | [optional] 
**ProductRevision** | **String** | Product revision of the FlexUtil Physical Drive. | [optional] 
**ReadErrorCount** | **String** | Read error count of the FlexUtil Physical Drive. | [optional] 
**ReadErrorThreshold** | **String** | Read error threshold for FlexUtil Physical Drive. | [optional] 
**WriteEnabled** | **String** | Write access state of the FlexUtil Physical Drive. | [optional] 
**WriteErrorCount** | **String** | Write error count of the FlexUtil Physical Drive. | [optional] 
**WriteErrorThreshold** | **String** | Write error threshold for FlexUtil Physical Drive. | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StorageFlexUtilController** | [**StorageFlexUtilControllerRelationship**](StorageFlexUtilControllerRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageFlexUtilPhysicalDriveAllOf  -BlockSize null `
 -Capacity null `
 -Controller null `
 -DrivesEnabled null `
 -Health null `
 -ManufacturerDate null `
 -ManufacturerId null `
 -OemId null `
 -PartitionCount null `
 -PdStatus null `
 -PhysicalDrive null `
 -ProductName null `
 -ProductRevision null `
 -ReadErrorCount null `
 -ReadErrorThreshold null `
 -WriteEnabled null `
 -WriteErrorCount null `
 -WriteErrorThreshold null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -StorageFlexUtilController null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

