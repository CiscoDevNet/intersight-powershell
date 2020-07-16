# PciCoprocessorCardAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardId** | **Int64** | The id of the coprocessor card. | [optional] [readonly] 
**PciSlot** | **String** | The PCI slot name for the coprocessor card. | [optional] [readonly] 
**ComputeBoard** | [**ComputeBoardRelationship**](ComputeBoardRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightPciCoprocessorCardAllOf  -CardId null `
 -PciSlot null `
 -ComputeBoard null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

