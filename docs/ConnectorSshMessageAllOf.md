# ConnectorSshMessageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "connector.SshMessage"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "connector.SshMessage"]
**ExpectPrompts** | [**ConnectorExpectPrompt[]**](ConnectorExpectPrompt.md) |  | [optional] 
**MsgType** | **Int64** | The operation to execute on a new or existing session. | [optional] 
**SessionId** | **String** | Unique id of session to route messages to. | [optional] 
**ShellPrompt** | **String** | The regex of the secure shell prompt. | [optional] 
**Stream** | [**SystemByte**](SystemByte.md) | Input to the SSH operation to be executed. e.g. file contents to write. | [optional] 
**Timeout** | **Int64** | The timeout for the ssh command to complete and exit after starting or receiving input. If timeout is not set a default of 10 minutes will be used. | [optional] 

## Examples

- Prepare the resource
```powershell
$ConnectorSshMessageAllOf = Initialize-IntersightConnectorSshMessageAllOf  -ClassId null `
 -ObjectType null `
 -ExpectPrompts null `
 -MsgType null `
 -SessionId null `
 -ShellPrompt null `
 -Stream null `
 -Timeout null
```

- Convert the resource to JSON
```powershell
$ConnectorSshMessageAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

