# WorkflowPendingDynamicWorkflowInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarInput** | [**AnyType**](.md) | The inputs of the workflow. | [optional] 
**Name** | **String** | A name for the pending dynamic workflow. | [optional] 
**PendingServices** | **String[]** |  | [optional] 
**Src** | **String** | The src is workflow owner service. | [optional] 
**Status** | **String** | The current status of the PendingDynamicWorkflowInfo. | [optional] [default to "GatheringTasks"]
**WaitOnDuplicate** | **Boolean** | When set to true workflow engine will wait for a duplicate to finish before starting a new one. | [optional] 
**WorkflowActionTaskLists** | [**WorkflowDynamicWorkflowActionTaskList[]**](WorkflowDynamicWorkflowActionTaskList.md) |  | [optional] 
**WorkflowCtx** | [**WorkflowWorkflowCtx**](WorkflowWorkflowCtx.md) |  | [optional] 
**WorkflowKey** | **String** | This key contains workflow, initiator and target name. Workflow engine uses the key to do workflow dedup. | [optional] 
**WorkflowMeta** | [**AnyType**](.md) | The metadata of the workflow. | [optional] 
**WorkflowInfo** | [**WorkflowWorkflowInfoRelationship**](WorkflowWorkflowInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowPendingDynamicWorkflowInfoAllOf  -VarInput null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

