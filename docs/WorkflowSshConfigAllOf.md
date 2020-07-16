# WorkflowSshConfigAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Password** | **String** | Password to use in the SSH connection credentials (If empty then private key will be used). | [optional] 
**Target** | **String** | The remote server to connect to. IPv4 address represented in dot decimal notation. | [optional] 
**User** | **String** | Username for the remote SSH connection. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowSshConfigAllOf  -Password null `
 -Target null `
 -User null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

