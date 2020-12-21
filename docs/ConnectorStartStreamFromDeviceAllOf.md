# ConnectorStartStreamFromDeviceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "connector.StartStreamFromDevice"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "connector.StartStreamFromDevice"]
**MemberId** | **String** | The asset.ClusterMember member identity that is opening this stream. | [optional] 
**MemberStream** | **Boolean** | The stream is to be started against the cluster member. | [optional] 
**StreamConfig** | [**AnyType**](.md) | Any extra configuration needed to open/identify a stream. | [optional] 
**StreamType** | **String** | Identifies the type of stream to open to the device. The Intersight service will validate that the device should open a stream of this type and if so build a stream configuration and send it down to the device. The streamType should identify a unique stream to open to a device, that is if the device sends a stream open message and a stream of that type is already open in the cloud the existing stream should be re-used. | [optional] 
**Topic** | **String** | The topic the device should send the stream open message to. | [optional] 

## Examples

- Prepare the resource
```powershell
$ConnectorStartStreamFromDeviceAllOf = Initialize-IntersightConnectorStartStreamFromDeviceAllOf  -ClassId null `
 -ObjectType null `
 -MemberId null `
 -MemberStream null `
 -StreamConfig null `
 -StreamType null `
 -Topic null
```

- Convert the resource to JSON
```powershell
$ConnectorStartStreamFromDeviceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

