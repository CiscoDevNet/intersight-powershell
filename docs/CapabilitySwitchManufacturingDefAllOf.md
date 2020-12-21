# CapabilitySwitchManufacturingDefAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.SwitchManufacturingDef"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.SwitchManufacturingDef"]
**Caption** | **String** | Caption for Switch/Fabric-Interconnect. | [optional] 
**Description** | **String** | Description for Switch/Fabric-Interconnect. | [optional] 
**PartNumber** | **String** | Part Number for Switch/Fabric-Interconnect. | [optional] 
**ProductName** | **String** | Product Name for Switch/Fabric-Interconnect. | [optional] 

## Examples

- Prepare the resource
```powershell
$CapabilitySwitchManufacturingDefAllOf = Initialize-IntersightCapabilitySwitchManufacturingDefAllOf  -ClassId null `
 -ObjectType null `
 -Caption null `
 -Description null `
 -PartNumber null `
 -ProductName null
```

- Convert the resource to JSON
```powershell
$CapabilitySwitchManufacturingDefAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

