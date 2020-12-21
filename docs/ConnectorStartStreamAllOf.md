# ConnectorStartStreamAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "connector.StartStream"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "connector.StartStream"]
**BatchSize** | **Int64** | The number of outputs from a plugin to collect into a single message. Applicable only to streams that involve polling plugins and plugins which support emitting batchable data. Default value of zero indicates no batching. | [optional] 
**ForceRebuild** | **Boolean** | Flag to force a rebuild of an existing stream. To be used if a stream is unable to recover itself in response to dropped messages. | [optional] 
**VarInput** | [**SystemByte**](SystemByte.md) | Input to the plugin to start the start the stream or collect stream messages. | [optional] 
**KeepAliveInterval** | **Int64** | Interval at which device should emit a keepalive message for this stream. Device will also expect a keepalive response from the cloud within the interval. If zero, no keepalive is required and stream should not timeout. | [optional] 
**PluginName** | **String** | The plugin to run the stream on. | [optional] 
**PollInterval** | **Int64** | The desired interval to emit messages from this stream. The stream plugin will poll plugins at this interval to create a stream event. | [optional] 
**Priority** | **Int64** | The priority level to apply to messages emitted by this stream. | [optional] 
**ProtocolVersion** | **Int64** | The version of the device connector stream protocol. Used to change behavior of the device connector stream plugin based on the version of the Intersight service. Allows for multiple versions of Intersight services to interact with the stream plugin of devices. | [optional] 
**ResponseTopic** | **String** | The topic for the device connector to publish messages to. | [optional] 

## Examples

- Prepare the resource
```powershell
$ConnectorStartStreamAllOf = Initialize-IntersightConnectorStartStreamAllOf  -ClassId null `
 -ObjectType null `
 -BatchSize null `
 -ForceRebuild null `
 -VarInput null `
 -KeepAliveInterval null `
 -PluginName null `
 -PollInterval null `
 -Priority null `
 -ProtocolVersion null `
 -ResponseTopic null
```

- Convert the resource to JSON
```powershell
$ConnectorStartStreamAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

