# EquipmentIoExpanderAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "equipment.IoExpander"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "equipment.IoExpander"]
**OperState** | **String** | Identifies the operational state of I/O expander. | [optional] [readonly] 
**Presence** | **String** | Identifies the availability of I/O expander. | [optional] [readonly] 
**ComputeBlade** | [**ComputeBladeRelationship**](ComputeBladeRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$EquipmentIoExpanderAllOf = Initialize-IntersightEquipmentIoExpanderAllOf  -ClassId null `
 -ObjectType null `
 -OperState null `
 -Presence null `
 -ComputeBlade null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$EquipmentIoExpanderAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

