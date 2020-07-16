# FirmwareRunningFirmwareAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Component** | **String** | Kind of the firmware - boot-booloader/system/kernel. | [optional] [readonly] 
**PackageVersion** | **String** | Package version which the firmware belongs to. | [optional] [readonly] 
**Type** | **String** | The type of the firmware. | [optional] [readonly] 
**Version** | **String** | The version of the firmware. | [optional] [readonly] 
**BiosUnit** | [**BiosUnitRelationship**](BiosUnitRelationship.md) |  | [optional] 
**GraphicsCard** | [**GraphicsCardRelationship**](GraphicsCardRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**ManagementController** | [**ManagementControllerRelationship**](ManagementControllerRelationship.md) |  | [optional] 
**NetworkElements** | [**NetworkElementRelationship[]**](NetworkElementRelationship.md) | An array of relationships to networkElement resources. | [optional] 
**PciSwitch** | [**PciSwitchRelationship**](PciSwitchRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StorageController** | [**StorageControllerRelationship**](StorageControllerRelationship.md) |  | [optional] 
**StorageFlexFlashController** | [**StorageFlexFlashControllerRelationship**](StorageFlexFlashControllerRelationship.md) |  | [optional] 
**StoragePhysicalDisk** | [**StoragePhysicalDiskRelationship**](StoragePhysicalDiskRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareRunningFirmwareAllOf  -Component null `
 -PackageVersion null `
 -Type null `
 -Version null `
 -BiosUnit null `
 -GraphicsCard null `
 -InventoryDeviceInfo null `
 -ManagementController null `
 -NetworkElements null `
 -PciSwitch null `
 -RegisteredDevice null `
 -StorageController null `
 -StorageFlexFlashController null `
 -StoragePhysicalDisk null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

