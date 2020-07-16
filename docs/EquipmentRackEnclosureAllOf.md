# EquipmentRackEnclosureAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnclosureId** | **Int64** | This represents the Enclosure Identifier for Rack servers. | [optional] [readonly] 
**Fanmodules** | [**EquipmentFanModuleRelationship[]**](EquipmentFanModuleRelationship.md) | An array of relationships to equipmentFanModule resources. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**Psus** | [**EquipmentPsuRelationship[]**](EquipmentPsuRelationship.md) | An array of relationships to equipmentPsu resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Slots** | [**EquipmentRackEnclosureSlotRelationship[]**](EquipmentRackEnclosureSlotRelationship.md) | An array of relationships to equipmentRackEnclosureSlot resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentRackEnclosureAllOf  -EnclosureId null `
 -Fanmodules null `
 -InventoryDeviceInfo null `
 -Psus null `
 -RegisteredDevice null `
 -Slots null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

