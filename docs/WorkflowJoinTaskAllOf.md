# WorkflowJoinTaskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JoinOnTasks** | **String[]** |  | [optional] 
**OnSuccess** | **String** | Name of the next task to run if all fork path specified in the JoinOnTasks list succeeds which is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowJoinTaskAllOf  -JoinOnTasks null `
 -OnSuccess null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

