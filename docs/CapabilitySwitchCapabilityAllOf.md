# CapabilitySwitchCapabilityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DefaultFcoeVlan** | **Int64** | Default Fcoe VLAN associated with this switch. | [optional] 
**DynamicVifsSupported** | **Boolean** | Dynamic VIFs support on this switch. | [optional] 
**FanModulesSupported** | **Boolean** | Fan Modules support on this switch. | [optional] 
**FcEndHostModeReservedVsans** | [**CapabilityPortRange[]**](CapabilityPortRange.md) |  | [optional] 
**FcUplinkPortsAutoNegotiationSupported** | **Boolean** | Fc Uplink ports auto negotiation speed support on this switch. | [optional] 
**LocatorBeaconSupported** | **Boolean** | Locator Beacon LED support on this switch. | [optional] 
**MaxActiveSpanSessions** | **Int64** | Maximum allowed Traffic Monitoring (SPAN) sessions on this switch. | [optional] 
**MaxEthernetPortChannelMembers** | **Int64** | Maximum allowed Ethernet Uplink Port-channel members for each Uplink Port-channel on this switch. | [optional] 
**MaxEthernetPortChannels** | **Int64** | Maximum allowed Ethernet Uplink Port-channels on this switch. | [optional] 
**MaxEthernetUplinkPorts** | **Int64** | Maximum allowed Ethernet Uplink Ports on this switch. | [optional] 
**MaxFcFcoePortChannels** | **Int64** | Total maximum Fc and Fcoe Port-channels allowed on this switch. | [optional] 
**MaxFcPortChannelMembers** | **Int64** | Maximum allowed FC Uplink Port-channel members for each FCoE Port-channel on this switch. | [optional] 
**MaxFcoePortChannelMembers** | **Int64** | Maximum allowed FCoE Uplink Port-channel members for each FCoE Port-channel on this switch. | [optional] 
**MaxPorts** | **Int64** | Maximum allowed physical ports on this switch. | [optional] 
**MaxSlots** | **Int64** | Maximum allowed physical slots on this switch. | [optional] 
**MaxVsansSupported** | **Int64** | Maximum number of Vsans supported on this switch. | [optional] 
**MinActiveFans** | **Int64** | Minimum number of fans needed to be active/running on this switch. | [optional] 
**PortsSupporting100gSpeed** | [**CapabilityPortRange[]**](CapabilityPortRange.md) |  | [optional] 
**PortsSupporting10gSpeed** | [**CapabilityPortRange[]**](CapabilityPortRange.md) |  | [optional] 
**PortsSupporting1gSpeed** | [**CapabilityPortRange[]**](CapabilityPortRange.md) |  | [optional] 
**PortsSupporting25gSpeed** | [**CapabilityPortRange[]**](CapabilityPortRange.md) |  | [optional] 
**PortsSupporting40gSpeed** | [**CapabilityPortRange[]**](CapabilityPortRange.md) |  | [optional] 
**PortsSupportingBreakout** | [**CapabilityPortRange[]**](CapabilityPortRange.md) |  | [optional] 
**PortsSupportingFcoe** | [**CapabilityPortRange[]**](CapabilityPortRange.md) |  | [optional] 
**PortsSupportingServerRole** | [**CapabilityPortRange[]**](CapabilityPortRange.md) |  | [optional] 
**ReservedVsans** | [**CapabilityPortRange[]**](CapabilityPortRange.md) |  | [optional] 
**SerenoNetflowSupported** | **Boolean** | Sereno Adaptor with Netflow support on this switch. | [optional] 
**UnifiedPorts** | [**CapabilityPortRange[]**](CapabilityPortRange.md) |  | [optional] 
**UnifiedRule** | **String** | The Slider rule for Unified ports on this switch. | [optional] 
**VpCompressionSupported** | **Boolean** | VP Compression support on this switch. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCapabilitySwitchCapabilityAllOf  -DefaultFcoeVlan null `
 -DynamicVifsSupported null `
 -FanModulesSupported null `
 -FcEndHostModeReservedVsans null `
 -FcUplinkPortsAutoNegotiationSupported null `
 -LocatorBeaconSupported null `
 -MaxActiveSpanSessions null `
 -MaxEthernetPortChannelMembers null `
 -MaxEthernetPortChannels null `
 -MaxEthernetUplinkPorts null `
 -MaxFcFcoePortChannels null `
 -MaxFcPortChannelMembers null `
 -MaxFcoePortChannelMembers null `
 -MaxPorts null `
 -MaxSlots null `
 -MaxVsansSupported null `
 -MinActiveFans null `
 -PortsSupporting100gSpeed null `
 -PortsSupporting10gSpeed null `
 -PortsSupporting1gSpeed null `
 -PortsSupporting25gSpeed null `
 -PortsSupporting40gSpeed null `
 -PortsSupportingBreakout null `
 -PortsSupportingFcoe null `
 -PortsSupportingServerRole null `
 -ReservedVsans null `
 -SerenoNetflowSupported null `
 -UnifiedPorts null `
 -UnifiedRule null `
 -VpCompressionSupported null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

