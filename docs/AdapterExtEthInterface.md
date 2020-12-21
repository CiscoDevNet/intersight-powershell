# AdapterExtEthInterface
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "adapter.ExtEthInterface"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "adapter.ExtEthInterface"]
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**DeviceMoId** | **String** | The database identifier of the registered device of an object. | [optional] [readonly] 
**Dn** | **String** | The Distinguished Name unambiguously identifies an object in the system. | [optional] [readonly] 
**Rn** | **String** | The Relative Name uniquely identifies an object within a given context. | [optional] [readonly] 
**OperState** | **String** | Operational state of an Interface. | [optional] 
**AcknowledgedPeerInterface** | [**EtherPhysicalPortBaseRelationship**](EtherPhysicalPortBaseRelationship.md) |  | [optional] 
**PeerInterface** | [**EtherPhysicalPortBaseRelationship**](EtherPhysicalPortBaseRelationship.md) |  | [optional] 
**AdminState** | **String** | Admin configured state of an External Ethernet Interface. | [optional] [readonly] 
**EpDn** | **String** | Endpoint Config DN of an External Ethernet Interface. | [optional] [readonly] 
**ExtEthInterfaceId** | **String** | Unique Identifier for an External Ethernet Interface within the adapter object. | [optional] [readonly] 
**InterfaceType** | **String** | Type of an External Ethernet Interface. | [optional] [readonly] 
**MacAddress** | **String** | MAC address of an External Ethernet Interface. | [optional] [readonly] 
**PeerAggrPortId** | **Int64** | Peer Aggregate Port Id attached to an External Ethernet Interface. | [optional] [readonly] 
**PeerDn** | **String** | DN of peer end-point attached to an External Ethernet Interface. | [optional] [readonly] 
**PeerPortId** | **Int64** | Peer Port Id attached to an External Ethernet Interface. | [optional] [readonly] 
**PeerSlotId** | **Int64** | Peer Slot Id attached to an External Ethernet Interface. | [optional] [readonly] 
**SwitchId** | **String** | SwitchId attached to an External Ethernet Interface. | [optional] [readonly] 
**AdapterUnit** | [**AdapterUnitRelationship**](AdapterUnitRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AdapterExtEthInterface = Initialize-IntersightAdapterExtEthInterface  -ClassId null `
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
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -DeviceMoId null `
 -Dn null `
 -Rn null `
 -OperState null `
 -AcknowledgedPeerInterface null `
 -PeerInterface null `
 -AdminState null `
 -EpDn null `
 -ExtEthInterfaceId null `
 -InterfaceType null `
 -MacAddress null `
 -PeerAggrPortId null `
 -PeerDn null `
 -PeerPortId null `
 -PeerSlotId null `
 -SwitchId null `
 -AdapterUnit null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$AdapterExtEthInterface | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

