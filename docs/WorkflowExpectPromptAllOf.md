# WorkflowExpectPromptAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Expect** | **String** | The regex of the expect prompt of the interactive command. | [optional] 
**Send** | **String** | The answer string to the expect prompt. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowExpectPromptAllOf  -Expect null `
 -Send null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

