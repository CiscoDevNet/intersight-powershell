# EquipmentPsuAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** | This field is to provide description for the power supply unit. | [optional] [readonly] 
**OperState** | **String** | This field identifies the psu operational state. | [optional] [readonly] 
**PartNumber** | **String** | This field identifies the Part Number for this Power Supply Unit. | [optional] [readonly] 
**VarPid** | **String** | This field identifies the Product ID for the Power Supply. | [optional] [readonly] 
**Presence** | **String** | This field identifies the presence state of the psu. | [optional] [readonly] 
**PsuFwVersion** | **String** | This field identifies the Firmware Version of the Power Supply. | [optional] [readonly] 
**PsuId** | **Int64** | This represents power supply unit identifier in chassis/server. | [optional] [readonly] 
**PsuInputSrc** | **String** | This field identifies the input source for the Power Supply. | [optional] [readonly] 
**PsuType** | **String** | This field identifies the type of the Power Supply. | [optional] [readonly] 
**PsuWattage** | **String** | This field identifies the Wattage of the Power Supply. | [optional] [readonly] 
**Sku** | **String** | This field identifies the Stockkeeping Unit for this Power Supply. | [optional] [readonly] 
**Vid** | **String** | This field identifies the Vendor ID for this Power Supply Unit. | [optional] [readonly] 
**Voltage** | **String** | This field is used to indicate the Voltage for this Power Supply. | [optional] [readonly] 
**ComputeRackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**EquipmentChassis** | [**EquipmentChassisRelationship**](EquipmentChassisRelationship.md) |  | [optional] 
**EquipmentFex** | [**EquipmentFexRelationship**](EquipmentFexRelationship.md) |  | [optional] 
**EquipmentRackEnclosure** | [**EquipmentRackEnclosureRelationship**](EquipmentRackEnclosureRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**NetworkElement** | [**NetworkElementRelationship**](NetworkElementRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentPsuAllOf  -Description null `
 -OperState null `
 -PartNumber null `
 -VarPid null `
 -Presence null `
 -PsuFwVersion null `
 -PsuId null `
 -PsuInputSrc null `
 -PsuType null `
 -PsuWattage null `
 -Sku null `
 -Vid null `
 -Voltage null `
 -ComputeRackUnit null `
 -EquipmentChassis null `
 -EquipmentFex null `
 -EquipmentRackEnclosure null `
 -InventoryDeviceInfo null `
 -NetworkElement null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

