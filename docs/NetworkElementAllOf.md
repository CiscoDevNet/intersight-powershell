# NetworkElementAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminEvacState** | **String** | Administratively configured state of Fabric Evacuation feature, for this switch. | [optional] [readonly] 
**AdminInbandInterfaceState** | **String** | The administrative state of the network Element inband management interface. | [optional] [readonly] 
**AvailableMemory** | **String** | Available memory (un-used) on this switch platform. | [optional] [readonly] 
**EthernetMode** | **String** | The user configured Ethernet operational mode for this switch (End-Host or Switching). | [optional] [readonly] 
**FaultSummary** | **Int64** | The fault summary of the network Element out-of-band management interface. | [optional] 
**FcMode** | **String** | The user configured FC operational mode for this switch (End-Host or Switching). | [optional] [readonly] 
**InbandIpAddress** | **String** | The IP address of the network Element inband management interface. | [optional] [readonly] 
**InbandIpGateway** | **String** | The default gateway of the network Element inband management interface. | [optional] [readonly] 
**InbandIpMask** | **String** | The network mask of the network Element inband management interface. | [optional] [readonly] 
**InbandVlan** | **Int64** | The VLAN ID of the network Element inband management interface. | [optional] [readonly] 
**OperEvacState** | **String** | Operational state of the Fabric Evacuation feature, for this switch. | [optional] [readonly] 
**Operability** | **String** | The switch&#39;s current overall operational/health state. | [optional] [readonly] 
**OutOfBandIpAddress** | **String** | The IP address of the network Element out-of-band management interface. | [optional] [readonly] 
**OutOfBandIpGateway** | **String** | The default gateway of the network Element out-of-band management interface. | [optional] [readonly] 
**OutOfBandIpMask** | **String** | The network mask of the network Element out-of-band management interface. | [optional] [readonly] 
**OutOfBandIpv4Address** | **String** | The IPv4 address of the network Element out-of-band management interface. | [optional] [readonly] 
**OutOfBandIpv4Gateway** | **String** | The default IPv4 gateway of the network Element out-of-band management interface. | [optional] [readonly] 
**OutOfBandIpv4Mask** | **String** | The network mask of the network Element out-of-band management interface. | [optional] [readonly] 
**OutOfBandIpv6Address** | **String** | The IPv6 address of the network Element out-of-band management interface. | [optional] 
**OutOfBandIpv6Gateway** | **String** | The default IPv6 gateway of the network Element out-of-band management interface. | [optional] 
**OutOfBandIpv6Prefix** | **String** | The network mask of the network Element out-of-band management interface. | [optional] 
**OutOfBandMac** | **String** | The MAC address of the network Element out-of-band management interface. | [optional] [readonly] 
**SwitchId** | **String** | The Switch Id of the network Element. | [optional] [readonly] 
**TotalMemory** | **Int64** | Total available memory on this switch platform. | [optional] [readonly] 
**Cards** | [**EquipmentSwitchCardRelationship[]**](EquipmentSwitchCardRelationship.md) | An array of relationships to equipmentSwitchCard resources. | [optional] [readonly] 
**Fanmodules** | [**EquipmentFanModuleRelationship[]**](EquipmentFanModuleRelationship.md) | An array of relationships to equipmentFanModule resources. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**ManagementContoller** | [**ManagementControllerRelationship**](ManagementControllerRelationship.md) |  | [optional] 
**ManagementEntity** | [**ManagementEntityRelationship**](ManagementEntityRelationship.md) |  | [optional] 
**NetworkFcZoneInfo** | [**NetworkFcZoneInfoRelationship**](NetworkFcZoneInfoRelationship.md) |  | [optional] 
**NetworkVlanPortInfo** | [**NetworkVlanPortInfoRelationship**](NetworkVlanPortInfoRelationship.md) |  | [optional] 
**PortMacBindings** | [**PortMacBindingRelationship[]**](PortMacBindingRelationship.md) | An array of relationships to portMacBinding resources. | [optional] 
**Psus** | [**EquipmentPsuRelationship[]**](EquipmentPsuRelationship.md) | An array of relationships to equipmentPsu resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StorageItems** | [**StorageItemRelationship[]**](StorageItemRelationship.md) | An array of relationships to storageItem resources. | [optional] [readonly] 
**TopSystem** | [**TopSystemRelationship**](TopSystemRelationship.md) |  | [optional] 
**UcsmRunningFirmware** | [**FirmwareRunningFirmwareRelationship**](FirmwareRunningFirmwareRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNetworkElementAllOf  -AdminEvacState null `
 -AdminInbandInterfaceState null `
 -AvailableMemory null `
 -EthernetMode null `
 -FaultSummary null `
 -FcMode null `
 -InbandIpAddress null `
 -InbandIpGateway null `
 -InbandIpMask null `
 -InbandVlan null `
 -OperEvacState null `
 -Operability null `
 -OutOfBandIpAddress null `
 -OutOfBandIpGateway null `
 -OutOfBandIpMask null `
 -OutOfBandIpv4Address null `
 -OutOfBandIpv4Gateway null `
 -OutOfBandIpv4Mask null `
 -OutOfBandIpv6Address null `
 -OutOfBandIpv6Gateway null `
 -OutOfBandIpv6Prefix null `
 -OutOfBandMac null `
 -SwitchId null `
 -TotalMemory null `
 -Cards null `
 -Fanmodules null `
 -InventoryDeviceInfo null `
 -ManagementContoller null `
 -ManagementEntity null `
 -NetworkFcZoneInfo null `
 -NetworkVlanPortInfo null `
 -PortMacBindings null `
 -Psus null `
 -RegisteredDevice null `
 -StorageItems null `
 -TopSystem null `
 -UcsmRunningFirmware null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

