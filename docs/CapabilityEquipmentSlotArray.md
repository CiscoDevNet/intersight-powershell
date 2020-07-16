# CapabilityEquipmentSlotArray
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
**Name** | **String** | An unique identifer for a capability descriptor. | [optional] 
**Section** | [**CapabilitySectionRelationship**](CapabilitySectionRelationship.md) |  | [optional] 
**VarPid** | **String** | Product Identifier for a Switch/Fabric-Interconnect. | [optional] 
**Sku** | **String** | SKU information for Switch/Fabric-Interconnect. | [optional] 
**Vid** | **String** | VID information for Switch/Fabric-Interconnect. | [optional] 
**FirstIndex** | **Double** | First Index information for a Switch/Fabric-Interconnect hardware. | [optional] 
**Height** | **Double** | Height information for a Switch/Fabric-Interconnect hardware. | [optional] 
**HorizontalStartOffset** | **Double** | Horizontal Start Offset information for a Switch/Fabric-Interconnect hardware. | [optional] 
**InlineGroupSeparation** | **Double** | Inline Group Separation information for a Switch/Fabric-Interconnect hardware. | [optional] 
**InlineGroupSize** | **Double** | Inline Group Size information for a Switch/Fabric-Interconnect hardware. | [optional] 
**InlineOffset** | **Double** | Inline Offset information for a Switch/Fabric-Interconnect hardware. | [optional] 
**Location** | **String** | Location information for a Switch/Fabric-Interconnect hardware. | [optional] 
**NumberOfSlots** | **Int64** | Number of Slots information for a Switch/Fabric-Interconnect hardware. | [optional] 
**Orientation** | **String** | Orientation information for a Switch/Fabric-Interconnect hardware. | [optional] 
**Selector** | **String** | Selector information for a Switch/Fabric-Interconnect hardware. | [optional] 
**SlotsPerLine** | **Int64** | Slots per line information for a Switch/Fabric-Interconnect hardware. | [optional] 
**TransverseGroupSeparation** | **Double** | Transverse Group Separation information for a Switch/Fabric-Interconnect hardware. | [optional] 
**TransverseGroupSize** | **Double** | Transverse Group Size information for a Switch/Fabric-Interconnect hardware. | [optional] 
**TransverseOffset** | **Double** | Transverse Offset information for a Switch/Fabric-Interconnect hardware. | [optional] 
**VerticalStartOffset** | **Double** | Vertical Start Offset information for a Switch/Fabric-Interconnect hardware. | [optional] 
**Width** | **Double** | Width information for a Switch/Fabric-Interconnect hardware. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCapabilityEquipmentSlotArray  -AccountMoid null `
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
 -Name null `
 -Section null `
 -VarPid null `
 -Sku null `
 -Vid null `
 -FirstIndex null `
 -Height null `
 -HorizontalStartOffset null `
 -InlineGroupSeparation null `
 -InlineGroupSize null `
 -InlineOffset null `
 -Location null `
 -NumberOfSlots null `
 -Orientation null `
 -Selector null `
 -SlotsPerLine null `
 -TransverseGroupSeparation null `
 -TransverseGroupSize null `
 -TransverseOffset null `
 -VerticalStartOffset null `
 -Width null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

