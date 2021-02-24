# WorkflowRollbackWorkflowTask
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.RollbackWorkflowTask"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.RollbackWorkflowTask"]
**Description** | **String** | Description of the rollback task. | [optional] [readonly] 
**Name** | **String** | Name of TaskInfo that needs to be rolled back. | [optional] 
**RefName** | **String** | Reference name of TaskInfo that need to be rolled back. | [optional] 
**RollbackCompleted** | **Boolean** | Status of the rollback operation for the task. | [optional] [readonly] 
**RollbackTaskName** | **String** | Name of TaskInfo that performs the rollback operation. | [optional] [readonly] 
**Status** | **String** | Status of the rollback task. By default, task status will be not started. Task status will be set to completed on successful execution, otherwise it will be set to failed. * &#x60;NotStarted&#x60; - Status of rollback task when it is not started rollback. * &#x60;Not supported&#x60; - Status of task when it is not supporting rollback. * &#x60;Completed&#x60; - Status of rollback task once execution is successful. * &#x60;Failed&#x60; - Status of rollback task when it is failed. | [optional] [readonly] [default to "NotStarted"]
**TaskInfoMoid** | **String** | Moid of TaskInfo that supports rollback operation. | [optional] 
**TaskPath** | **String** | Path of rollback task if it is inside sub-workflow. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$WorkflowRollbackWorkflowTask = Initialize-IntersightWorkflowRollbackWorkflowTask  -ClassId null `
 -ObjectType null `
 -Description null `
 -Name null `
 -RefName null `
 -RollbackCompleted null `
 -RollbackTaskName null `
 -Status null `
 -TaskInfoMoid null `
 -TaskPath null
```

- Convert the resource to JSON
```powershell
$WorkflowRollbackWorkflowTask | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

