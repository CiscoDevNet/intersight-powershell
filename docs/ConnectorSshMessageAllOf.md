# ConnectorSshMessageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpectPrompts** | [**ConnectorExpectPrompt[]**](ConnectorExpectPrompt.md) |  | [optional] 
**MsgType** | **Int64** | The operation to execute on a new or existing session. | [optional] 
**SessionId** | **String** | Unique id of session to route messages to. | [optional] 
**ShellPrompt** | **String** | The regex of the secure shell prompt. | [optional] 
**Stream** | [**SystemByte**](SystemByte.md) | Input to the SSH operation to be executed. e.g. file contents to write. | [optional] 
**Timeout** | **Int64** | The timeout for the ssh command to complete and exit after starting or receiving input. If timeout is not set a default of 10 minutes will be used. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConnectorSshMessageAllOf  -ExpectPrompts null `
 -MsgType null `
 -SessionId null `
 -ShellPrompt null `
 -Stream null `
 -Timeout null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

