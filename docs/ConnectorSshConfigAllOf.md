# ConnectorSshConfigAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "connector.SshConfig"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "connector.SshConfig"]
**JumpHost** | **String** | A jump host for establishing a connection to a server. Plugin will first establish a connection to this server, then create a tunneled connection to the target host. | [optional] 
**Password** | **String** | Password to use in the connection credentials (If empty the private key will be used). | [optional] 
**Pkey** | [**SystemByte**](SystemByte.md) | The private key to use in the connection credentials (Optional if password is given). | [optional] 
**Target** | **String** | The remote server to connect to. | [optional] 
**User** | **String** | Username for the remote connection. | [optional] 

## Examples

- Prepare the resource
```powershell
$ConnectorSshConfigAllOf = Initialize-IntersightConnectorSshConfigAllOf  -ClassId null `
 -ObjectType null `
 -JumpHost null `
 -Password null `
 -Pkey null `
 -Target null `
 -User null
```

- Convert the resource to JSON
```powershell
$ConnectorSshConfigAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

