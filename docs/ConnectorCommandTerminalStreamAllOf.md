# ConnectorCommandTerminalStreamAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "connector.CommandTerminalStream"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "connector.CommandTerminalStream"]
**MsgType** | **String** | The type of data this message contains. | [optional] 
**Sequence** | **Int64** | Sequence of the message within a session to handle out-of-order delivery. | [optional] 
**Stream** | [**SystemByte**](SystemByte.md) | The input/output payload to/from the pseudo terminal session. When sent from the cloud service if the msgType is CommandInput stream is piped to stdin of the command or a resize message if msgType is CommandResize. From the device connector value is always the combined output of stdout &amp; stderr. | [optional] 

## Examples

- Prepare the resource
```powershell
$ConnectorCommandTerminalStreamAllOf = Initialize-IntersightConnectorCommandTerminalStreamAllOf  -ClassId null `
 -ObjectType null `
 -MsgType null `
 -Sequence null `
 -Stream null
```

- Convert the resource to JSON
```powershell
$ConnectorCommandTerminalStreamAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

