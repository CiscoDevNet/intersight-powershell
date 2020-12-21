# WorkflowWaitTaskPrompt
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.WaitTaskPrompt"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.WaitTaskPrompt"]
**Description** | **String** | Description that give more details about what it means to pick this prompt option for the wait task. | [optional] 
**Label** | **String** | User friendly label for the prompt. This label will be shown to the user as one of available options for the wait task. | [optional] 
**Name** | **String** | Name for the wait prompt. | [optional] 
**TaskStatus** | **String** | Task status for the wait task when this prompt option is selected. * &#x60;Scheduled&#x60; - The enum represents the status when task is in scheduled state. * &#x60;InProgress&#x60; - The enum represents the status when task is in-progress state. * &#x60;NoOp&#x60; - The enum represents the status when task is a noop. * &#x60;Timeout&#x60; - The enum represents the status when task has timed out. * &#x60;Completed&#x60; - The enum represents the status when task has completed. * &#x60;Failed&#x60; - The enum represents the status when task has failed. | [optional] [default to "Scheduled"]

## Examples

- Prepare the resource
```powershell
$WorkflowWaitTaskPrompt = Initialize-IntersightWorkflowWaitTaskPrompt  -ClassId null `
 -ObjectType null `
 -Description null `
 -Label null `
 -Name null `
 -TaskStatus null
```

- Convert the resource to JSON
```powershell
$WorkflowWaitTaskPrompt | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

