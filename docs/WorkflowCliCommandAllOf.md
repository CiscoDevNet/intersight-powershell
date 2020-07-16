# WorkflowCliCommandAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **String** | The command to run on the device connector. | [optional] 
**EndPrompt** | **String** | The regex string that identifies the end of the command response. | [optional] 
**ExpectPrompts** | [**WorkflowExpectPrompt[]**](WorkflowExpectPrompt.md) |  | [optional] 
**SkipStatusCheck** | **Boolean** | Skips the execution status check of the terminal command. One use case for this is while exiting the terminal session from esxi host. | [optional] 
**TerminalEnd** | **Boolean** | If this flag is set, it marks the end of the terminal session where the previous commands were executed. | [optional] 
**TerminalStart** | **Boolean** | If this flag is set, the execution of this command initiates a terminal session in which the subsequent CLI commands are executed until a command with terminalEnd flag is encountered or the end of the batch. | [optional] 
**Type** | **String** | The type of the command - can be interactive or non-interactive. | [optional] [default to "NonInteractive"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowCliCommandAllOf  -Command null `
 -EndPrompt null `
 -ExpectPrompts null `
 -SkipStatusCheck null `
 -TerminalEnd null `
 -TerminalStart null `
 -Type null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

