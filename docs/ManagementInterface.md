# ManagementInterface
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
**DeviceMoId** | **String** | The database identifier of the registered device of an object. | [optional] [readonly] 
**Dn** | **String** | The Distinguished Name unambiguously identifies an object in the system. | [optional] [readonly] 
**Rn** | **String** | The Relative Name uniquely identifies an object within a given context. | [optional] [readonly] 
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
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**ManagementController** | [**ManagementControllerRelationship**](ManagementControllerRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightManagementInterface  -AccountMoid null `
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
 -DeviceMoId null `
 -Dn null `
 -Rn null `
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
 -InventoryDeviceInfo null `
 -ManagementController null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

