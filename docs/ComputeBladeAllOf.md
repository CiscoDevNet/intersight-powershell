# ComputeBladeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "compute.Blade"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "compute.Blade"]
**ChassisId** | **String** | The id of the chassis that the blade is located in. | [optional] [readonly] 
**ScaledMode** | **String** | The mode of the server that determines it is scaled. | [optional] [readonly] 
**SlotId** | **Int64** | The slot number in the chassis that the blade is located in. | [optional] [readonly] 
**Adapters** | [**AdapterUnitRelationship[]**](AdapterUnitRelationship.md) | An array of relationships to adapterUnit resources. | [optional] [readonly] 
**BiosBootmode** | [**BiosBootModeRelationship**](BiosBootModeRelationship.md) |  | [optional] 
**BiosUnits** | [**BiosUnitRelationship[]**](BiosUnitRelationship.md) | An array of relationships to biosUnit resources. | [optional] [readonly] 
**Bmc** | [**ManagementControllerRelationship**](ManagementControllerRelationship.md) |  | [optional] 
**Board** | [**ComputeBoardRelationship**](ComputeBoardRelationship.md) |  | [optional] 
**BootDeviceBootmode** | [**BootDeviceBootModeRelationship**](BootDeviceBootModeRelationship.md) |  | [optional] 
**EquipmentChassis** | [**EquipmentChassisRelationship**](EquipmentChassisRelationship.md) |  | [optional] 
**EquipmentIoExpanders** | [**EquipmentIoExpanderRelationship[]**](EquipmentIoExpanderRelationship.md) | An array of relationships to equipmentIoExpander resources. | [optional] [readonly] 
**GenericInventoryHolders** | [**InventoryGenericInventoryHolderRelationship[]**](InventoryGenericInventoryHolderRelationship.md) | An array of relationships to inventoryGenericInventoryHolder resources. | [optional] [readonly] 
**GraphicsCards** | [**GraphicsCardRelationship[]**](GraphicsCardRelationship.md) | An array of relationships to graphicsCard resources. | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**LocatorLed** | [**EquipmentLocatorLedRelationship**](EquipmentLocatorLedRelationship.md) |  | [optional] 
**MemoryArrays** | [**MemoryArrayRelationship[]**](MemoryArrayRelationship.md) | An array of relationships to memoryArray resources. | [optional] 
**PciDevices** | [**PciDeviceRelationship[]**](PciDeviceRelationship.md) | An array of relationships to pciDevice resources. | [optional] [readonly] 
**Processors** | [**ProcessorUnitRelationship[]**](ProcessorUnitRelationship.md) | An array of relationships to processorUnit resources. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StorageControllers** | [**StorageControllerRelationship[]**](StorageControllerRelationship.md) | An array of relationships to storageController resources. | [optional] 
**StorageEnclosures** | [**StorageEnclosureRelationship[]**](StorageEnclosureRelationship.md) | An array of relationships to storageEnclosure resources. | [optional] [readonly] 
**TopSystem** | [**TopSystemRelationship**](TopSystemRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ComputeBladeAllOf = Initialize-IntersightComputeBladeAllOf  -ClassId null `
 -ObjectType null `
 -ChassisId null `
 -ScaledMode null `
 -SlotId null `
 -Adapters null `
 -BiosBootmode null `
 -BiosUnits null `
 -Bmc null `
 -Board null `
 -BootDeviceBootmode null `
 -EquipmentChassis null `
 -EquipmentIoExpanders null `
 -GenericInventoryHolders null `
 -GraphicsCards null `
 -InventoryDeviceInfo null `
 -LocatorLed null `
 -MemoryArrays null `
 -PciDevices null `
 -Processors null `
 -RegisteredDevice null `
 -StorageControllers null `
 -StorageEnclosures null `
 -TopSystem null
```

- Convert the resource to JSON
```powershell
$ComputeBladeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

