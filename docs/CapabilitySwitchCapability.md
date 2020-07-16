# CapabilitySwitchCapability
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | a map of display names for a resource. | [optional] [readonly] 
**Name** | **String** | An unique identifer for a capability descriptor. | [optional] 
**Section** | [**CapabilitySectionRelationship**](CapabilitySectionRelationship.md) |  | [optional] 
**VarPid** | **String** | Product Identifier for a Switch/Fabric-Interconnect. | [optional] 
**Sku** | **String** | SKU information for Switch/Fabric-Interconnect. | [optional] 
**Vid** | **String** | VID information for Switch/Fabric-Interconnect. | [optional] 
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
Initialize-IntersightCapabilitySwitchCapability  -AccountMoid null `
 -ClassId null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -ObjectType null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -Name null `
 -Section null `
 -VarPid null `
 -Sku null `
 -Vid null `
 -DefaultFcoeVlan null `
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

