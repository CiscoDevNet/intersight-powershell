# ResourcePerTypeCombinedSelector
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**CombinedSelector** | **String** | A single filter expression created by OR&#39;ing the $filter criteria of the &#39;selectors&#39;. Used to efficiently maintain the membership of the Group. | [optional] [readonly] 
**EmptyFilter** | **Boolean** | If true, then resources are added using just object type without filter. | [optional] [readonly] 
**SelectorObjectType** | **String** | The ObjectType on which the selectors are defined. Used to efficiently query resource groups for a given ObjectType. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightResourcePerTypeCombinedSelector  -ClassId null `
 -ObjectType null `
 -CombinedSelector null `
 -EmptyFilter null `
 -SelectorObjectType null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

