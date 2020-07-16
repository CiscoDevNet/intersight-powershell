# SecurityUnitAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OperState** | **String** | Operational state of the security unit. | [optional] [readonly] 
**Operability** | **String** | Operability state of the security unit. | [optional] [readonly] 
**PartNumber** | **String** | The part number of the security unit. | [optional] [readonly] 
**PciSlot** | **String** | PCIe slot of the security unit in the server. | [optional] [readonly] 
**Power** | **String** | Power state of the security unit. | [optional] [readonly] 
**Presence** | **String** | Security unit presence (equipped) or absence. | [optional] [readonly] 
**Thermal** | **String** | Thermal state of the security unit. | [optional] [readonly] 
**UnitId** | **Int64** | The unique identifier assigned to the security unit within the server. | [optional] [readonly] 
**Vid** | **String** | The vendor identifier of the security unit. | [optional] [readonly] 
**Voltage** | **String** | The voltage state of the security unit. | [optional] [readonly] 
**ComputeBoard** | [**ComputeBoardRelationship**](ComputeBoardRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSecurityUnitAllOf  -OperState null `
 -Operability null `
 -PartNumber null `
 -PciSlot null `
 -Power null `
 -Presence null `
 -Thermal null `
 -UnitId null `
 -Vid null `
 -Voltage null `
 -ComputeBoard null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

