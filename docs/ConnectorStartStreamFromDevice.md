# ConnectorStartStreamFromDevice
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "connector.StartStreamFromDevice"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "connector.StartStreamFromDevice"]
**EncryptedAesKey** | **String** | The secure properties that have large text content as value can be encrypted using AES key. In these cases, the AES key needs to be encrypted using the device connector public key and passed as the value for this property. The secure properties that are encrypted using the AES key are mapped against the property name with prefix &#39;AES&#39; in SecureProperties dictionary. | [optional] 
**EncryptionKey** | **String** | The public key that was used to encrypt the values present in SecureProperties dictionary. If the given public key is not same as device connector&#39;s public key, an error reponse with appropriate error message is thrown back. | [optional] 
**SecureProperties** | [**AnyType**](.md) | A dictionary of encrypted secure values mapped against the secure property name. The values that are encrypted using AES key must be mapped against the secure property name with a &#39;AES&#39; prefix Device connector expects the message body to be a golang template and the template can use the secure property names as placeholders. | [optional] 
**StreamName** | **String** | The requested stream name. Stream names are unique per device endpoint. | [optional] 
**MemberId** | **String** | The asset.ClusterMember member identity that is opening this stream. | [optional] 
**MemberStream** | **Boolean** | The stream is to be started against the cluster member. | [optional] 
**StreamConfig** | [**AnyType**](.md) | Any extra configuration needed to open/identify a stream. | [optional] 
**StreamType** | **String** | Identifies the type of stream to open to the device. The Intersight service will validate that the device should open a stream of this type and if so build a stream configuration and send it down to the device. The streamType should identify a unique stream to open to a device, that is if the device sends a stream open message and a stream of that type is already open in the cloud the existing stream should be re-used. | [optional] 
**Topic** | **String** | The topic the device should send the stream open message to. | [optional] 

## Examples

- Prepare the resource
```powershell
$ConnectorStartStreamFromDevice = Initialize-IntersightConnectorStartStreamFromDevice  -ClassId null `
 -ObjectType null `
 -EncryptedAesKey null `
 -EncryptionKey null `
 -SecureProperties null `
 -StreamName null `
 -MemberId null `
 -MemberStream null `
 -StreamConfig null `
 -StreamType null `
 -Topic null
```

- Convert the resource to JSON
```powershell
$ConnectorStartStreamFromDevice | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

