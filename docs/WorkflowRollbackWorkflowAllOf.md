# WorkflowRollbackWorkflowAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.RollbackWorkflow"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.RollbackWorkflow"]
**Action** | **String** | The action of the rollback workflow such as Create and Start. * &#x60;None&#x60; - If no action is set, then the default value is set to none for the action field. * &#x60;Create&#x60; - Create rollback workflow data for the execution of the rollback workflow. * &#x60;Start&#x60; - Start a new execution of the rollback workflow. | [optional] [default to "None"]
**ContinueOnTaskFailure** | **Boolean** | When set to true, if a task in the workflow fails, the rollback workflow continues to the subsequent task. When set to false, the rollback workflow execution halts if a task fails. | [optional] [default to $true]
**RollbackTasks** | [**WorkflowRollbackWorkflowTask[]**](WorkflowRollbackWorkflowTask.md) |  | [optional] 
**SelectedTasks** | [**WorkflowRollbackWorkflowTask[]**](WorkflowRollbackWorkflowTask.md) |  | [optional] 
**Status** | **String** | Status of the rollback workflow instance (Created, Running, Completed, Failed). * &#x60;None&#x60; - If no status is set, then the default value is set none for the status field. * &#x60;Created&#x60; - Status of the rollback workflow when it identifies the eligible tasks for rollback. * &#x60;Running&#x60; - Status of the rollback workflow when it is in-progress. * &#x60;Completed&#x60; - Status of the rollback workflow after execution is successful. * &#x60;Failed&#x60; - Status of the rollback workflow after execution results in failure. | [optional] [readonly] [default to "None"]
**PrimaryWorkflow** | [**WorkflowWorkflowInfoRelationship**](WorkflowWorkflowInfoRelationship.md) |  | [optional] 
**RollbackWorkflows** | [**WorkflowWorkflowInfoRelationship[]**](WorkflowWorkflowInfoRelationship.md) | An array of relationships to workflowWorkflowInfo resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$WorkflowRollbackWorkflowAllOf = Initialize-IntersightWorkflowRollbackWorkflowAllOf  -ClassId null `
 -ObjectType null `
 -Action null `
 -ContinueOnTaskFailure null `
 -RollbackTasks null `
 -SelectedTasks null `
 -Status null `
 -PrimaryWorkflow null `
 -RollbackWorkflows null
```

- Convert the resource to JSON
```powershell
$WorkflowRollbackWorkflowAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

