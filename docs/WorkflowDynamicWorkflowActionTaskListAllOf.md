# WorkflowDynamicWorkflowActionTaskListAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **String** | The action of the Dynamic Workflow. | [optional] 
**Tasks** | [**AnyType**](.md) | The task list that has precedence which dictates how the workflow should be constructed. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowDynamicWorkflowActionTaskListAllOf  -Action null `
 -Tasks null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

