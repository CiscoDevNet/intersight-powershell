# WorkflowSshCmdAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **String** | SSH command to execute on the remote server. | [optional] 
**CommandType** | **String** | SSH command type to execute on the remote server. | [optional] [default to "NonInteractiveCmd"]
**ExpectPrompts** | [**ConnectorExpectPrompt[]**](ConnectorExpectPrompt.md) |  | [optional] 
**ShellPrompt** | **String** | Regex of the remote server&#39;s shell prompt. | [optional] 
**ShellPromptTimeout** | **Int64** | Expect timeout value in seconds for the shell prompt. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowSshCmdAllOf  -Command null `
 -CommandType null `
 -ExpectPrompts null `
 -ShellPrompt null `
 -ShellPromptTimeout null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

