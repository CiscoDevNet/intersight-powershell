# EquipmentIoExpanderAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OperState** | **String** | Identifies the operational state of I/O expander. | [optional] [readonly] 
**Presence** | **String** | Identifies the availability of I/O expander. | [optional] [readonly] 
**ComputeBlade** | [**ComputeBladeRelationship**](ComputeBladeRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentIoExpanderAllOf  -OperState null `
 -Presence null `
 -ComputeBlade null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

