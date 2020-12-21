# PortSubGroupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "port.SubGroup"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "port.SubGroup"]
**Transport** | **String** | Type of port sub-group. Values are Eth or Fc. | [optional] [readonly] 
**EthernetPorts** | [**EtherPhysicalPortRelationship[]**](EtherPhysicalPortRelationship.md) | An array of relationships to etherPhysicalPort resources. | [optional] [readonly] 
**FcPorts** | [**FcPhysicalPortRelationship[]**](FcPhysicalPortRelationship.md) | An array of relationships to fcPhysicalPort resources. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**PortGroup** | [**PortGroupRelationship**](PortGroupRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$PortSubGroupAllOf = Initialize-IntersightPortSubGroupAllOf  -ClassId null `
 -ObjectType null `
 -Transport null `
 -EthernetPorts null `
 -FcPorts null `
 -InventoryDeviceInfo null `
 -PortGroup null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$PortSubGroupAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

