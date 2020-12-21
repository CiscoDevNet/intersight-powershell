# CapabilitySiocModuleManufacturingDefAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.SiocModuleManufacturingDef"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.SiocModuleManufacturingDef"]
**Caption** | **String** | Caption for a chassis SIOC module. | [optional] 
**Description** | **String** | Description for a chassis SIOC module. | [optional] 
**VarPid** | **String** | Product Identifier for a chassis SIOC module. | [optional] 
**ProductName** | **String** | Product Name for SIOC Module. | [optional] 
**Sku** | **String** | SKU information for a chassis SIOC module. | [optional] 
**Vid** | **String** | VID information for a chassis SIOC module. | [optional] 

## Examples

- Prepare the resource
```powershell
$CapabilitySiocModuleManufacturingDefAllOf = Initialize-IntersightCapabilitySiocModuleManufacturingDefAllOf  -ClassId null `
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
$CapabilitySiocModuleManufacturingDefAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

