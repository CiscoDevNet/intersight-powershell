# PortGroupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "port.Group"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "port.Group"]
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
$PortGroupAllOf = Initialize-IntersightPortGroupAllOf  -ClassId null `
 -ObjectType null `
 -Transport null `
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
$PortGroupAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

