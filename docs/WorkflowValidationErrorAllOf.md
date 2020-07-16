# WorkflowValidationErrorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ErrorLog** | [**AnyType**](.md) | Description of the error.} type: string | [optional] [readonly] 
**Field** | **String** | When populated this refers to the input or output field within the workflow or task. | [optional] [readonly] 
**TaskName** | **String** | The task name on which the error is found, when empty the error applies to the top level workflow. | [optional] [readonly] 
**TransitionName** | **String** | When populated this refers to the transition connection that has a problem. When this field has value OnSuccess it means the transition connection OnSuccess for the task has an issue. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowValidationErrorAllOf  -ErrorLog null `
 -Field null `
 -TaskName null `
 -TransitionName null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

