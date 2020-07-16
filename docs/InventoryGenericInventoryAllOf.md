# InventoryGenericInventoryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **String** | Key of inventory data for Generic Inventory data set. | [optional] [readonly] 
**Type** | **String** | Type of inventory data for Generic Inventory data set. | [optional] [readonly] 
**Value** | **String** | Value of inventory data for Generic Inventory data set. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**InventoryGenericInventoryHolder** | [**InventoryGenericInventoryHolderRelationship**](InventoryGenericInventoryHolderRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightInventoryGenericInventoryAllOf  -Key null `
 -Type null `
 -Value null `
 -InventoryDeviceInfo null `
 -InventoryGenericInventoryHolder null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

