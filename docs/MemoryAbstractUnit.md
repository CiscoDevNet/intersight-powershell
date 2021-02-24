# MemoryAbstractUnit
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
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
**AdminState** | **String** | This represents the administrative state of the memory unit on a server. | [optional] [readonly] 
**ArrayId** | **Int64** | This represents the memory array to which the memory unit belongs to. | [optional] [readonly] 
**Bank** | **Int64** | This represents the memory bank of the memory unit on a server. | [optional] [readonly] 
**Capacity** | **String** | This represents the memory capacity in MiB of the memory unit on a server. | [optional] [readonly] 
**Clock** | **String** | This represents the clock of the memory unit on a server. | [optional] [readonly] 
**FormFactor** | **String** | This represents the form factor of the memory unit on a server. | [optional] [readonly] 
**Latency** | **String** | This represents the latency of the memory unit on a server. | [optional] [readonly] 
**Location** | **String** | This represents the location of the memory unit on a server. | [optional] [readonly] 
**OperPowerState** | **String** | This represents the operational power state of the memory unit on a server. | [optional] [readonly] 
**OperReason** | **String[]** |  | [optional] 
**OperState** | **String** | This represents the operational state of the memory unit on a server. | [optional] [readonly] 
**Operability** | **String** | This represents the operability of the memory unit on a server. | [optional] [readonly] 
**Presence** | **String** | This represents the presence state of the memory unit on a server. | [optional] [readonly] 
**Set** | **Int64** | This represents the set of the memory unit on a server. | [optional] [readonly] 
**Speed** | **String** | This represents the speed of the memory unit on a server. | [optional] [readonly] 
**Thermal** | **String** | This represents the thremal state of the memory unit on a server. | [optional] [readonly] 
**Type** | **String** | This represents the memory type of the memory unit on a server. | [optional] [readonly] 
**Visibility** | **String** | This represents the visibility of the memory unit on a server. | [optional] [readonly] 
**Width** | **String** | This represents the width of the memory unit on a server. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$MemoryAbstractUnit = Initialize-IntersightMemoryAbstractUnit  -ClassId null `
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
 -AdminState null `
 -ArrayId null `
 -Bank null `
 -Capacity null `
 -Clock null `
 -FormFactor null `
 -Latency null `
 -Location null `
 -OperPowerState null `
 -OperReason null `
 -OperState null `
 -Operability null `
 -Presence null `
 -Set null `
 -Speed null `
 -Thermal null `
 -Type null `
 -Visibility null `
 -Width null
```

- Convert the resource to JSON
```powershell
$MemoryAbstractUnit | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

