# WorkflowSshCmdAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.SshCmd"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.SshCmd"]
**Command** | **String** | SSH command to execute on the remote server. | [optional] 
**CommandType** | **String** | SSH command type to execute on the remote server. * &#x60;NonInteractiveCmd&#x60; - Execute a non-interactive SSH command on the remote server. * &#x60;InteractiveCmd&#x60; - Execute an interactive SSH command on the remote server. | [optional] [default to "NonInteractiveCmd"]
**ExpectPrompts** | [**ConnectorExpectPrompt[]**](ConnectorExpectPrompt.md) |  | [optional] 
**ShellPrompt** | **String** | Regex of the remote server&#39;s shell prompt. | [optional] 
**ShellPromptTimeout** | **Int64** | Expect timeout value in seconds for the shell prompt. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowSshCmdAllOf = Initialize-IntersightWorkflowSshCmdAllOf  -ClassId null `
 -ObjectType null `
 -Command null `
 -CommandType null `
 -ExpectPrompts null `
 -ShellPrompt null `
 -ShellPromptTimeout null
```

- Convert the resource to JSON
```powershell
$WorkflowSshCmdAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

