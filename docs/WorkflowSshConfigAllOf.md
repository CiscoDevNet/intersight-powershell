# WorkflowSshConfigAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.SshConfig"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.SshConfig"]
**Password** | **String** | Password to use in the SSH connection credentials (If empty then private key will be used). | [optional] 
**Target** | **String** | The remote server to connect to. IPv4 address represented in dot decimal notation. | [optional] 
**User** | **String** | Username for the remote SSH connection. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowSshConfigAllOf = Initialize-IntersightWorkflowSshConfigAllOf  -ClassId null `
 -ObjectType null `
 -Password null `
 -Target null `
 -User null
```

- Convert the resource to JSON
```powershell
$WorkflowSshConfigAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

