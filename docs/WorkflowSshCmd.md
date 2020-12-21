# WorkflowSshCmd
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.SshCmd"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.SshCmd"]
**EncryptedAesKey** | **String** | The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property. The secure properties that are encrypted using the AES key are mapped against the property name with prefix &#39;AES&#39; in SecureProperties dictionary. | [optional] 
**EncryptionKey** | **String** | The public key that was used to encrypt the values present in SecureProperties dictionary. If the given public key is not same as device connector&#39;s public key, an error reponse with appropriate error message is thrown back. | [optional] 
**SecureProperties** | [**AnyType**](.md) | A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a &#39;AES&#39; prefix Device connector expects the message body to be a golang template and the template can use the secure property names as placeholders. | [optional] 
**Command** | **String** | SSH command to execute on the remote server. | [optional] 
**CommandType** | **String** | SSH command type to execute on the remote server. * &#x60;NonInteractiveCmd&#x60; - Execute a non-interactive SSH command on the remote server. * &#x60;InteractiveCmd&#x60; - Execute an interactive SSH command on the remote server. | [optional] [default to "NonInteractiveCmd"]
**ExpectPrompts** | [**ConnectorExpectPrompt[]**](ConnectorExpectPrompt.md) |  | [optional] 
**ShellPrompt** | **String** | Regex of the remote server&#39;s shell prompt. | [optional] 
**ShellPromptTimeout** | **Int64** | Expect timeout value in seconds for the shell prompt. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowSshCmd = Initialize-IntersightWorkflowSshCmd  -ClassId null `
 -ObjectType null `
 -EncryptedAesKey null `
 -EncryptionKey null `
 -SecureProperties null `
 -Command null `
 -CommandType null `
 -ExpectPrompts null `
 -ShellPrompt null `
 -ShellPromptTimeout null
```

- Convert the resource to JSON
```powershell
$WorkflowSshCmd | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

