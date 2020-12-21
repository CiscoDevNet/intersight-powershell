# WorkflowWorkflowInfoRelationship
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.WorkflowInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.WorkflowInfo"]
**Moid** | **String** | The unique identifier of this Managed Object instance. | [optional] 
**Selector** | **String** | An OData $filter expression which describes the REST resource to be referenced. This field may be set instead of &#39;moid&#39; by clients. 1. If &#39;moid&#39; is set this field is ignored. 1. If &#39;selector&#39; is set and &#39;moid&#39; is empty/absent from the request, Intersight determines the Moid of the resource matching the filter expression and populates it in the MoRef that is part of the object instance being inserted/updated to fulfill the REST request. An error is returned if the filter matches zero or more than one REST resource. An example filter string is: Serial eq &#39;3AA8B7T11&#39;. | [optional] [readonly] 
**Link** | **String** | A URL to an instance of the &#39;mo.MoRef&#39; class. | [optional] 
**AccountMoid** | **String** | The Account ID for this managed object. | [optional] [readonly] 
**CreateTime** | **System.DateTime** | The time when this managed object was created. | [optional] [readonly] 
**DomainGroupMoid** | **String** | The DomainGroup ID for this managed object. | [optional] [readonly] 
**ModTime** | **System.DateTime** | The time when this managed object was last modified. | [optional] [readonly] 
**Owners** | **String[]** |  | [optional] 
**SharedScope** | **String** | Intersight provides pre-built workflows, tasks and policies to end users through global catalogs. Objects that are made available through global catalogs are said to have a &#39;shared&#39; ownership. Shared objects are either made globally available to all end users or restricted to end users based on their license entitlement. Users can use this property to differentiate the scope (global or a specific license tier) to which a shared MO belongs. | [optional] [readonly] 
**Tags** | [**MoTag[]**](MoTag.md) |  | [optional] 
**VersionContext** | [**MoVersionContext**](MoVersionContext.md) |  | [optional] 
**Ancestors** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**Parent** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**PermissionResources** | [**MoBaseMoRelationship[]**](MoBaseMoRelationship.md) | An array of relationships to moBaseMo resources. | [optional] [readonly] 
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | A set of display names for the MO resource. These names are calculated based on other properties of the MO and potentially properties of Ancestor MOs. Displaynames are intended as a way to provide a normalized user appropriate name for an MO, especially for MOs which do not have a &#39;Name&#39; property, which is the case for much of the inventory discovered from managed targets. There are a limited number of keys, currently &#39;short&#39; and &#39;hierarchical&#39;. The value is an array and clients should use the first element of the array. | [optional] [readonly] 
**Action** | **String** | The action of the workflow such as start, cancel, retry, pause. * &#x60;None&#x60; - No action is set, this is the default value for action field. * &#x60;Create&#x60; - Create a new instance of the workflow but it does not start the execution of the workflow. Use the Start action to start execution of the workflow. * &#x60;Start&#x60; - Start a new execution of the workflow. * &#x60;Pause&#x60; - Pause the workflow, this can only be issued on workflows that are in running state. * &#x60;Resume&#x60; - Resume the workflow which was previously paused through pause action on the workflow. * &#x60;Retry&#x60; - Retry the workflow that has previously reached a final state and has the retryable property set to true on the workflow. A running or waiting workflow cannot be retried. If the property retryFromTaskName is also passed along with this action, the workflow will be started from that specific task, otherwise the workflow will be restarted. The task name must be one of the tasks that completed or failed in the previous run, you cannot retry a workflow from a task which wasn&#39;t run in the previous iteration. * &#x60;RetryFailed&#x60; - Retry the workflow that has failed. A running or waiting workflow or a workflow that completed successfully cannot be retried. Only the tasks that failed in the previous run will be retried and the rest of workflow will be run. This action does not restart the workflow and also does not support retrying from a specific task. * &#x60;Cancel&#x60; - Cancel the workflow that is in running or waiting state. | [optional] [default to "None"]
**CleanupTime** | **System.DateTime** | The time when the workflow info will be removed from database. | [optional] [readonly] 
**Email** | **String** | The email address of the user who started this workflow. | [optional] [readonly] 
**EndTime** | **System.DateTime** | The time when the workflow reached a final state. | [optional] [readonly] 
**FailedWorkflowCleanupDuration** | **Int64** | The duration in hours after which the workflow info for failed, terminated or timed out workflow will be removed from database. | [optional] [default to 2160]
**VarInput** | [**AnyType**](.md) | All the given inputs for the workflow. | [optional] 
**InstId** | **String** | A workflow instance Id which is the unique identified for the workflow execution. | [optional] [readonly] 
**Internal** | **Boolean** | Denotes if this workflow is internal and should be hidden from user view of running workflows. | [optional] 
**LastAction** | **String** | The last action that was issued on the workflow is saved in this field. * &#x60;None&#x60; - No action is set, this is the default value for action field. * &#x60;Create&#x60; - Create a new instance of the workflow but it does not start the execution of the workflow. Use the Start action to start execution of the workflow. * &#x60;Start&#x60; - Start a new execution of the workflow. * &#x60;Pause&#x60; - Pause the workflow, this can only be issued on workflows that are in running state. * &#x60;Resume&#x60; - Resume the workflow which was previously paused through pause action on the workflow. * &#x60;Retry&#x60; - Retry the workflow that has previously reached a final state and has the retryable property set to true on the workflow. A running or waiting workflow cannot be retried. If the property retryFromTaskName is also passed along with this action, the workflow will be started from that specific task, otherwise the workflow will be restarted. The task name must be one of the tasks that completed or failed in the previous run, you cannot retry a workflow from a task which wasn&#39;t run in the previous iteration. * &#x60;RetryFailed&#x60; - Retry the workflow that has failed. A running or waiting workflow or a workflow that completed successfully cannot be retried. Only the tasks that failed in the previous run will be retried and the rest of workflow will be run. This action does not restart the workflow and also does not support retrying from a specific task. * &#x60;Cancel&#x60; - Cancel the workflow that is in running or waiting state. | [optional] [readonly] [default to "None"]
**Message** | [**WorkflowMessage[]**](WorkflowMessage.md) |  | [optional] 
**MetaVersion** | **Int64** | Version of the workflow metadata for which this workflow execution was started. | [optional] 
**Name** | **String** | A name of the workflow execution instance. | [optional] 
**Output** | [**AnyType**](.md) | All the generated outputs for the workflow. | [optional] [readonly] 
**PauseReason** | **String** | Denotes the reason workflow is in paused status. * &#x60;None&#x60; - Pause reason is none, which indicates there is no reason for the pause state. * &#x60;TaskWithWarning&#x60; - Pause reason indicates the workflow is in this state due to a task that has a status as completed with warnings. | [optional] [default to "None"]
**Progress** | **Double** | This field indicates percentage of workflow task execution. | [optional] [readonly] 
**Properties** | [**WorkflowWorkflowInfoProperties**](WorkflowWorkflowInfoProperties.md) |  | [optional] 
**RetryFromTaskName** | **String** | This field is applicable when Retry action is issued for a workflow which is in a final state. When this field is not specified then the workflow will retry from the start of the workflow. When this field is specified then the workflow will be retried from the specified task. The field should carry the task name which is the unique name of the task within the workflow. The task name must be one of the tasks that completed or failed in the previous run, you cannot retry a workflow from a task which wasn&#39;t run in the previous iteration. | [optional] 
**Src** | **String** | The source microservice name which is the owner for this workflow. | [optional] [readonly] 
**StartTime** | **System.DateTime** | The time when the workflow was started for execution. | [optional] [readonly] 
**Status** | **String** | A status of the workflow (RUNNING, WAITING, COMPLETED, TIME_OUT, FAILED). | [optional] [readonly] 
**SuccessWorkflowCleanupDuration** | **Int64** | The duration in hours after which the workflow info for successful workflow will be removed from database. | [optional] [default to 2160]
**TraceId** | **String** | The trace id to keep track of workflow execution. | [optional] [readonly] 
**Type** | **String** | A type of the workflow (serverconfig, ansible_monitoring). | [optional] [readonly] 
**UserActionRequired** | **Boolean** | Property will be set when an user action is required on the workflow. This can be because the workflow is waiting for a wait task to be updated, workflow is paused or workflow launched by a configuration object has failed and needs to be retried in order to complete successfully. | [optional] [readonly] [default to $false]
**UserId** | **String** | The user identifier which indicates the user that started this workflow. | [optional] [readonly] 
**WaitReason** | **String** | Denotes the reason workflow is in waiting status. * &#x60;None&#x60; - Wait reason is none, which indicates there is no reason for the waiting state. * &#x60;GatherTasks&#x60; - Wait reason is gathering tasks, which indicates the workflow is in this state in order to gather tasks. * &#x60;Duplicate&#x60; - Wait reason is duplicate, which indicates the workflow is a duplicate of current running workflow. * &#x60;RateLimit&#x60; - Wait reason is rate limit, which indicates the workflow is rate limited by account/instance level throttling threshold. * &#x60;WaitTask&#x60; - Wait reason when there are one or more wait tasks in the workflow which are yet to receive a task status update. * &#x60;PendingRetryFailed&#x60; - Wait reason when the workflow is pending a RetryFailed action. | [optional] [default to "None"]
**WorkflowCtx** | [**WorkflowWorkflowCtx**](WorkflowWorkflowCtx.md) |  | [optional] 
**WorkflowMetaType** | **String** | The type of workflow meta. Derived from the workflow meta that is used to launch this workflow instance. * &#x60;SystemDefined&#x60; - System defined workflow definition. * &#x60;UserDefined&#x60; - User defined workflow definition. * &#x60;Dynamic&#x60; - Dynamically defined workflow definition. | [optional] [default to "SystemDefined"]
**WorkflowTaskCount** | **Int64** | Total number of workflow tasks in this workflow. | [optional] [readonly] 
**Var0RollbackWorkflow** | [**WorkflowRollbackWorkflowRelationship**](WorkflowRollbackWorkflowRelationship.md) |  | [optional] 
**Var1SwitchProfile** | [**FabricSwitchProfileRelationship**](FabricSwitchProfileRelationship.md) |  | [optional] 
**Var2ClusterProfile** | [**HyperflexClusterProfileRelationship**](HyperflexClusterProfileRelationship.md) |  | [optional] 
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
$WorkflowWorkflowInfoRelationship = Initialize-IntersightWorkflowWorkflowInfoRelationship  -ClassId null `
 -ObjectType null `
 -Moid null `
 -Selector null `
 -Link null `
 -AccountMoid null `
 -CreateTime null `
 -DomainGroupMoid null `
 -ModTime null `
 -Owners null `
 -SharedScope null `
 -Tags null `
 -VersionContext null `
 -Ancestors null `
 -Parent null `
 -PermissionResources null `
 -DisplayNames null `
 -Action null `
 -CleanupTime null `
 -Email null `
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
 -UserActionRequired null `
 -UserId null `
 -WaitReason null `
 -WorkflowCtx null `
 -WorkflowMetaType null `
 -WorkflowTaskCount null `
 -Var0RollbackWorkflow null `
 -Var1SwitchProfile null `
 -Var2ClusterProfile null `
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
$WorkflowWorkflowInfoRelationship | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

