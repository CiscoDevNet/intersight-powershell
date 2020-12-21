# CapabilityFanModuleManufacturingDefAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.FanModuleManufacturingDef"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.FanModuleManufacturingDef"]
**Caption** | **String** | Caption for a fan module. | [optional] 
**Description** | **String** | Description for a fan module. | [optional] 
**VarPid** | **String** | Product Identifier for a fan module. | [optional] 
**ProductName** | **String** | Product Name for Fan Module Unit. | [optional] 
**Sku** | **String** | SKU information for a fan module. | [optional] 
**Vid** | **String** | VID information for a fan module. | [optional] 

## Examples

- Prepare the resource
```powershell
$CapabilityFanModuleManufacturingDefAllOf = Initialize-IntersightCapabilityFanModuleManufacturingDefAllOf  -ClassId null `
 -ObjectType null `
 -Caption null `
 -Description null `
 -VarPid null `
 -ProductName null `
 -Sku null `
 -Vid null
```

- Convert the resource to JSON
```powershell
$CapabilityFanModuleManufacturingDefAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

