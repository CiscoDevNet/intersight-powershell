# WorkflowWorkflowCtxAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InitiatorCtx** | [**WorkflowInitiatorContext**](WorkflowInitiatorContext.md) |  | [optional] 
**TargetCtxList** | [**WorkflowTargetContext[]**](WorkflowTargetContext.md) |  | [optional] 
**WorkflowSubtype** | **String** | The subtype of the workflow. | [optional] 
**WorkflowType** | **String** | Type of the workflow being started. This can be any string for client services to distinguish workflow by type. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowWorkflowCtxAllOf  -InitiatorCtx null `
 -TargetCtxList null `
 -WorkflowSubtype null `
 -WorkflowType null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

