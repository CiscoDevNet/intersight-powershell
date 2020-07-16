# WorkflowWorkflowInfoRelationship
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The fully-qualified type of this managed object, i.e. the class name. This property is optional. The ObjectType is implied from the URL path. If specified, the value of objectType must match the class name specified in the URL path. | [readonly] 
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
**DisplayNames** | [**System.Collections.Hashtable**](Array.md) | a map of display names for a resource. | [optional] [readonly] 
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
Initialize-IntersightWorkflowWorkflowInfoRelationship  -ClassId null `
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

