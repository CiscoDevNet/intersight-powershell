# EquipmentFanModuleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "equipment.FanModule"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "equipment.FanModule"]
**Description** | **String** | This field is to provide description for the fan module. | [optional] [readonly] 
**ModuleId** | **Int64** | This field acts as the identifier for this particular Module, within the Fabric Interconnect. | [optional] [readonly] 
**OperState** | **String** | This field is used to indicate this fan module&#39;s operational state. | [optional] [readonly] 
**PartNumber** | **String** | This field identifies the Part Number for this Fan Module. | [optional] [readonly] 
**VarPid** | **String** | This field identifies the Product ID for the fan module. | [optional] [readonly] 
**Presence** | **String** | This field is used to indicate this fan module&#39;s presence. | [optional] [readonly] 
**Sku** | **String** | This field identifies the Stockkeeping Unit for this Fan Module. | [optional] [readonly] 
**TrayId** | **Int64** | Tray identifier for the fan module. | [optional] [readonly] 
**Vid** | **String** | This field identifies the Vendor ID for this Fan Module. | [optional] [readonly] 
**ComputeRackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**EquipmentChassis** | [**EquipmentChassisRelationship**](EquipmentChassisRelationship.md) |  | [optional] 
**EquipmentRackEnclosure** | [**EquipmentRackEnclosureRelationship**](EquipmentRackEnclosureRelationship.md) |  | [optional] 
**Fans** | [**EquipmentFanRelationship[]**](EquipmentFanRelationship.md) | An array of relationships to equipmentFan resources. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**NetworkElement** | [**NetworkElementRelationship**](NetworkElementRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$EquipmentFanModuleAllOf = Initialize-IntersightEquipmentFanModuleAllOf  -ClassId null `
 -ObjectType null `
 -Description null `
 -ModuleId null `
 -OperState null `
 -PartNumber null `
 -VarPid null `
 -Presence null `
 -Sku null `
 -TrayId null `
 -Vid null `
 -ComputeRackUnit null `
 -EquipmentChassis null `
 -EquipmentRackEnclosure null `
 -Fans null `
 -InventoryDeviceInfo null `
 -NetworkElement null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$EquipmentFanModuleAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

