# EquipmentRackEnclosureSlotAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RackId** | **Int64** | Server ID which is part of Rack Enclosure Slot. | [optional] [readonly] 
**RackUnitDn** | **String** | Server DN which is part of Rack Enclosure Slot. | [optional] [readonly] 
**EquipmentRackEnclosure** | [**EquipmentRackEnclosureRelationship**](EquipmentRackEnclosureRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentRackEnclosureSlotAllOf  -RackId null `
 -RackUnitDn null `
 -EquipmentRackEnclosure null `
 -InventoryDeviceInfo null `
 -RackUnit null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

