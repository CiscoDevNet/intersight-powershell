# CapabilitySwitchNetworkLimits
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.SwitchNetworkLimits"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.SwitchNetworkLimits"]
**MaxCompressedPortVlanCount** | **Int64** | Maximum Compressed configurable VLANs on Switch/Fabric-Interconnect. | [optional] 
**MaxUncompressedPortVlanCount** | **Int64** | Maximum configurable VLANs on Switch/Fabric-Interconnect. | [optional] 
**MaximumActiveTrafficMonitoringSessions** | **Int64** | Maximum configured and enabled Traffic Monitoring sessions on this Switch/Fabric-Interconnect. | [optional] 
**MaximumEthernetPortChannels** | **Int64** | Maximum configurable Ethernet port-channels on Switch/Fabric-Interconnect. | [optional] 
**MaximumEthernetUplinkPorts** | **Int64** | Maximum configurable Ethernet Uplink ports on Switch/Fabric-Interconnect. | [optional] 
**MaximumFcPortChannelMembers** | **Int64** | Maximum configurable Fibre Channel port-channel member ports on Switch/Fabric-Interconnect. | [optional] 
**MaximumFcPortChannels** | **Int64** | Maximum configurable Fibre Channel port-channels on Switch/Fabric-Interconnect. | [optional] 
**MaximumIgmpGroups** | **Int64** | Maximum configurable IGMP Groups on Switch/Fabric-Interconnect. | [optional] 
**MaximumPortChannelMembers** | **Int64** | Maximum configurable ports per each port-channel on Switch/Fabric-Interconnect. | [optional] 
**MaximumPrimaryVlan** | **Int64** | Maximum configurable Primary Private VLANs on Switch/Fabric-Interconnect. | [optional] 
**MaximumSecondaryVlan** | **Int64** | Maximum configurable Secondary Private VLANs on Switch/Fabric-Interconnect. | [optional] 
**MaximumSecondaryVlanPerPrimary** | **Int64** | Maximum configurable Secondary VLANs per each Primary VLAN on Switch/Fabric-Interconnect. | [optional] 
**MaximumVifs** | **Int64** | Maximum allowes VIFs on Switch/Fabric-Interconnect. | [optional] 
**MaximumVlans** | **Int64** | Maximum configurable VLANs on Switch/Fabric-Interconnect. | [optional] 
**MinimumActiveFans** | **Int64** | Minimum required fans in &#39;active&#39; state for this Switch/Fabric-Interconnect. | [optional] 

## Examples

- Prepare the resource
```powershell
$CapabilitySwitchNetworkLimits = Initialize-IntersightCapabilitySwitchNetworkLimits  -ClassId null `
 -ObjectType null `
 -MaxCompressedPortVlanCount null `
 -MaxUncompressedPortVlanCount null `
 -MaximumActiveTrafficMonitoringSessions null `
 -MaximumEthernetPortChannels null `
 -MaximumEthernetUplinkPorts null `
 -MaximumFcPortChannelMembers null `
 -MaximumFcPortChannels null `
 -MaximumIgmpGroups null `
 -MaximumPortChannelMembers null `
 -MaximumPrimaryVlan null `
 -MaximumSecondaryVlan null `
 -MaximumSecondaryVlanPerPrimary null `
 -MaximumVifs null `
 -MaximumVlans null `
 -MinimumActiveFans null
```

- Convert the resource to JSON
```powershell
$CapabilitySwitchNetworkLimits | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

