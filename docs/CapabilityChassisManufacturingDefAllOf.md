# CapabilityChassisManufacturingDefAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.ChassisManufacturingDef"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.ChassisManufacturingDef"]
**Caption** | **String** | Caption for Chassis enclosure. | [optional] 
**ChassisCodeName** | **String** | Chassis Code Name for Chassis enclosure. | [optional] 
**Description** | **String** | Description for Chassis enclosure. | [optional] 
**VarPid** | **String** | Product Identifier for a Chassis enclosure. | [optional] 
**ProductName** | **String** | Product Name for Chassis enclosure. | [optional] 
**Sku** | **String** | SKU information for Chassis enclosure. | [optional] 
**Vid** | **String** | VID information for Chassis enclosure. | [optional] 

## Examples

- Prepare the resource
```powershell
$CapabilityChassisManufacturingDefAllOf = Initialize-IntersightCapabilityChassisManufacturingDefAllOf  -ClassId null `
 -ObjectType null `
 -Caption null `
 -ChassisCodeName null `
 -Description null `
 -VarPid null `
 -ProductName null `
 -Sku null `
 -Vid null
```

- Convert the resource to JSON
```powershell
$CapabilityChassisManufacturingDefAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

