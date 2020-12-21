# EquipmentFexAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "equipment.Fex"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "equipment.Fex"]
**DiscoveryState** | **String** | Discovery state of IO card or fabric extender. | [optional] 
**Fans** | [**EquipmentFanRelationship[]**](EquipmentFanRelationship.md) | An array of relationships to equipmentFan resources. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**Ioms** | [**EquipmentIoCardRelationship[]**](EquipmentIoCardRelationship.md) | An array of relationships to equipmentIoCard resources. | [optional] [readonly] 
**LocatorLed** | [**EquipmentLocatorLedRelationship**](EquipmentLocatorLedRelationship.md) |  | [optional] 
**NetworkElement** | [**NetworkElementRelationship**](NetworkElementRelationship.md) |  | [optional] 
**Psus** | [**EquipmentPsuRelationship[]**](EquipmentPsuRelationship.md) | An array of relationships to equipmentPsu resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$EquipmentFexAllOf = Initialize-IntersightEquipmentFexAllOf  -ClassId null `
 -ObjectType null `
 -DiscoveryState null `
 -Fans null `
 -InventoryDeviceInfo null `
 -Ioms null `
 -LocatorLed null `
 -NetworkElement null `
 -Psus null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$EquipmentFexAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

