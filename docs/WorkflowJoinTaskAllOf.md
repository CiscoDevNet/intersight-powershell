# WorkflowJoinTaskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.JoinTask"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.JoinTask"]
**JoinOnTasks** | **String[]** |  | [optional] 
**OnSuccess** | **String** | Name of the next task to run if all fork path specified in the JoinOnTasks list succeeds which is the unique name given to the task instance within the workflow. In a graph model, denotes an edge to another Task Node. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowJoinTaskAllOf = Initialize-IntersightWorkflowJoinTaskAllOf  -ClassId null `
 -ObjectType null `
 -JoinOnTasks null `
 -OnSuccess null
```

- Convert the resource to JSON
```powershell
$WorkflowJoinTaskAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

