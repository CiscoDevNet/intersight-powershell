# WorkflowLoopTaskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.LoopTask"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.LoopTask"]
**Count** | **String** | Count value for the loop, this can be a constant or an expression which will evaluate to an integer value. Example, Use the length of the input A which is an array. Count must be less than or equal to 500. | [optional] 
**LoopStartTask** | **String** | Start task where the list of tasks will be executed multiple times based on the count value. | [optional] 
**NumberOfBatches** | **Int64** | When tasks are run in parallel and the count is large, the actual number of task run in parallel can be controlled by this property. If count is 100 and numberOfBatches is 5 then 20 tasks are run in parallel 5 times. Parallel batch size must be less than the count. In cases where count is dynamic and depends on input given during workflow execution, if that count is less than batch then empty batches might get created which do not have any tasks under them. | [optional] [default to 1]
**OnSuccess** | **String** | This specifies the name of the next task to run if all iterations of the loop task succeeds. The unique name given to the task instance within the workflow must be provided here. In a graph model, denotes an edge to another Task Node. | [optional] 
**Parallel** | **Boolean** | When set to true the loop will run in parallel else it will run in a serial fashion. Only one task is supported inside the loop task when the loop is run in parallel. Subworkflow can be used inside the single loop task to build complex conditions. | [optional] [default to $true]

## Examples

- Prepare the resource
```powershell
$WorkflowLoopTaskAllOf = Initialize-IntersightWorkflowLoopTaskAllOf  -ClassId null `
 -ObjectType null `
 -Count null `
 -LoopStartTask null `
 -NumberOfBatches null `
 -OnSuccess null `
 -Parallel null
```

- Convert the resource to JSON
```powershell
$WorkflowLoopTaskAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

