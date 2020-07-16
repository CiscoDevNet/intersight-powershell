# PciLinkAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Adapter** | **String** | The name of the PCI device. | [optional] [readonly] 
**LinkSpeed** | **String** | The upstream link speed of the PCI device. | [optional] [readonly] 
**LinkStatus** | **String** | The upstream link status of the PCI device. | [optional] [readonly] 
**LinkWidth** | **String** | The upstream link width of the PCI device. | [optional] [readonly] 
**PciSlot** | **String** | The slot name of the PCI device. | [optional] [readonly] 
**SlotStatus** | **String** | The health information of the PCI device. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**PciSwitch** | [**PciSwitchRelationship**](PciSwitchRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightPciLinkAllOf  -Adapter null `
 -LinkSpeed null `
 -LinkStatus null `
 -LinkWidth null `
 -PciSlot null `
 -SlotStatus null `
 -InventoryDeviceInfo null `
 -PciSwitch null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

