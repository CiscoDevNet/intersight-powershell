# EquipmentChassisAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "equipment.Chassis"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "equipment.Chassis"]
**AlarmSummary** | [**ComputeAlarmSummary**](ComputeAlarmSummary.md) |  | [optional] 
**ChassisId** | **Int64** | The assigned identifier for a chassis. | [optional] [readonly] 
**ConnectionPath** | **String** | This field identifies the connectivity path for the chassis enclosure. | [optional] [readonly] 
**ConnectionStatus** | **String** | This field identifies the connectivity status for the chassis enclosure. | [optional] [readonly] 
**Description** | **String** | This field is to provide description for chassis model. | [optional] [readonly] 
**FaultSummary** | **Int64** | This field summarizes the faults on the chassis enclosure. | [optional] 
**ManagementMode** | **String** | The management mode of the blade server chassis. * &#x60;IntersightStandalone&#x60; - Intersight Standalone mode of operation. * &#x60;UCSM&#x60; - Unified Computing System Manager mode of operation. * &#x60;Intersight&#x60; - Intersight managed mode of operation. | [optional] [readonly] [default to "IntersightStandalone"]
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
**VirtualDriveContainer** | [**StorageVirtualDriveContainerRelationship[]**](StorageVirtualDriveContainerRelationship.md) | An array of relationships to storageVirtualDriveContainer resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$EquipmentChassisAllOf = Initialize-IntersightEquipmentChassisAllOf  -ClassId null `
 -ObjectType null `
 -AlarmSummary null `
 -ChassisId null `
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
 -StorageEnclosures null `
 -VirtualDriveContainer null
```

- Convert the resource to JSON
```powershell
$EquipmentChassisAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

