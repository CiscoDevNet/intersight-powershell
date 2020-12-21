# PciDeviceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "pci.Device"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "pci.Device"]
**FirmwareVersion** | **String** | The running firmware version of the PCI device. | [optional] 
**VarPid** | **String** | The product identifier of the PCI device. | [optional] 
**SlotId** | **String** | The PCI slot id of the PCI device. | [optional] [readonly] 
**ComputeBlade** | [**ComputeBladeRelationship**](ComputeBladeRelationship.md) |  | [optional] 
**ComputeRackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$PciDeviceAllOf = Initialize-IntersightPciDeviceAllOf  -ClassId null `
 -ObjectType null `
 -FirmwareVersion null `
 -VarPid null `
 -SlotId null `
 -ComputeBlade null `
 -ComputeRackUnit null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$PciDeviceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

