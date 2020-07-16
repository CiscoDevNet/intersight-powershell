# WorkflowSshSessionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileTransferToRemote** | [**WorkflowFileTransfer**](WorkflowFileTransfer.md) |  | [optional] 
**MessageType** | **String** | The type of SSH message to send to the remote server. | [optional] [default to "ExecuteCommand"]
**SshCommand** | [**WorkflowSshCmd**](WorkflowSshCmd.md) |  | [optional] 
**SshConfiguration** | [**WorkflowSshConfig**](WorkflowSshConfig.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowSshSessionAllOf  -FileTransferToRemote null `
 -MessageType null `
 -SshCommand null `
 -SshConfiguration null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

