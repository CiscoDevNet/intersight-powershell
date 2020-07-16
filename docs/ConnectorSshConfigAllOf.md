# ConnectorSshConfigAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Password** | **String** | Password to use in the connection credentials (If empty the private key will be used). | [optional] 
**Pkey** | [**SystemByte**](SystemByte.md) | The private key to use in the connection credentials (Optional if password is given). | [optional] 
**Target** | **String** | The remote server to connect to. | [optional] 
**User** | **String** | Username for the remote connection. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConnectorSshConfigAllOf  -Password null `
 -Pkey null `
 -Target null `
 -User null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

