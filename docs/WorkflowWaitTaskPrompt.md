# WorkflowWaitTaskPrompt
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Description** | **String** | Description that give more details about what it means to pick this prompt option for the wait task. | [optional] 
**Label** | **String** | User friendly label for the prompt. This label will be shown to the user as one of available options for the wait task. | [optional] 
**Name** | **String** | Name for the wait prompt. | [optional] 
**TaskStatus** | **String** | Task status for the wait task when this prompt option is selected. | [optional] [default to "Scheduled"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowWaitTaskPrompt  -ClassId null `
 -ObjectType null `
 -Description null `
 -Label null `
 -Name null `
 -TaskStatus null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

