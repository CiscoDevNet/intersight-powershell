# CapabilityEquipmentPhysicalDef
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.EquipmentPhysicalDef"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.EquipmentPhysicalDef"]
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
**Name** | **String** | An unique identifer for a capability descriptor. | [optional] 
**VarPid** | **String** | Product Identifier for a Switch/Fabric-Interconnect. * &#x60;UCS-FI-6454&#x60; - The standard 4th generation UCS Fabric Interconnect with 54 ports. * &#x60;UCS-FI-64108&#x60; - The expanded 4th generation UCS Fabric Interconnect with 108 ports. * &#x60;unknown&#x60; - Unknown device type, usage is TBD. | [optional] [default to "UCS-FI-6454"]
**Sku** | **String** | SKU information for Switch/Fabric-Interconnect. | [optional] 
**Vid** | **String** | VID information for Switch/Fabric-Interconnect. | [optional] 
**Depth** | **Double** | Depth information for a Switch/Fabric-Interconnect. | [optional] 
**Height** | **Double** | Height information for a Switch/Fabric-Interconnect. | [optional] 
**MaxPower** | **Int64** | Max Power information for a Switch/Fabric-Interconnect. | [optional] 
**MinPower** | **Int64** | Min Power information for a Switch/Fabric-Interconnect. | [optional] 
**NominalPower** | **Int64** | Nominal Power information for a Switch/Fabric-Interconnect. | [optional] 
**Weight** | **Double** | Weight information for a Switch/Fabric-Interconnect. | [optional] 
**Width** | **Double** | Width information for a Switch/Fabric-Interconnect. | [optional] 

## Examples

- Prepare the resource
```powershell
$CapabilityEquipmentPhysicalDef = Initialize-IntersightCapabilityEquipmentPhysicalDef  -ClassId null `
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
 -Name null `
 -VarPid null `
 -Sku null `
 -Vid null `
 -Depth null `
 -Height null `
 -MaxPower null `
 -MinPower null `
 -NominalPower null `
 -Weight null `
 -Width null
```

- Convert the resource to JSON
```powershell
$CapabilityEquipmentPhysicalDef | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

