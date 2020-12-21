# CapabilityPortGroupAggregationDefAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "capability.PortGroupAggregationDef"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "capability.PortGroupAggregationDef"]
**AggregationCap** | **String** | Aggregation capability for port group. | [optional] 
**Hw40GPortGroupCap** | **Boolean** | Indicates support for 40G port group capability. | [optional] 
**Pgtype** | **String** | The type of port group for which this capability is defined. | [optional] 

## Examples

- Prepare the resource
```powershell
$CapabilityPortGroupAggregationDefAllOf = Initialize-IntersightCapabilityPortGroupAggregationDefAllOf  -ClassId null `
 -ObjectType null `
 -AggregationCap null `
 -Hw40GPortGroupCap null `
 -Pgtype null
```

- Convert the resource to JSON
```powershell
$CapabilityPortGroupAggregationDefAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

