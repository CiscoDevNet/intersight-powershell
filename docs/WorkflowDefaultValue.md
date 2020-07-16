# WorkflowDefaultValue
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Override** | **Boolean** | Override the default value provided for the data type. When true, allow the user to enter value for the data type. | [optional] 
**Value** | [**AnyType**](.md) | Default value for the data type. If default value was provided and the input was required the default value will be used as the input. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowDefaultValue  -ClassId null `
 -ObjectType null `
 -Override null `
 -Value null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

