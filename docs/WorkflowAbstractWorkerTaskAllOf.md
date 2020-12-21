# WorkflowAbstractWorkerTaskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**InputParameters** | [**AnyType**](.md) | JSON formatted map that defines the input given to the task. JSONPath is used for chaining output from previous tasks as inputs into the current task. The format to specify the mapping is &#39;${Source.input/output.JsonPath}&#39;. &#39;Source&#39; can be either workflow or the name of the task within the workflow. You can map the task input to either a workflow input or a task output. Following this is JSON path expression to extract JSON fragment from source&#39;s input/output. | [optional] 
**OnFailure** | **String** | This specifies the name of the next task to run if Task fails.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node. | [optional] 
**OnSuccess** | **String** | This specifies the name of the next task to run if Task succeeds.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node. | [optional] 
**RollbackDisabled** | **Boolean** | The task is disabled/enabled for rollback operation in this workflow if the task has rollback support. | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$WorkflowAbstractWorkerTaskAllOf = Initialize-IntersightWorkflowAbstractWorkerTaskAllOf  -ClassId null `
 -ObjectType null `
 -InputParameters null `
 -OnFailure null `
 -OnSuccess null `
 -RollbackDisabled null
```

- Convert the resource to JSON
```powershell
$WorkflowAbstractWorkerTaskAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

