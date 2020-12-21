# WorkflowExpectPromptAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.ExpectPrompt"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.ExpectPrompt"]
**Expect** | **String** | The regex of the expect prompt of the interactive command. | [optional] 
**Send** | **String** | The answer string to the expect prompt. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowExpectPromptAllOf = Initialize-IntersightWorkflowExpectPromptAllOf  -ClassId null `
 -ObjectType null `
 -Expect null `
 -Send null
```

- Convert the resource to JSON
```powershell
$WorkflowExpectPromptAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

