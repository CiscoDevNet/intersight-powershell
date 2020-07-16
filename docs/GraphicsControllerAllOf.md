# GraphicsControllerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ControllerId** | **Int64** | The id of the graphics controller. | [optional] [readonly] 
**PciAddr** | **String** | The PCI address of the graphics controller. | [optional] [readonly] 
**PciSlot** | **String** | The PCI slot information of the graphics controller. | [optional] [readonly] 
**GraphicsCard** | [**GraphicsCardRelationship**](GraphicsCardRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightGraphicsControllerAllOf  -ControllerId null `
 -PciAddr null `
 -PciSlot null `
 -GraphicsCard null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

