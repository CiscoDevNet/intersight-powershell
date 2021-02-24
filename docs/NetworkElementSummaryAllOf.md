# NetworkElementSummaryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "network.ElementSummary"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "network.ElementSummary"]
**AdminEvacState** | **String** | Administratively configured state of Fabric Evacuation feature, for this switch. | [optional] [readonly] 
**AdminInbandInterfaceState** | **String** | The administrative state of the network Element inband management interface. | [optional] [readonly] 
**AlarmSummary** | [**ComputeAlarmSummary**](ComputeAlarmSummary.md) |  | [optional] 
**AvailableMemory** | **String** | Available memory (un-used) on this switch platform. | [optional] [readonly] 
**DeviceMoId** | **String** | The database identifier of the registered device of an object. | [optional] [readonly] 
**Dn** | **String** | The Distinguished Name unambiguously identifies an object in the system. | [optional] [readonly] 
**EthernetMode** | **String** | The user configured Ethernet operational mode for this switch (End-Host or Switching). | [optional] [readonly] 
**EthernetSwitchingMode** | **String** | The user configured Ethernet operational mode for this switch (End-Host or Switching). * &#x60;end-host&#x60; - In end-host mode, the fabric interconnects appear to the upstream devices as end hosts with multiple links.In this mode, the switch does not run Spanning Tree Protocol and avoids loops by following a set of rules for traffic forwarding.In case of ethernet switching mode - Ethernet end-host mode is also known as Ethernet host virtualizer. * &#x60;switch&#x60; - In switch mode, the switch runs Spanning Tree Protocol to avoid loops, and broadcast and multicast packets are handled in the traditional way.This is the traditional switch mode. | [optional] [readonly] [default to "end-host"]
**FaultSummary** | **Int64** | The fault summary of the network Element out-of-band management interface. | [optional] [readonly] 
**FcMode** | **String** | The user configured FC operational mode for this switch (End-Host or Switching). | [optional] [readonly] 
**FcSwitchingMode** | **String** | The user configured FC operational mode for this switch (End-Host or Switching). * &#x60;end-host&#x60; - In end-host mode, the fabric interconnects appear to the upstream devices as end hosts with multiple links.In this mode, the switch does not run Spanning Tree Protocol and avoids loops by following a set of rules for traffic forwarding.In case of ethernet switching mode - Ethernet end-host mode is also known as Ethernet host virtualizer. * &#x60;switch&#x60; - In switch mode, the switch runs Spanning Tree Protocol to avoid loops, and broadcast and multicast packets are handled in the traditional way.This is the traditional switch mode. | [optional] [readonly] [default to "end-host"]
**Firmware** | **String** | Running firmware information. | [optional] [readonly] 
**InbandIpAddress** | **String** | The IP address of the network Element inband management interface. | [optional] [readonly] 
**InbandIpGateway** | **String** | The default gateway of the network Element inband management interface. | [optional] [readonly] 
**InbandIpMask** | **String** | The network mask of the network Element inband management interface. | [optional] [readonly] 
**InbandVlan** | **Int64** | The VLAN ID of the network Element inband management interface. | [optional] [readonly] 
**Ipv4Address** | **String** | IP version 4 address is saved in this property. | [optional] [readonly] 
**ManagementMode** | **String** | The management mode of the fabric interconnect. * &#x60;IntersightStandalone&#x60; - Intersight Standalone mode of operation. * &#x60;UCSM&#x60; - Unified Computing System Manager mode of operation. * &#x60;Intersight&#x60; - Intersight managed mode of operation. | [optional] [readonly] [default to "IntersightStandalone"]
**Model** | **String** | This field identifies the model of the given component. | [optional] [readonly] 
**Name** | **String** | Name of the ElementSummary object is saved in this property. | [optional] [readonly] 
**NumEtherPorts** | **Int64** | Total number of Ethernet ports. | [optional] [readonly] 
**NumEtherPortsConfigured** | **Int64** | Total number of configured Ethernet ports. | [optional] [readonly] 
**NumEtherPortsLinkUp** | **Int64** | Total number of Ethernet ports which are UP. | [optional] [readonly] 
**NumExpansionModules** | **Int64** | Total number of expansion modules. | [optional] [readonly] 
**NumFcPorts** | **Int64** | Total number of FC ports. | [optional] [readonly] 
**NumFcPortsConfigured** | **Int64** | Total number of configured FC ports. | [optional] [readonly] 
**NumFcPortsLinkUp** | **Int64** | Total number of FC ports which are UP. | [optional] [readonly] 
**OperEvacState** | **String** | Operational state of the Fabric Evacuation feature, for this switch. | [optional] [readonly] 
**Operability** | **String** | The switch&#39;s current overall operational/health state. | [optional] [readonly] 
**OutOfBandIpAddress** | **String** | The IP address of the network Element out-of-band management interface. | [optional] [readonly] 
**OutOfBandIpGateway** | **String** | The default gateway of the network Element out-of-band management interface. | [optional] [readonly] 
**OutOfBandIpMask** | **String** | The network mask of the network Element out-of-band management interface. | [optional] [readonly] 
**OutOfBandIpv4Address** | **String** | The IPv4 address of the network Element out-of-band management interface. | [optional] [readonly] 
**OutOfBandIpv4Gateway** | **String** | The default IPv4 gateway of the network Element out-of-band management interface. | [optional] [readonly] 
**OutOfBandIpv4Mask** | **String** | The network mask of the network Element out-of-band management interface. | [optional] [readonly] 
**OutOfBandIpv6Address** | **String** | The IPv6 address of the network Element out-of-band management interface. | [optional] [readonly] 
**OutOfBandIpv6Gateway** | **String** | The default IPv6 gateway of the network Element out-of-band management interface. | [optional] [readonly] 
**OutOfBandIpv6Prefix** | **String** | The network mask of the network Element out-of-band management interface. | [optional] [readonly] 
**OutOfBandMac** | **String** | The MAC address of the network Element out-of-band management interface. | [optional] [readonly] 
**Revision** | **String** | This field identifies the revision of the given component. | [optional] [readonly] 
**Rn** | **String** | The Relative Name uniquely identifies an object within a given context. | [optional] [readonly] 
**Serial** | **String** | This field identifies the serial of the given component. | [optional] [readonly] 
**SourceObjectType** | **String** | The source object type of this view MO. | [optional] [readonly] 
**SwitchId** | **String** | The Switch Id of the network Element. | [optional] [readonly] 
**Thermal** | **String** | The Thermal status of the fabric interconnect. * &#x60;unknown&#x60; - The default state of the sensor (in case no data is received). * &#x60;ok&#x60; - State of the sensor indicating the sensor&#39;s temperature range is okay. * &#x60;upper-non-recoverable&#x60; - State of the sensor indicating that the temperature is extremely high above normal range. * &#x60;upper-critical&#x60; - State of the sensor indicating that the temperature is above normal range. * &#x60;upper-non-critical&#x60; - State of the sensor indicating that the temperature is a little above the normal range. * &#x60;lower-non-critical&#x60; - State of the sensor indicating that the temperature is a little below the normal range. * &#x60;lower-critical&#x60; - State of the sensor indicating that the temperature is below normal range. * &#x60;lower-non-recoverable&#x60; - State of the sensor indicating that the temperature is extremely below normal range. | [optional] [readonly] [default to "unknown"]
**TotalMemory** | **Int64** | Total available memory on this switch platform. | [optional] [readonly] 
**Vendor** | **String** | This field identifies the vendor of the given component. | [optional] [readonly] 
**Version** | **String** | Version holds the firmware version related information. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NetworkElementSummaryAllOf = Initialize-IntersightNetworkElementSummaryAllOf  -ClassId null `
 -ObjectType null `
 -AdminEvacState null `
 -AdminInbandInterfaceState null `
 -AlarmSummary null `
 -AvailableMemory null `
 -DeviceMoId null `
 -Dn null `
 -EthernetMode null `
 -EthernetSwitchingMode null `
 -FaultSummary null `
 -FcMode null `
 -FcSwitchingMode null `
 -Firmware null `
 -InbandIpAddress null `
 -InbandIpGateway null `
 -InbandIpMask null `
 -InbandVlan null `
 -Ipv4Address null `
 -ManagementMode null `
 -Model null `
 -Name null `
 -NumEtherPorts null `
 -NumEtherPortsConfigured null `
 -NumEtherPortsLinkUp null `
 -NumExpansionModules null `
 -NumFcPorts null `
 -NumFcPortsConfigured null `
 -NumFcPortsLinkUp null `
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
 -Revision null `
 -Rn null `
 -Serial null `
 -SourceObjectType null `
 -SwitchId null `
 -Thermal null `
 -TotalMemory null `
 -Vendor null `
 -Version null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NetworkElementSummaryAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

