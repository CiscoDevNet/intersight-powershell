# CapabilityPortGroupAggregationDefAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AggregationCap** | **String** | Aggregation capability for port group. | [optional] 
**Hw40GPortGroupCap** | **Boolean** | Indicates support for 40G port group capability. | [optional] 
**Pgtype** | **String** | The type of port group for which this capability is defined. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCapabilityPortGroupAggregationDefAllOf  -AggregationCap null `
 -Hw40GPortGroupCap null `
 -Pgtype null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

