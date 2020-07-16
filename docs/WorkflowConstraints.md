# WorkflowConstraints
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**EnumList** | [**WorkflowEnumEntry[]**](WorkflowEnumEntry.md) |  | [optional] 
**Max** | **Double** | Allowed maximum value of the parameter if parameter is integer/float or maximum length of the parameter if the parameter is string. When max and min are set to 0, then the limits are not checked. | [optional] 
**Min** | **Double** | Allowed minimum value of the parameter if parameter is integer/float or minimum length of the parameter if the parameter is string. When max and min are set to 0, then the limits are not checked. | [optional] 
**Regex** | **String** | When the parameter is a string this regular expression is used to ensure the value is valid. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowConstraints  -ClassId null `
 -ObjectType null `
 -EnumList null `
 -Max null `
 -Min null `
 -Regex null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

