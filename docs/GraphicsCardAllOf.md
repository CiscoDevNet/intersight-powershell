# GraphicsCardAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardId** | **Int64** | The id of the graphics card. | [optional] [readonly] 
**DeviceId** | **Int64** | The device id of the graphics card. | [optional] [readonly] 
**ExpanderSlot** | **String** | The expander slot information of the card. | [optional] [readonly] 
**FirmwareVersion** | **String** | The firmware version of the graphics card. | [optional] [readonly] 
**Mode** | **String** | The current mode of the graphics card. | [optional] [readonly] 
**NumGpus** | **String** | The number of controllers under each card. | [optional] 
**OperState** | **String** | The current operational state of the graphics card. | [optional] [readonly] 
**PciAddress** | **String** | The PCI address of the graphics card. | [optional] [readonly] 
**PciAddressList** | **String** | This list contains the PCI address of all controllers for corresponding card. | [optional] [readonly] 
**PciSlot** | **String** | The PCI slot name of the graphics card. | [optional] [readonly] 
**ComputeBlade** | [**ComputeBladeRelationship**](ComputeBladeRelationship.md) |  | [optional] 
**ComputeBoard** | [**ComputeBoardRelationship**](ComputeBoardRelationship.md) |  | [optional] 
**ComputeRackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**GraphicsControllers** | [**GraphicsControllerRelationship[]**](GraphicsControllerRelationship.md) | An array of relationships to graphicsController resources. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**RunningFirmware** | [**FirmwareRunningFirmwareRelationship[]**](FirmwareRunningFirmwareRelationship.md) | An array of relationships to firmwareRunningFirmware resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightGraphicsCardAllOf  -CardId null `
 -DeviceId null `
 -ExpanderSlot null `
 -FirmwareVersion null `
 -Mode null `
 -NumGpus null `
 -OperState null `
 -PciAddress null `
 -PciAddressList null `
 -PciSlot null `
 -ComputeBlade null `
 -ComputeBoard null `
 -ComputeRackUnit null `
 -GraphicsControllers null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -RunningFirmware null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

