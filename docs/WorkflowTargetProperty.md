# WorkflowTargetProperty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**ConnectorAttribute** | **String** | A singleton value which will contain the path to connector object from the selected object. | [optional] 
**ConstraintAttributes** | **String[]** |  | [optional] 
**DisplayAttributes** | **String[]** |  | [optional] 
**Selector** | **String** | Field to hold an Intersight API along with an optional filter to narrow down the search options for target device. | [optional] 
**SupportedObjects** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowTargetProperty  -ClassId null `
 -ObjectType null `
 -ConnectorAttribute null `
 -ConstraintAttributes null `
 -DisplayAttributes null `
 -Selector null `
 -SupportedObjects null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

