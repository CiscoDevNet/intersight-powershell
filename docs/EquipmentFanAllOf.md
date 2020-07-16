# EquipmentFanAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** | This field is to provide description for the fan. | [optional] [readonly] 
**FanId** | **Int64** | This field acts as the identifier for this particular Fan, within the Fabric Interconnect. | [optional] [readonly] 
**FanModuleId** | **Int64** | This field is used to identify the Fan Module to which this Fan belongs. | [optional] [readonly] 
**ModuleId** | **Int64** | Fan module Identifier for the fan. | [optional] [readonly] 
**OperState** | **String** | This field is used to indicate this fan unit&#39;s operational state. | [optional] [readonly] 
**PartNumber** | **String** | This field identifies the Part Number for this Fan Unit. | [optional] [readonly] 
**VarPid** | **String** | This field identifies the Product ID for the fans. | [optional] [readonly] 
**Presence** | **String** | This field is used to indicate this fan unit&#39;s presence. | [optional] [readonly] 
**Sku** | **String** | This field identifies the Stockkeeping Unit for this Fan Unit. | [optional] [readonly] 
**TrayId** | **Int64** | Tray identifier for the fan module. | [optional] [readonly] 
**Vid** | **String** | This field identifies the Vendor ID for this Fan Unit. | [optional] [readonly] 
**EquipmentFanModule** | [**EquipmentFanModuleRelationship**](EquipmentFanModuleRelationship.md) |  | [optional] 
**EquipmentFex** | [**EquipmentFexRelationship**](EquipmentFexRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentFanAllOf  -Description null `
 -FanId null `
 -FanModuleId null `
 -ModuleId null `
 -OperState null `
 -PartNumber null `
 -VarPid null `
 -Presence null `
 -Sku null `
 -TrayId null `
 -Vid null `
 -EquipmentFanModule null `
 -EquipmentFex null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

