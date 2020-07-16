# NetworkElementSummary
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
**AdminEvacState** | **String** | Administratively configured state of Fabric Evacuation feature, for this switch. | [optional] [readonly] 
**AdminInbandInterfaceState** | **String** | The administrative state of the network Element inband management interface. | [optional] [readonly] 
**AvailableMemory** | **String** | Available memory (un-used) on this switch platform. | [optional] [readonly] 
**DeviceMoId** | **String** | The database identifier of the registered device of an object. | [optional] [readonly] 
**Dn** | **String** | The Distinguished Name unambiguously identifies an object in the system. | [optional] [readonly] 
**EthernetMode** | **String** | The user configured Ethernet operational mode for this switch (End-Host or Switching). | [optional] [readonly] 
**FaultSummary** | **Int64** | The fault summary of the network Element out-of-band management interface. | [optional] [readonly] 
**FcMode** | **String** | The user configured FC operational mode for this switch (End-Host or Switching). | [optional] [readonly] 
**Firmware** | **String** | Running firmware information. | [optional] [readonly] 
**InbandIpAddress** | **String** | The IP address of the network Element inband management interface. | [optional] [readonly] 
**InbandIpGateway** | **String** | The default gateway of the network Element inband management interface. | [optional] [readonly] 
**InbandIpMask** | **String** | The network mask of the network Element inband management interface. | [optional] [readonly] 
**InbandVlan** | **Int64** | The VLAN ID of the network Element inband management interface. | [optional] [readonly] 
**Ipv4Address** | **String** | IP version 4 address is saved in this property. | [optional] [readonly] 
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
**TotalMemory** | **Int64** | Total available memory on this switch platform. | [optional] [readonly] 
**Vendor** | **String** | This field identifies the vendor of the given component. | [optional] [readonly] 
**Version** | **String** | Version holds the firmware version related information. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNetworkElementSummary  -AccountMoid null `
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
 -AdminEvacState null `
 -AdminInbandInterfaceState null `
 -AvailableMemory null `
 -DeviceMoId null `
 -Dn null `
 -EthernetMode null `
 -FaultSummary null `
 -FcMode null `
 -Firmware null `
 -InbandIpAddress null `
 -InbandIpGateway null `
 -InbandIpMask null `
 -InbandVlan null `
 -Ipv4Address null `
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
 -TotalMemory null `
 -Vendor null `
 -Version null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

