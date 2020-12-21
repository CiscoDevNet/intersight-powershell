# ResourcePerTypeCombinedSelectorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "resource.PerTypeCombinedSelector"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "resource.PerTypeCombinedSelector"]
**CombinedSelector** | **String** | A single filter expression created by OR&#39;ing the $filter criteria of the &#39;selectors&#39;. Used to efficiently maintain the membership of the Group. | [optional] [readonly] 
**EmptyFilter** | **Boolean** | If true, then resources are added using just object type without filter. | [optional] [readonly] 
**SelectorObjectType** | **String** | The ObjectType on which the selectors are defined. Used to efficiently query resource groups for a given ObjectType. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$ResourcePerTypeCombinedSelectorAllOf = Initialize-IntersightResourcePerTypeCombinedSelectorAllOf  -ClassId null `
 -ObjectType null `
 -CombinedSelector null `
 -EmptyFilter null `
 -SelectorObjectType null
```

- Convert the resource to JSON
```powershell
$ResourcePerTypeCombinedSelectorAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

