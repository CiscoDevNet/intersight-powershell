# EquipmentSwitchCardAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "equipment.SwitchCard"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "equipment.SwitchCard"]
**Description** | **String** | Detailed description of this switch hardware. | [optional] [readonly] 
**EthernetSwitchingMode** | **String** | The user configured Ethernet switching mode for this switch (End-Host or Switch). * &#x60;end-host&#x60; - In end-host mode, the fabric interconnects appear to the upstream devices as end hosts with multiple links.In this mode, the switch does not run Spanning Tree Protocol and avoids loops by following a set of rules for traffic forwarding.In case of ethernet switching mode - Ethernet end-host mode is also known as Ethernet host virtualizer. * &#x60;switch&#x60; - In switch mode, the switch runs Spanning Tree Protocol to avoid loops, and broadcast and multicast packets are handled in the traditional way.This is the traditional switch mode. | [optional] [readonly] [default to "end-host"]
**FcSwitchingMode** | **String** | The user configured FC switching mode for this switch (End-Host or Switch). * &#x60;end-host&#x60; - In end-host mode, the fabric interconnects appear to the upstream devices as end hosts with multiple links.In this mode, the switch does not run Spanning Tree Protocol and avoids loops by following a set of rules for traffic forwarding.In case of ethernet switching mode - Ethernet end-host mode is also known as Ethernet host virtualizer. * &#x60;switch&#x60; - In switch mode, the switch runs Spanning Tree Protocol to avoid loops, and broadcast and multicast packets are handled in the traditional way.This is the traditional switch mode. | [optional] [readonly] [default to "end-host"]
**NumPorts** | **Int64** | Number of ports present in this switch hardware. | [optional] [readonly] 
**OutOfBandIpAddress** | **String** | Field specifies this Switch&#39;s Out-of-band IP address. | [optional] [readonly] 
**OutOfBandIpGateway** | **String** | Field specifies this Switch&#39;s default gateway for the out-of-band management interface. | [optional] [readonly] 
**Presence** | **String** | Presence for this switch hardware. | [optional] [readonly] 
**SlotId** | **Int64** | Slot identifier of the local Switch slot Interface. | [optional] [readonly] 
**State** | **String** | Operational state of the switch hardware. | [optional] [readonly] 
**SwitchId** | **String** | Switch Identifier that is local to a cluster. | [optional] [readonly] 
**Thermal** | **String** | The Thermal status of the fabric interconnect. * &#x60;unknown&#x60; - The default state of the sensor (in case no data is received). * &#x60;ok&#x60; - State of the sensor indicating the sensor&#39;s temperature range is okay. * &#x60;upper-non-recoverable&#x60; - State of the sensor indicating that the temperature is extremely high above normal range. * &#x60;upper-critical&#x60; - State of the sensor indicating that the temperature is above normal range. * &#x60;upper-non-critical&#x60; - State of the sensor indicating that the temperature is a little above the normal range. * &#x60;lower-non-critical&#x60; - State of the sensor indicating that the temperature is a little below the normal range. * &#x60;lower-critical&#x60; - State of the sensor indicating that the temperature is below normal range. * &#x60;lower-non-recoverable&#x60; - State of the sensor indicating that the temperature is extremely below normal range. | [optional] [default to "unknown"]
**FcPortChannels** | [**FcPortChannelRelationship[]**](FcPortChannelRelationship.md) | An array of relationships to fcPortChannel resources. | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**NetworkElement** | [**NetworkElementRelationship**](NetworkElementRelationship.md) |  | [optional] 
**PortChannels** | [**EtherPortChannelRelationship[]**](EtherPortChannelRelationship.md) | An array of relationships to etherPortChannel resources. | [optional] 
**PortGroups** | [**PortGroupRelationship[]**](PortGroupRelationship.md) | An array of relationships to portGroup resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$EquipmentSwitchCardAllOf = Initialize-IntersightEquipmentSwitchCardAllOf  -ClassId null `
 -ObjectType null `
 -Description null `
 -EthernetSwitchingMode null `
 -FcSwitchingMode null `
 -NumPorts null `
 -OutOfBandIpAddress null `
 -OutOfBandIpGateway null `
 -Presence null `
 -SlotId null `
 -State null `
 -SwitchId null `
 -Thermal null `
 -FcPortChannels null `
 -InventoryDeviceInfo null `
 -NetworkElement null `
 -PortChannels null `
 -PortGroups null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$EquipmentSwitchCardAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

