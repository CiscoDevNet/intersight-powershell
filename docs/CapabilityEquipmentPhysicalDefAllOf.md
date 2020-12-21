# CapabilityEquipmentPhysicalDefAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.EquipmentPhysicalDef"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.EquipmentPhysicalDef"]
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
$CapabilityEquipmentPhysicalDefAllOf = Initialize-IntersightCapabilityEquipmentPhysicalDefAllOf  -ClassId null `
 -ObjectType null `
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
$CapabilityEquipmentPhysicalDefAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

