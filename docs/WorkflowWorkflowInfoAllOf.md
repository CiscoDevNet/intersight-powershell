# WorkflowWorkflowInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **String** | The action of the workflow such as start, cancel, retry, pause. | [optional] [default to "None"]
**CleanupTime** | **System.DateTime** | The time when the workflow info will be removed from database. | [optional] [readonly] 
**EndTime** | **System.DateTime** | The time when the workflow reached a final state. | [optional] [readonly] 
**FailedWorkflowCleanupDuration** | **Int64** | The duration in hours after which the workflow info for failed, terminated or timed out workflow will be removed from database. | [optional] 
**VarInput** | [**AnyType**](.md) | All the given inputs for the workflow. | [optional] 
**InstId** | **String** | A workflow instance Id which is the unique identified for the workflow execution. | [optional] [readonly] 
**Internal** | **Boolean** | Denotes if this workflow is internal and should be hidden from user view of running workflows. | [optional] 
**LastAction** | **String** | The last action that was issued on the workflow is saved in this field. | [optional] [readonly] [default to "None"]
**Message** | [**WorkflowMessage[]**](WorkflowMessage.md) |  | [optional] 
**MetaVersion** | **Int64** | Version of the workflow metadata for which this workflow execution was started. | [optional] 
**Name** | **String** | A name of the workflow execution instance. | [optional] 
**Output** | [**AnyType**](.md) | All the generated outputs for the workflow. | [optional] [readonly] 
**PauseReason** | **String** | Denotes the reason workflow is in paused status. | [optional] [default to "None"]
**Progress** | **Double** | This field indicates percentage of workflow task execution. | [optional] [readonly] 
**Properties** | [**WorkflowWorkflowInfoProperties**](WorkflowWorkflowInfoProperties.md) |  | [optional] 
**RetryFromTaskName** | **String** | This field is applicable when Retry action is issued for a workflow which is in a final state. When this field is not specified then the workflow will retry from the start of the workflow. When this field is specified then the workflow will be retried from the specified task. The field should carry the task name which is the unique name of the task within the workflow. The task name must be one of the tasks that completed or failed in the previous run, you cannot retry a workflow from a task which wasn&#39;t run in the previous iteration. | [optional] 
**Src** | **String** | The source microservice name which is the owner for this workflow. | [optional] [readonly] 
**StartTime** | **System.DateTime** | The time when the workflow was started for execution. | [optional] [readonly] 
**Status** | **String** | A status of the workflow (RUNNING, WAITING, COMPLETED, TIME_OUT, FAILED). | [optional] [readonly] 
**SuccessWorkflowCleanupDuration** | **Int64** | The duration in hours after which the workflow info for successful workflow will be removed from database. | [optional] 
**TraceId** | **String** | The trace id to keep track of workflow execution. | [optional] [readonly] 
**Type** | **String** | A type of the workflow (serverconfig, ansible_monitoring). | [optional] [readonly] 
**UserId** | **String** | The user identifier which indicates the user that started this workflow. | [optional] [readonly] 
**WaitReason** | **String** | Denotes the reason workflow is in waiting status. | [optional] [default to "None"]
**WorkflowCtx** | [**WorkflowWorkflowCtx**](WorkflowWorkflowCtx.md) |  | [optional] 
**WorkflowMetaType** | **String** | The type of workflow meta. Derived from the workflow meta that is used to launch this workflow instance. | [optional] [default to "SystemDefined"]
**WorkflowTaskCount** | **Int64** | Total number of workflow tasks in this workflow. | [optional] [readonly] 
**Var0ClusterProfile** | [**HyperflexClusterProfileRelationship**](HyperflexClusterProfileRelationship.md) |  | [optional] 
**Var1SwitchProfile** | [**FabricSwitchProfileRelationship**](FabricSwitchProfileRelationship.md) |  | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**AssociatedObject** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**ParentTaskInfo** | [**WorkflowTaskInfoRelationship**](WorkflowTaskInfoRelationship.md) |  | [optional] 
**PendingDynamicWorkflowInfo** | [**WorkflowPendingDynamicWorkflowInfoRelationship**](WorkflowPendingDynamicWorkflowInfoRelationship.md) |  | [optional] 
**Permission** | [**IamPermissionRelationship**](IamPermissionRelationship.md) |  | [optional] 
**TaskInfos** | [**WorkflowTaskInfoRelationship[]**](WorkflowTaskInfoRelationship.md) | An array of relationships to workflowTaskInfo resources. | [optional] [readonly] 
**WorkflowDefinition** | [**WorkflowWorkflowDefinitionRelationship**](WorkflowWorkflowDefinitionRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowWorkflowInfoAllOf  -Action null `
 -CleanupTime null `
 -EndTime null `
 -FailedWorkflowCleanupDuration null `
 -VarInput null `
 -InstId null `
 -Internal null `
 -LastAction null `
 -Message null `
 -MetaVersion null `
 -Name null `
 -Output null `
 -PauseReason null `
 -Progress null `
 -Properties null `
 -RetryFromTaskName null `
 -Src null `
 -StartTime null `
 -Status null `
 -SuccessWorkflowCleanupDuration null `
 -TraceId null `
 -Type null `
 -UserId null `
 -WaitReason null `
 -WorkflowCtx null `
 -WorkflowMetaType null `
 -WorkflowTaskCount null `
 -Var0ClusterProfile null `
 -Var1SwitchProfile null `
 -Account null `
 -AssociatedObject null `
 -Organization null `
 -ParentTaskInfo null `
 -PendingDynamicWorkflowInfo null `
 -Permission null `
 -TaskInfos null `
 -WorkflowDefinition null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

