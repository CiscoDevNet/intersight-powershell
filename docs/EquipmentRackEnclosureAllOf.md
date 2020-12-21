# EquipmentRackEnclosureAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "equipment.RackEnclosure"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "equipment.RackEnclosure"]
**EnclosureId** | **Int64** | This represents the Enclosure Identifier for Rack servers. | [optional] [readonly] 
**Fanmodules** | [**EquipmentFanModuleRelationship[]**](EquipmentFanModuleRelationship.md) | An array of relationships to equipmentFanModule resources. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**Psus** | [**EquipmentPsuRelationship[]**](EquipmentPsuRelationship.md) | An array of relationships to equipmentPsu resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Slots** | [**EquipmentRackEnclosureSlotRelationship[]**](EquipmentRackEnclosureSlotRelationship.md) | An array of relationships to equipmentRackEnclosureSlot resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$EquipmentRackEnclosureAllOf = Initialize-IntersightEquipmentRackEnclosureAllOf  -ClassId null `
 -ObjectType null `
 -EnclosureId null `
 -Fanmodules null `
 -InventoryDeviceInfo null `
 -Psus null `
 -RegisteredDevice null `
 -Slots null
```

- Convert the resource to JSON
```powershell
$EquipmentRackEnclosureAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

