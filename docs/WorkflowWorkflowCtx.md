# WorkflowWorkflowCtx
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**InitiatorCtx** | [**WorkflowInitiatorContext**](WorkflowInitiatorContext.md) |  | [optional] 
**TargetCtxList** | [**WorkflowTargetContext[]**](WorkflowTargetContext.md) |  | [optional] 
**WorkflowSubtype** | **String** | The subtype of the workflow. | [optional] 
**WorkflowType** | **String** | Type of the workflow being started. This can be any string for client services to distinguish workflow by type. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowWorkflowCtx  -ClassId null `
 -ObjectType null `
 -InitiatorCtx null `
 -TargetCtxList null `
 -WorkflowSubtype null `
 -WorkflowType null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

