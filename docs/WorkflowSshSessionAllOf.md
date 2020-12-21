# WorkflowSshSessionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.SshSession"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.SshSession"]
**FileTransferToRemote** | [**WorkflowFileTransfer**](WorkflowFileTransfer.md) |  | [optional] 
**MessageType** | **String** | The type of SSH message to send to the remote server. * &#x60;ExecuteCommand&#x60; - Execute a SSH command on the remote server. * &#x60;NewSession&#x60; - Open a new SSH connection to the remote server. * &#x60;FileTransfer&#x60; - Transfer a file from Intersight connected device to the remote server. * &#x60;CloseSession&#x60; - Close the SSH connection to the remote server. | [optional] [default to "ExecuteCommand"]
**SshCommand** | [**WorkflowSshCmd**](WorkflowSshCmd.md) |  | [optional] 
**SshConfiguration** | [**WorkflowSshConfig**](WorkflowSshConfig.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowSshSessionAllOf = Initialize-IntersightWorkflowSshSessionAllOf  -ClassId null `
 -ObjectType null `
 -FileTransferToRemote null `
 -MessageType null `
 -SshCommand null `
 -SshConfiguration null
```

- Convert the resource to JSON
```powershell
$WorkflowSshSessionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

