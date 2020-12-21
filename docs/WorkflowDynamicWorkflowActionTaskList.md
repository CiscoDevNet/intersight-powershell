# WorkflowDynamicWorkflowActionTaskList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.DynamicWorkflowActionTaskList"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.DynamicWorkflowActionTaskList"]
**Action** | **String** | The action of the Dynamic Workflow. | [optional] 
**Tasks** | [**AnyType**](.md) | The task list that has precedence which dictates how the workflow should be constructed. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowDynamicWorkflowActionTaskList = Initialize-IntersightWorkflowDynamicWorkflowActionTaskList  -ClassId null `
 -ObjectType null `
 -Action null `
 -Tasks null
```

- Convert the resource to JSON
```powershell
$WorkflowDynamicWorkflowActionTaskList | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

