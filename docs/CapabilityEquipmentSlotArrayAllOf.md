# CapabilityEquipmentSlotArrayAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.EquipmentSlotArray"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.EquipmentSlotArray"]
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
$CapabilityEquipmentSlotArrayAllOf = Initialize-IntersightCapabilityEquipmentSlotArrayAllOf  -ClassId null `
 -ObjectType null `
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
$CapabilityEquipmentSlotArrayAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

