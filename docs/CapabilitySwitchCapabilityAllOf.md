# CapabilitySwitchCapabilityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.SwitchCapability"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.SwitchCapability"]
**DefaultFcoeVlan** | **Int64** | Default Fcoe VLAN associated with this switch. | [optional] 
**DynamicVifsSupported** | **Boolean** | Dynamic VIFs support on this switch. | [optional] 
**FanModulesSupported** | **Boolean** | Fan Modules support on this switch. | [optional] 
**FcEndHostModeReservedVsans** | [**CapabilityPortRange[]**](CapabilityPortRange.md) |  | [optional] 
**FcUplinkPortsAutoNegotiationSupported** | **Boolean** | Fc Uplink ports auto negotiation speed support on this switch. | [optional] 
**LocatorBeaconSupported** | **Boolean** | Locator Beacon LED support on this switch. | [optional] 
**MaxPorts** | **Int64** | Maximum allowed physical ports on this switch. | [optional] 
**MaxSlots** | **Int64** | Maximum allowed physical slots on this switch. | [optional] 
**NetworkLimits** | [**CapabilitySwitchNetworkLimits**](CapabilitySwitchNetworkLimits.md) |  | [optional] 
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
**StorageLimits** | [**CapabilitySwitchStorageLimits**](CapabilitySwitchStorageLimits.md) |  | [optional] 
**SwitchingModeCapabilities** | [**CapabilitySwitchingModeCapability[]**](CapabilitySwitchingModeCapability.md) |  | [optional] 
**SystemLimits** | [**CapabilitySwitchSystemLimits**](CapabilitySwitchSystemLimits.md) |  | [optional] 
**UnifiedPorts** | [**CapabilityPortRange[]**](CapabilityPortRange.md) |  | [optional] 
**UnifiedRule** | **String** | The Slider rule for Unified ports on this switch. | [optional] 

## Examples

- Prepare the resource
```powershell
$CapabilitySwitchCapabilityAllOf = Initialize-IntersightCapabilitySwitchCapabilityAllOf  -ClassId null `
 -ObjectType null `
 -DefaultFcoeVlan null `
 -DynamicVifsSupported null `
 -FanModulesSupported null `
 -FcEndHostModeReservedVsans null `
 -FcUplinkPortsAutoNegotiationSupported null `
 -LocatorBeaconSupported null `
 -MaxPorts null `
 -MaxSlots null `
 -NetworkLimits null `
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
 -StorageLimits null `
 -SwitchingModeCapabilities null `
 -SystemLimits null `
 -UnifiedPorts null `
 -UnifiedRule null
```

- Convert the resource to JSON
```powershell
$CapabilitySwitchCapabilityAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

