# WorkflowValidationError
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.ValidationError"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.ValidationError"]
**ErrorLog** | **String** | Description of the error. | [optional] [readonly] 
**Field** | **String** | When populated this refers to the input or output field within the workflow or task. | [optional] [readonly] 
**TaskName** | **String** | The task name on which the error is found, when empty the error applies to the top level workflow. | [optional] [readonly] 
**TransitionName** | **String** | When populated this refers to the transition connection that has a problem. When this field has value OnSuccess it means the transition connection OnSuccess for the task has an issue. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$WorkflowValidationError = Initialize-IntersightWorkflowValidationError  -ClassId null `
 -ObjectType null `
 -ErrorLog null `
 -Field null `
 -TaskName null `
 -TransitionName null
```

- Convert the resource to JSON
```powershell
$WorkflowValidationError | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

