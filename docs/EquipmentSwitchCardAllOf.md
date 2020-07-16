# EquipmentSwitchCardAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** | Detailed description of this switch hardware. | [optional] [readonly] 
**NumPorts** | **Int64** | Number of ports present in this switch hardware. | [optional] [readonly] 
**OutOfBandIpAddress** | **String** | Field specifies this Switch&#39;s Out-of-band IP address. | [optional] [readonly] 
**OutOfBandIpGateway** | **String** | Field specifies this Switch&#39;s default gateway for the out-of-band management interface. | [optional] [readonly] 
**Presence** | **String** | Presence for this switch hardware. | [optional] [readonly] 
**SlotId** | **Int64** | Slot identifier of the local Switch slot Interface. | [optional] [readonly] 
**State** | **String** | Operational state of the switch hardware. | [optional] [readonly] 
**SwitchId** | **String** | Switch Identifier that is local to a cluster. | [optional] [readonly] 
**FcPortChannels** | [**FcPortChannelRelationship[]**](FcPortChannelRelationship.md) | An array of relationships to fcPortChannel resources. | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**NetworkElement** | [**NetworkElementRelationship**](NetworkElementRelationship.md) |  | [optional] 
**PortChannels** | [**EtherPortChannelRelationship[]**](EtherPortChannelRelationship.md) | An array of relationships to etherPortChannel resources. | [optional] 
**PortGroups** | [**PortGroupRelationship[]**](PortGroupRelationship.md) | An array of relationships to portGroup resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentSwitchCardAllOf  -Description null `
 -NumPorts null `
 -OutOfBandIpAddress null `
 -OutOfBandIpGateway null `
 -Presence null `
 -SlotId null `
 -State null `
 -SwitchId null `
 -FcPortChannels null `
 -InventoryDeviceInfo null `
 -NetworkElement null `
 -PortChannels null `
 -PortGroups null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

