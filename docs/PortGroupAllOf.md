# PortGroupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Transport** | **String** | Type of port group. Values are Eth or Fc. | [optional] [readonly] 
**EquipmentSharedIoModule** | [**EquipmentSharedIoModuleRelationship**](EquipmentSharedIoModuleRelationship.md) |  | [optional] 
**EquipmentSwitchCard** | [**EquipmentSwitchCardRelationship**](EquipmentSwitchCardRelationship.md) |  | [optional] 
**EthernetPorts** | [**EtherPhysicalPortRelationship[]**](EtherPhysicalPortRelationship.md) | An array of relationships to etherPhysicalPort resources. | [optional] [readonly] 
**FcPorts** | [**FcPhysicalPortRelationship[]**](FcPhysicalPortRelationship.md) | An array of relationships to fcPhysicalPort resources. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**SubGroups** | [**PortSubGroupRelationship[]**](PortSubGroupRelationship.md) | An array of relationships to portSubGroup resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightPortGroupAllOf  -Transport null `
 -EquipmentSharedIoModule null `
 -EquipmentSwitchCard null `
 -EthernetPorts null `
 -FcPorts null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -SubGroups null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

