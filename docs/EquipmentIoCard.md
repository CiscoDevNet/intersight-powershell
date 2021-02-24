# EquipmentIoCard
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "equipment.IoCard"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "equipment.IoCard"]
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
**DeviceMoId** | **String** | The database identifier of the registered device of an object. | [optional] [readonly] 
**Dn** | **String** | The Distinguished Name unambiguously identifies an object in the system. | [optional] [readonly] 
**Rn** | **String** | The Relative Name uniquely identifies an object within a given context. | [optional] [readonly] 
**Model** | **String** | This field identifies the model of the given component. | [optional] [readonly] 
**Revision** | **String** | This field identifies the revision of the given component. | [optional] [readonly] 
**Serial** | **String** | This field identifies the serial of the given component. | [optional] [readonly] 
**Vendor** | **String** | This field identifies the vendor of the given component. | [optional] [readonly] 
**ConnectionStatus** | **String** | Connectivity Status of FEX/IOM to Switch - A or B or AB. | [optional] 
**Description** | **String** | This field is to provide description for the iocard module model. | [optional] [readonly] 
**ModuleId** | **Int64** | Module Identifier for the IO module. | [optional] [readonly] 
**OperReason** | **String[]** |  | [optional] 
**OperState** | **String** | Operational state of IO card or fabric extender. | [optional] [readonly] 
**PartNumber** | **String** | Part Number identifier for the IO module. | [optional] [readonly] 
**VarPid** | **String** | This field identifies the Product ID for the IO module. | [optional] [readonly] 
**Presence** | **String** | This field identifies the Presence state of the IO card module. | [optional] [readonly] 
**ProductName** | **String** | This field identifies the Product Name for the iocard module model. | [optional] [readonly] 
**Sku** | **String** | This field identifies the Stock Keeping Unit for the IO card module. | [optional] [readonly] 
**Version** | **String** | This field identifies the version of the IO card module. | [optional] [readonly] 
**Vid** | **String** | This field identifies the Vendor ID for the IO card module. | [optional] [readonly] 
**HostPorts** | [**EtherHostPortRelationship[]**](EtherHostPortRelationship.md) | An array of relationships to etherHostPort resources. | [optional] 
**MgmtController** | [**ManagementControllerRelationship**](ManagementControllerRelationship.md) |  | [optional] 
**NetworkPorts** | [**EtherNetworkPortRelationship[]**](EtherNetworkPortRelationship.md) | An array of relationships to etherNetworkPort resources. | [optional] 
**ConnectionPath** | **String** | Switch Id to which the IOM is connected to. The value can be A or B. | [optional] [readonly] 
**DcSupported** | **Boolean** | IOM device connector support. | [optional] [readonly] 
**Side** | **String** | Location of IOM within a chassis. The value can be left or right. | [optional] [readonly] 
**EquipmentChassis** | [**EquipmentChassisRelationship**](EquipmentChassisRelationship.md) |  | [optional] 
**EquipmentFex** | [**EquipmentFexRelationship**](EquipmentFexRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**PhysicalDeviceRegistration** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$EquipmentIoCard = Initialize-IntersightEquipmentIoCard  -ClassId null `
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
 -DeviceMoId null `
 -Dn null `
 -Rn null `
 -Model null `
 -Revision null `
 -Serial null `
 -Vendor null `
 -ConnectionStatus null `
 -Description null `
 -ModuleId null `
 -OperReason null `
 -OperState null `
 -PartNumber null `
 -VarPid null `
 -Presence null `
 -ProductName null `
 -Sku null `
 -Version null `
 -Vid null `
 -HostPorts null `
 -MgmtController null `
 -NetworkPorts null `
 -ConnectionPath null `
 -DcSupported null `
 -Side null `
 -EquipmentChassis null `
 -EquipmentFex null `
 -InventoryDeviceInfo null `
 -PhysicalDeviceRegistration null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$EquipmentIoCard | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

