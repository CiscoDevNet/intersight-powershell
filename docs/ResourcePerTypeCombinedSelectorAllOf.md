# ResourcePerTypeCombinedSelectorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CombinedSelector** | **String** | A single filter expression created by OR&#39;ing the $filter criteria of the &#39;selectors&#39;. Used to efficiently maintain the membership of the Group. | [optional] [readonly] 
**EmptyFilter** | **Boolean** | If true, then resources are added using just object type without filter. | [optional] [readonly] 
**SelectorObjectType** | **String** | The ObjectType on which the selectors are defined. Used to efficiently query resource groups for a given ObjectType. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightResourcePerTypeCombinedSelectorAllOf  -CombinedSelector null `
 -EmptyFilter null `
 -SelectorObjectType null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

