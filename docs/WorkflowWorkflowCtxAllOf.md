# WorkflowWorkflowCtxAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.WorkflowCtx"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.WorkflowCtx"]
**InitiatorCtx** | [**WorkflowInitiatorContext**](WorkflowInitiatorContext.md) |  | [optional] 
**TargetCtxList** | [**WorkflowTargetContext[]**](WorkflowTargetContext.md) |  | [optional] 
**WorkflowMetaName** | **String** | The name of workflowMeta of the workflow running. | [optional] 
**WorkflowSubtype** | **String** | The subtype of the workflow. | [optional] 
**WorkflowType** | **String** | Type of the workflow being started. This can be any string for client services to distinguish workflow by type. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowWorkflowCtxAllOf = Initialize-IntersightWorkflowWorkflowCtxAllOf  -ClassId null `
 -ObjectType null `
 -InitiatorCtx null `
 -TargetCtxList null `
 -WorkflowMetaName null `
 -WorkflowSubtype null `
 -WorkflowType null
```

- Convert the resource to JSON
```powershell
$WorkflowWorkflowCtxAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

