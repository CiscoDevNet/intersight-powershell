# AdapterHostEthInterfaceRelationship
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "adapter.HostEthInterface"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "adapter.HostEthInterface"]
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Selector** | **String** | An OData $filter expression which describes the REST resource to be referenced. This field may be set instead of &#39;moid&#39; by clients. 1. If &#39;moid&#39; is set this field is ignored. 1. If &#39;selector&#39; is set and &#39;moid&#39; is empty/absent from the request, Intersight determines the Moid of the resource matching the filter expression and populates it in the MoRef that is part of the object instance being inserted/updated to fulfill the REST request. An error is returned if the filter matches zero or more than one REST resource. An example filter string is: Serial eq &#39;3AA8B7T11&#39;. | [optional] [readonly] 
**Link** | **String** | A URL to an instance of the &#39;mo.MoRef&#39; class. | [optional] 
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
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
**AdminState** | **String** | Admin state of the Host Ethernet Interface. | [optional] [readonly] 
**EpDn** | **String** | The Endpoint Config Dn of the Host Ethernet Interface. | [optional] [readonly] 
**HostEthInterfaceId** | **Int64** | Unique Identifier for an Host Ethernet Interface within the adapter object. | [optional] [readonly] 
**InterfaceType** | **String** | Type of External Ethernet Interface. | [optional] [readonly] 
**MacAddress** | **String** | Mac address of the Host Ethernet Interface. | [optional] [readonly] 
**Name** | **String** | Name of Host Ethernet Interface. | [optional] [readonly] 
**Operability** | **String** | Operability status of Host Ethernet Channel Interface. | [optional] [readonly] 
**OriginalMacAddress** | **String** | The factory default Mac address of the Host Ethernet Interface. | [optional] [readonly] 
**PciAddr** | **String** | The PCI address of the Host Ethernet Interface. | [optional] [readonly] 
**PeerDn** | **String** | The distinguished name of the peer endpoint connected to the Host Ethernet interface. | [optional] [readonly] 
**VirtualizationPreference** | **String** | Virtualization Preference of the Host Ethernet Interface indicating if virtualization is enabled or not. | [optional] [readonly] 
**VnicDn** | **String** | The Virtual Ethernet Interface DN connected to the Host Ethernet Interface. | [optional] [readonly] 
**AdapterUnit** | [**AdapterUnitRelationship**](AdapterUnitRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AdapterHostEthInterfaceRelationship = Initialize-IntersightAdapterHostEthInterfaceRelationship  -ClassId null `
 -ObjectType null `
 -Moid null `
 -Selector null `
 -Link null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
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
 -HostEthInterfaceId null `
 -InterfaceType null `
 -MacAddress null `
 -Name null `
 -Operability null `
 -OriginalMacAddress null `
 -PciAddr null `
 -PeerDn null `
 -VirtualizationPreference null `
 -VnicDn null `
 -AdapterUnit null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$AdapterHostEthInterfaceRelationship | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

