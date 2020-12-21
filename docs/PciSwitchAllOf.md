# PciSwitchAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "pci.Switch"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "pci.Switch"]
**DeviceId** | **String** | The device id of the switch. | [optional] [readonly] 
**Health** | **String** | The composite health of the switch. | [optional] [readonly] 
**NumOfAdaptors** | **String** | The number of GPUs and PCI adapters connected the switch. | [optional] [readonly] 
**PciAddress** | **String** | The PCI address of the switch. | [optional] [readonly] 
**PciSlot** | **String** | The PCI slot name of the switch. | [optional] [readonly] 
**ProductName** | **String** | The model information for the switch. | [optional] [readonly] 
**ProductRevision** | **String** | The product revision of the switch. | [optional] [readonly] 
**SubDeviceId** | **String** | The sub device id of the switch. | [optional] [readonly] 
**SubVendorId** | **String** | The sub vendor id of the switch. | [optional] [readonly] 
**Temperature** | **String** | The current temperature of the switch. | [optional] [readonly] 
**Type** | **String** | The type information of the switch. | [optional] 
**VendorId** | **String** | The vendor id of the switch. | [optional] [readonly] 
**ComputeBoard** | [**ComputeBoardRelationship**](ComputeBoardRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**Links** | [**PciLinkRelationship[]**](PciLinkRelationship.md) | An array of relationships to pciLink resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**RunningFirmware** | [**FirmwareRunningFirmwareRelationship[]**](FirmwareRunningFirmwareRelationship.md) | An array of relationships to firmwareRunningFirmware resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$PciSwitchAllOf = Initialize-IntersightPciSwitchAllOf  -ClassId null `
 -ObjectType null `
 -DeviceId null `
 -Health null `
 -NumOfAdaptors null `
 -PciAddress null `
 -PciSlot null `
 -ProductName null `
 -ProductRevision null `
 -SubDeviceId null `
 -SubVendorId null `
 -Temperature null `
 -Type null `
 -VendorId null `
 -ComputeBoard null `
 -InventoryDeviceInfo null `
 -Links null `
 -RegisteredDevice null `
 -RunningFirmware null
```

- Convert the resource to JSON
```powershell
$PciSwitchAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

