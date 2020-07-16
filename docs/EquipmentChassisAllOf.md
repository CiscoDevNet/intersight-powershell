# EquipmentChassisAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChassisId** | **Int64** | The assigned identifier for a chassis. | [optional] [readonly] 
**ConnectionPath** | **String** | This field identifies the connectivity path for the chassis enclosure. | [optional] [readonly] 
**ConnectionStatus** | **String** | This field identifies the connectivity status for the chassis enclosure. | [optional] [readonly] 
**Description** | **String** | This field is to provide description for chassis model. | [optional] [readonly] 
**FaultSummary** | **Int64** | This field summarizes the faults on the chassis enclosure. | [optional] 
**ManagementMode** | **String** | The management mode of the blade server chassis. | [optional] [readonly] [default to "IntersightStandalone"]
**Name** | **String** | This field identifies the name for the chassis enclosure. | [optional] [readonly] 
**OperState** | **String** | This field identifies the Chassis Operational State. | [optional] [readonly] 
**PartNumber** | **String** | Part Number identifier for the chassis enclosure. | [optional] [readonly] 
**VarPid** | **String** | This field identifies the Product ID for the chassis enclosure. | [optional] [readonly] 
**PlatformType** | **String** | The platform type that the chassis is a part of. | [optional] 
**ProductName** | **String** | This field identifies the Product Name for the chassis enclosure. | [optional] [readonly] 
**Sku** | **String** | This field identifies the Stock Keeping Unit for the chassis enclosure. | [optional] [readonly] 
**Vid** | **String** | This field identifies the Vendor ID for the chassis enclosure. | [optional] [readonly] 
**Blades** | [**ComputeBladeRelationship[]**](ComputeBladeRelationship.md) | An array of relationships to computeBlade resources. | [optional] [readonly] 
**Fanmodules** | [**EquipmentFanModuleRelationship[]**](EquipmentFanModuleRelationship.md) | An array of relationships to equipmentFanModule resources. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**Ioms** | [**EquipmentIoCardRelationship[]**](EquipmentIoCardRelationship.md) | An array of relationships to equipmentIoCard resources. | [optional] [readonly] 
**LocatorLed** | [**EquipmentLocatorLedRelationship**](EquipmentLocatorLedRelationship.md) |  | [optional] 
**PsuControl** | [**EquipmentPsuControlRelationship**](EquipmentPsuControlRelationship.md) |  | [optional] 
**Psus** | [**EquipmentPsuRelationship[]**](EquipmentPsuRelationship.md) | An array of relationships to equipmentPsu resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Sasexpanders** | [**StorageSasExpanderRelationship[]**](StorageSasExpanderRelationship.md) | An array of relationships to storageSasExpander resources. | [optional] [readonly] 
**Siocs** | [**EquipmentSystemIoControllerRelationship[]**](EquipmentSystemIoControllerRelationship.md) | An array of relationships to equipmentSystemIoController resources. | [optional] [readonly] 
**StorageEnclosures** | [**StorageEnclosureRelationship[]**](StorageEnclosureRelationship.md) | An array of relationships to storageEnclosure resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentChassisAllOf  -ChassisId null `
 -ConnectionPath null `
 -ConnectionStatus null `
 -Description null `
 -FaultSummary null `
 -ManagementMode null `
 -Name null `
 -OperState null `
 -PartNumber null `
 -VarPid null `
 -PlatformType null `
 -ProductName null `
 -Sku null `
 -Vid null `
 -Blades null `
 -Fanmodules null `
 -InventoryDeviceInfo null `
 -Ioms null `
 -LocatorLed null `
 -PsuControl null `
 -Psus null `
 -RegisteredDevice null `
 -Sasexpanders null `
 -Siocs null `
 -StorageEnclosures null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

