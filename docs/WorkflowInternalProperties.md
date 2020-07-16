# WorkflowInternalProperties
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**BaseTaskType** | **String** | This field will hold the base task type like HttpBaseTask or RemoteAnsibleBaseTask. | [optional] [readonly] 
**Constraints** | [**WorkflowTaskConstraints**](WorkflowTaskConstraints.md) |  | [optional] 
**Internal** | **Boolean** | Denotes this is an internal task. Internal tasks will be hidden from the UI when executing a workflow. | [optional] [readonly] 
**Owner** | **String** | The service that owns and is responsible for execution of the task. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowInternalProperties  -ClassId null `
 -ObjectType null `
 -BaseTaskType null `
 -Constraints null `
 -Internal null `
 -Owner null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

