# EquipmentLocatorLedAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Color** | **String** | Color of the locatorled available on an equipment. | [optional] [readonly] 
**OperState** | **String** | Identifies the operational state of locatorled. | [optional] [readonly] 
**ComputeBlade** | [**ComputeBladeRelationship**](ComputeBladeRelationship.md) |  | [optional] 
**ComputeRackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**EquipmentChassis** | [**EquipmentChassisRelationship**](EquipmentChassisRelationship.md) |  | [optional] 
**EquipmentFex** | [**EquipmentFexRelationship**](EquipmentFexRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StoragePhysicalDisk** | [**StoragePhysicalDiskRelationship**](StoragePhysicalDiskRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentLocatorLedAllOf  -Color null `
 -OperState null `
 -ComputeBlade null `
 -ComputeRackUnit null `
 -EquipmentChassis null `
 -EquipmentFex null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -StoragePhysicalDisk null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

