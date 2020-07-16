# ComputeRackUnitAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConnectionStatus** | **String** | Connectivity Status of RackUnit to Switch - A or B or AB. | [optional] [readonly] 
**ServerId** | **Int64** | RackUnit ID that uniquely identifies the server. | [optional] [readonly] 
**TopologyScanStatus** | **String** | To maintain the Topology workflow run status. | [optional] 
**Adapters** | [**AdapterUnitRelationship[]**](AdapterUnitRelationship.md) | An array of relationships to adapterUnit resources. | [optional] [readonly] 
**BiosBootmode** | [**BiosBootModeRelationship**](BiosBootModeRelationship.md) |  | [optional] 
**Biosunits** | [**BiosUnitRelationship[]**](BiosUnitRelationship.md) | An array of relationships to biosUnit resources. | [optional] [readonly] 
**Bmc** | [**ManagementControllerRelationship**](ManagementControllerRelationship.md) |  | [optional] 
**Board** | [**ComputeBoardRelationship**](ComputeBoardRelationship.md) |  | [optional] 
**BootDeviceBootmode** | [**BootDeviceBootModeRelationship**](BootDeviceBootModeRelationship.md) |  | [optional] 
**Fanmodules** | [**EquipmentFanModuleRelationship[]**](EquipmentFanModuleRelationship.md) | An array of relationships to equipmentFanModule resources. | [optional] [readonly] 
**GenericInventoryHolders** | [**InventoryGenericInventoryHolderRelationship[]**](InventoryGenericInventoryHolderRelationship.md) | An array of relationships to inventoryGenericInventoryHolder resources. | [optional] [readonly] 
**GraphicsCards** | [**GraphicsCardRelationship[]**](GraphicsCardRelationship.md) | An array of relationships to graphicsCard resources. | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**LocatorLed** | [**EquipmentLocatorLedRelationship**](EquipmentLocatorLedRelationship.md) |  | [optional] 
**MemoryArrays** | [**MemoryArrayRelationship[]**](MemoryArrayRelationship.md) | An array of relationships to memoryArray resources. | [optional] 
**PciDevices** | [**PciDeviceRelationship[]**](PciDeviceRelationship.md) | An array of relationships to pciDevice resources. | [optional] [readonly] 
**Processors** | [**ProcessorUnitRelationship[]**](ProcessorUnitRelationship.md) | An array of relationships to processorUnit resources. | [optional] 
**Psus** | [**EquipmentPsuRelationship[]**](EquipmentPsuRelationship.md) | An array of relationships to equipmentPsu resources. | [optional] [readonly] 
**RackEnclosureSlot** | [**EquipmentRackEnclosureSlotRelationship**](EquipmentRackEnclosureSlotRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**SasExpanders** | [**StorageSasExpanderRelationship[]**](StorageSasExpanderRelationship.md) | An array of relationships to storageSasExpander resources. | [optional] 
**StorageControllers** | [**StorageControllerRelationship[]**](StorageControllerRelationship.md) | An array of relationships to storageController resources. | [optional] 
**StorageEnclosures** | [**StorageEnclosureRelationship[]**](StorageEnclosureRelationship.md) | An array of relationships to storageEnclosure resources. | [optional] [readonly] 
**TopSystem** | [**TopSystemRelationship**](TopSystemRelationship.md) |  | [optional] 
**UemConnection** | [**InventoryUemConnectionRelationship**](InventoryUemConnectionRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightComputeRackUnitAllOf  -ConnectionStatus null `
 -ServerId null `
 -TopologyScanStatus null `
 -Adapters null `
 -BiosBootmode null `
 -Biosunits null `
 -Bmc null `
 -Board null `
 -BootDeviceBootmode null `
 -Fanmodules null `
 -GenericInventoryHolders null `
 -GraphicsCards null `
 -InventoryDeviceInfo null `
 -LocatorLed null `
 -MemoryArrays null `
 -PciDevices null `
 -Processors null `
 -Psus null `
 -RackEnclosureSlot null `
 -RegisteredDevice null `
 -SasExpanders null `
 -StorageControllers null `
 -StorageEnclosures null `
 -TopSystem null `
 -UemConnection null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

