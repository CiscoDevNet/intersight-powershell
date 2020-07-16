# WorkflowLoopTask
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Description** | **String** | The description of this task instance in the workflow. | [optional] 
**Label** | **String** | A user defined label identifier of the workflow task used for UI display. | [optional] 
**Name** | **String** | The name of the task within the workflow and it must be unique among all WorkflowTasks within a workflow definition. This name serves as the internal unique identifier for the task and is used to pick input and output parameters to feed into other tasks. | [optional] 
**Count** | **String** | Count value for the loop, this can be a constant or an expression which will evaluate to an integer value. Example, Use the length of the input A which is an array. Count must be less than or equal to 500. | [optional] 
**LoopStartTask** | **String** | Start task where the list of tasks will be executed multiple times based on the count value. | [optional] 
**NumberOfBatches** | **Int64** | When tasks are run in parallel and the count is large, the actual number of task run in parallel can be controlled by this property. If count is 100 and numberOfBatches is 5 then 20 tasks are run in parallel 5 times. Parallel batch size must be less than the count. In cases where count is dynamic and depends on input given during workflow execution, if that count is less than batch then empty batches might get created which do not have any tasks under them. | [optional] 
**OnSuccess** | **String** | This specifies the name of the next task to run if all iterations of the loop task succeeds.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node. | [optional] 
**Parallel** | **Boolean** | When set to true the loop will run in parallel else it will run in a serial fashion. Only one task is supported inside the loop task when the loop is run in parallel. Subworkflow can be used inside the single loop task to build complex conditions. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowLoopTask  -ClassId null `
 -ObjectType null `
 -Description null `
 -Label null `
 -Name null `
 -Count null `
 -LoopStartTask null `
 -NumberOfBatches null `
 -OnSuccess null `
 -Parallel null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

