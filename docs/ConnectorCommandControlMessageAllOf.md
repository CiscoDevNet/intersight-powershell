# ConnectorCommandControlMessageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dir** | **String** | The working directory of the command. If empty command is executed in the same directory the device connector process was called. | [optional] 
**MsgType** | **String** | Message carrying the operation to perform. | [optional] 
**Stream** | [**SystemByte**](SystemByte.md) | The command to execute. Commands must be whitelisted by platform implementation, if a command does not match any whitelisted command patterns an error will be returned to the requesting service on command start. | [optional] 
**Terminal** | **Boolean** | Indicates that a pseudo terminal should be attached to the command. Used for interactive commands. e.g A cross launch cli. | [optional] 
**Timeout** | **Int64** | The timeout for the command to complete and exit after starting or receiving input. If timeout is not set a default of 10 minutes will be used. If there is input to the command stream the timeout is extended. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConnectorCommandControlMessageAllOf  -Dir null `
 -MsgType null `
 -Stream null `
 -Terminal null `
 -Timeout null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

