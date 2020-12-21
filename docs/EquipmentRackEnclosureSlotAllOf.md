# EquipmentRackEnclosureSlotAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "equipment.RackEnclosureSlot"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "equipment.RackEnclosureSlot"]
**RackId** | **Int64** | Server ID which is part of Rack Enclosure Slot. | [optional] [readonly] 
**RackUnitDn** | **String** | Server DN which is part of Rack Enclosure Slot. | [optional] [readonly] 
**EquipmentRackEnclosure** | [**EquipmentRackEnclosureRelationship**](EquipmentRackEnclosureRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$EquipmentRackEnclosureSlotAllOf = Initialize-IntersightEquipmentRackEnclosureSlotAllOf  -ClassId null `
 -ObjectType null `
 -RackId null `
 -RackUnitDn null `
 -EquipmentRackEnclosure null `
 -InventoryDeviceInfo null `
 -RackUnit null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$EquipmentRackEnclosureSlotAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

