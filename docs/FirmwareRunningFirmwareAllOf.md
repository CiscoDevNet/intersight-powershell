# FirmwareRunningFirmwareAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.RunningFirmware"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.RunningFirmware"]
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
$FirmwareRunningFirmwareAllOf = Initialize-IntersightFirmwareRunningFirmwareAllOf  -ClassId null `
 -ObjectType null `
 -Component null `
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
$FirmwareRunningFirmwareAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

