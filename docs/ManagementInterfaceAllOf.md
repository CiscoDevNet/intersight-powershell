# ManagementInterfaceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "management.Interface"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "management.Interface"]
**Gateway** | **String** | Default gateway for the interface. | [optional] [readonly] 
**HostName** | **String** | Hostname configured for the interface. | [optional] 
**IpAddress** | **String** | IP address of the interface. | [optional] [readonly] 
**Ipv4Address** | **String** | IPv4 address of the interface. | [optional] [readonly] 
**Ipv4Gateway** | **String** | IPv4 default gateway for the interface. | [optional] [readonly] 
**Ipv4Mask** | **String** | IPv4 Netmask for the interface. | [optional] [readonly] 
**Ipv6Address** | **String** | IPv6 address of the interface. | [optional] 
**Ipv6Gateway** | **String** | IPv6 default gateway for the interface. | [optional] 
**Ipv6Prefix** | **Int64** | IPv6 prefix for the interface. | [optional] 
**MacAddress** | **String** | MAC address configured for the interface. | [optional] [readonly] 
**Mask** | **String** | Netmask for the interface. | [optional] [readonly] 
**SwitchId** | **String** | Switch Id connected to the interface. | [optional] 
**UemConnStatus** | **String** | The event channel connection status for the interface. | [optional] 
**VirtualHostName** | **String** | Virtual hostname configured for the interface in case of clustered environment. | [optional] 
**VlanId** | **Int64** | VlanId configured for the interface. | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**ManagementController** | [**ManagementControllerRelationship**](ManagementControllerRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ManagementInterfaceAllOf = Initialize-IntersightManagementInterfaceAllOf  -ClassId null `
 -ObjectType null `
 -Gateway null `
 -HostName null `
 -IpAddress null `
 -Ipv4Address null `
 -Ipv4Gateway null `
 -Ipv4Mask null `
 -Ipv6Address null `
 -Ipv6Gateway null `
 -Ipv6Prefix null `
 -MacAddress null `
 -Mask null `
 -SwitchId null `
 -UemConnStatus null `
 -VirtualHostName null `
 -VlanId null `
 -InventoryDeviceInfo null `
 -ManagementController null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ManagementInterfaceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

