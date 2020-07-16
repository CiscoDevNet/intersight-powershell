# WorkflowMoReferenceProperty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**DisplayAttributes** | **String[]** |  | [optional] 
**Selector** | **String** | Field to hold an Intersight API along with an optional filter to narrow down the search options. | [optional] 
**ValueAttribute** | **String** | A property from the Intersight object, value of which can be used as value for referenced input definition. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowMoReferenceProperty  -ClassId null `
 -ObjectType null `
 -DisplayAttributes null `
 -Selector null `
 -ValueAttribute null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

