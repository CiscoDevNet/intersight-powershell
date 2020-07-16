# WorkflowLoopTaskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **String** | Count value for the loop, this can be a constant or an expression which will evaluate to an integer value. Example, Use the length of the input A which is an array. Count must be less than or equal to 500. | [optional] 
**LoopStartTask** | **String** | Start task where the list of tasks will be executed multiple times based on the count value. | [optional] 
**NumberOfBatches** | **Int64** | When tasks are run in parallel and the count is large, the actual number of task run in parallel can be controlled by this property. If count is 100 and numberOfBatches is 5 then 20 tasks are run in parallel 5 times. Parallel batch size must be less than the count. In cases where count is dynamic and depends on input given during workflow execution, if that count is less than batch then empty batches might get created which do not have any tasks under them. | [optional] 
**OnSuccess** | **String** | This specifies the name of the next task to run if all iterations of the loop task succeeds.  This is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node. | [optional] 
**Parallel** | **Boolean** | When set to true the loop will run in parallel else it will run in a serial fashion. Only one task is supported inside the loop task when the loop is run in parallel. Subworkflow can be used inside the single loop task to build complex conditions. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowLoopTaskAllOf  -Count null `
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

