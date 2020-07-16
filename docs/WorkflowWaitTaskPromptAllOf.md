# WorkflowWaitTaskPromptAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** | Description that give more details about what it means to pick this prompt option for the wait task. | [optional] 
**Label** | **String** | User friendly label for the prompt. This label will be shown to the user as one of available options for the wait task. | [optional] 
**Name** | **String** | Name for the wait prompt. | [optional] 
**TaskStatus** | **String** | Task status for the wait task when this prompt option is selected. | [optional] [default to "Scheduled"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowWaitTaskPromptAllOf  -Description null `
 -Label null `
 -Name null `
 -TaskStatus null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

