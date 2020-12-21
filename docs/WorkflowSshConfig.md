# WorkflowSshConfig
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.SshConfig"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.SshConfig"]
**EncryptedAesKey** | **String** | The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property. The secure properties that are encrypted using the AES key are mapped against the property name with prefix &#39;AES&#39; in SecureProperties dictionary. | [optional] 
**EncryptionKey** | **String** | The public key that was used to encrypt the values present in SecureProperties dictionary. If the given public key is not same as device connector&#39;s public key, an error reponse with appropriate error message is thrown back. | [optional] 
**SecureProperties** | [**AnyType**](.md) | A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a &#39;AES&#39; prefix Device connector expects the message body to be a golang template and the template can use the secure property names as placeholders. | [optional] 
**Password** | **String** | Password to use in the SSH connection credentials (If empty then private key will be used). | [optional] 
**Target** | **String** | The remote server to connect to. IPv4 address represented in dot decimal notation. | [optional] 
**User** | **String** | Username for the remote SSH connection. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowSshConfig = Initialize-IntersightWorkflowSshConfig  -ClassId null `
 -ObjectType null `
 -EncryptedAesKey null `
 -EncryptionKey null `
 -SecureProperties null `
 -Password null `
 -Target null `
 -User null
```

- Convert the resource to JSON
```powershell
$WorkflowSshConfig | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

