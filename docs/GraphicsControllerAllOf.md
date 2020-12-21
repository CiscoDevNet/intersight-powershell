# GraphicsControllerAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "graphics.Controller"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "graphics.Controller"]
**ControllerId** | **Int64** | The id of the graphics controller. | [optional] [readonly] 
**PciAddr** | **String** | The PCI address of the graphics controller. | [optional] [readonly] 
**PciSlot** | **String** | The PCI slot information of the graphics controller. | [optional] [readonly] 
**GraphicsCard** | [**GraphicsCardRelationship**](GraphicsCardRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$GraphicsControllerAllOf = Initialize-IntersightGraphicsControllerAllOf  -ClassId null `
 -ObjectType null `
 -ControllerId null `
 -PciAddr null `
 -PciSlot null `
 -GraphicsCard null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$GraphicsControllerAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

