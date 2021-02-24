# CapabilitySwitchCapability
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.SwitchCapability"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.SwitchCapability"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Var0ClusterReplicationNetworkPolicy** | [**HyperflexClusterReplicationNetworkPolicyRelationship**](HyperflexClusterReplicationNetworkPolicyRelationship.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**Name** | **String** | An unique identifer for a capability descriptor. | [optional] 
**VarPid** | **String** | Product Identifier for a Switch/Fabric-Interconnect. * &#x60;UCS-FI-6454&#x60; - The standard 4th generation UCS Fabric Interconnect with 54 ports. * &#x60;UCS-FI-64108&#x60; - The expanded 4th generation UCS Fabric Interconnect with 108 ports. * &#x60;unknown&#x60; - Unknown device type, usage is TBD. | [optional] [default to "UCS-FI-6454"]
**Sku** | **String** | SKU information for Switch/Fabric-Interconnect. | [optional] 
**Vid** | **String** | VID information for Switch/Fabric-Interconnect. | [optional] 
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
$CapabilitySwitchCapability = Initialize-IntersightCapabilitySwitchCapability  -ClassId null `
 -ObjectType null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Moid null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Var0ClusterReplicationNetworkPolicy null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -Name null `
 -VarPid null `
 -Sku null `
 -Vid null `
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
$CapabilitySwitchCapability | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

