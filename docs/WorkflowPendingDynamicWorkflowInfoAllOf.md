# WorkflowPendingDynamicWorkflowInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.PendingDynamicWorkflowInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.PendingDynamicWorkflowInfo"]
**VarInput** | [**AnyType**](.md) | The inputs of the workflow. | [optional] 
**Name** | **String** | A name for the pending dynamic workflow. | [optional] 
**PendingServices** | **String[]** |  | [optional] 
**Src** | **String** | The src is workflow owner service. | [optional] 
**Status** | **String** | The current status of the PendingDynamicWorkflowInfo. * &#x60;GatheringTasks&#x60; - Dynamic workflow is gathering tasks before workflow can start execution. * &#x60;Waiting&#x60; - Dynamic workflow is in waiting state and not yet started execution. | [optional] [default to "GatheringTasks"]
**WaitOnDuplicate** | **Boolean** | When set to true workflow engine will wait for a duplicate to finish before starting a new one. | [optional] 
**WorkflowActionTaskLists** | [**WorkflowDynamicWorkflowActionTaskList[]**](WorkflowDynamicWorkflowActionTaskList.md) |  | [optional] 
**WorkflowCtx** | [**WorkflowWorkflowCtx**](WorkflowWorkflowCtx.md) |  | [optional] 
**WorkflowKey** | **String** | This key contains workflow, initiator and target name. Workflow engine uses the key to do workflow dedup. | [optional] 
**WorkflowMeta** | [**AnyType**](.md) | The metadata of the workflow. | [optional] 
**WorkflowInfo** | [**WorkflowWorkflowInfoRelationship**](WorkflowWorkflowInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowPendingDynamicWorkflowInfoAllOf = Initialize-IntersightWorkflowPendingDynamicWorkflowInfoAllOf  -ClassId null `
 -ObjectType null `
 -VarInput null `
 -Name null `
 -PendingServices null `
 -Src null `
 -Status null `
 -WaitOnDuplicate null `
 -WorkflowActionTaskLists null `
 -WorkflowCtx null `
 -WorkflowKey null `
 -WorkflowMeta null `
 -WorkflowInfo null
```

- Convert the resource to JSON
```powershell
$WorkflowPendingDynamicWorkflowInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

