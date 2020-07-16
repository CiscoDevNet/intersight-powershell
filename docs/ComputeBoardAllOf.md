# ComputeBoardAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BoardId** | **Int64** | The identity of the motherboard. | [optional] [readonly] 
**CpuTypeController** | **String** | The type of central processing unit on the mother board. | [optional] [readonly] 
**OperPowerState** | **String** | Current power state of the mother board of the server. | [optional] [readonly] 
**Presence** | **String** | Identifies the presence of the mother board of the server. | [optional] [readonly] 
**ComputeBlade** | [**ComputeBladeRelationship**](ComputeBladeRelationship.md) |  | [optional] 
**ComputeRackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**EquipmentTpms** | [**EquipmentTpmRelationship[]**](EquipmentTpmRelationship.md) | An array of relationships to equipmentTpm resources. | [optional] [readonly] 
**GraphicsCards** | [**GraphicsCardRelationship[]**](GraphicsCardRelationship.md) | An array of relationships to graphicsCard resources. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**MemoryArrays** | [**MemoryArrayRelationship[]**](MemoryArrayRelationship.md) | An array of relationships to memoryArray resources. | [optional] [readonly] 
**PciCoprocessorCards** | [**PciCoprocessorCardRelationship[]**](PciCoprocessorCardRelationship.md) | An array of relationships to pciCoprocessorCard resources. | [optional] [readonly] 
**PciSwitch** | [**PciSwitchRelationship[]**](PciSwitchRelationship.md) | An array of relationships to pciSwitch resources. | [optional] [readonly] 
**PersistentMemoryConfiguration** | [**MemoryPersistentMemoryConfigurationRelationship**](MemoryPersistentMemoryConfigurationRelationship.md) |  | [optional] 
**Processors** | [**ProcessorUnitRelationship[]**](ProcessorUnitRelationship.md) | An array of relationships to processorUnit resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**SecurityUnits** | [**SecurityUnitRelationship[]**](SecurityUnitRelationship.md) | An array of relationships to securityUnit resources. | [optional] [readonly] 
**StorageControllers** | [**StorageControllerRelationship[]**](StorageControllerRelationship.md) | An array of relationships to storageController resources. | [optional] [readonly] 
**StorageFlexFlashControllers** | [**StorageFlexFlashControllerRelationship[]**](StorageFlexFlashControllerRelationship.md) | An array of relationships to storageFlexFlashController resources. | [optional] [readonly] 
**StorageFlexUtilControllers** | [**StorageFlexUtilControllerRelationship[]**](StorageFlexUtilControllerRelationship.md) | An array of relationships to storageFlexUtilController resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightComputeBoardAllOf  -BoardId null `
 -CpuTypeController null `
 -OperPowerState null `
 -Presence null `
 -ComputeBlade null `
 -ComputeRackUnit null `
 -EquipmentTpms null `
 -GraphicsCards null `
 -InventoryDeviceInfo null `
 -MemoryArrays null `
 -PciCoprocessorCards null `
 -PciSwitch null `
 -PersistentMemoryConfiguration null `
 -Processors null `
 -RegisteredDevice null `
 -SecurityUnits null `
 -StorageControllers null `
 -StorageFlexFlashControllers null `
 -StorageFlexUtilControllers null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

