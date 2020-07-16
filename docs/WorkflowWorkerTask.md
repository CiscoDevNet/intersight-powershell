# WorkflowWorkerTask
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Description** | **String** | The description of this task instance in the workflow. | [optional] 
**Label** | **String** | A user defined label identifier of the workflow task used for UI display. | [optional] 
**Name** | **String** | The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks. | [optional] 
**InputParameters** | [**AnyType**](.md) | JSON formatted map that defines the input given to the task. JSONPath is used for chaining output from previous tasks as inputs into the current task. The format to specify the mapping is &#39;${Source.input/output.JsonPath}&#39;. &#39;Source&#39; can be either workflow or the name of the task within the workflow. You can map the task input to either a workflow input or a task output. Following this is JSON path expression to extract JSON fragment from source&#39;s input/output. | [optional] 
**OnFailure** | **String** | This specifies the name of the next task to run if Task fails.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node. | [optional] 
**OnSuccess** | **String** | This specifies the name of the next task to run if Task succeeds.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node. | [optional] 
**CatalogMoid** | **String** | Specify the catalog moid that this task belongs. | [optional] 
**TaskDefinitionId** | **String** | The resolved referenced task definition managed object. | [optional] [readonly] 
**TaskDefinitionName** | **String** | The qualified name of task that should be executed. | [optional] 
**Version** | **Int64** | The task definition version to use in this workflow. When no version is specified then the default version of the task at the time of creating or updating this workflow is used. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowWorkerTask  -ClassId null `
 -ObjectType null `
 -Description null `
 -Label null `
 -Name null `
 -InputParameters null `
 -OnFailure null `
 -OnSuccess null `
 -CatalogMoid null `
 -TaskDefinitionId null `
 -TaskDefinitionName null `
 -Version null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

