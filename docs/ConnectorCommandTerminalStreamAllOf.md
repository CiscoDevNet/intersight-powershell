# ConnectorCommandTerminalStreamAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MsgType** | **String** | The type of data this message contains. | [optional] 
**Sequence** | **Int64** | Sequence of the message within a session to handle out-of-order delivery. | [optional] 
**Stream** | [**SystemByte**](SystemByte.md) | The input/output payload to/from the pseudo terminal session. When sent from the cloud service if the msgType is CommandInput stream is piped to stdin of the command or a resize message if msgType is CommandResize. From the device connector value is always the combined output of stdout &amp; stderr. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConnectorCommandTerminalStreamAllOf  -MsgType null `
 -Sequence null `
 -Stream null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

