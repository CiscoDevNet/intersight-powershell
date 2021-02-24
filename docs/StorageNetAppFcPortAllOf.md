# StorageNetAppFcPortAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppFcPort"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppFcPort"]
**PortStatus** | **String** | Status of storage array port. | [optional] [readonly] 
**State** | **String** | State of the port available in storage array. * &#x60;Unknown&#x60; - Default unknown port state. * &#x60;StartUp&#x60; - The port in the storage array is booting up. * &#x60;LinkNotConnected&#x60; - The port has finished initialization, but a link with the fabric is not established. * &#x60;Online&#x60; - The port is initialized and a link with the fabric has been established. * &#x60;LinkDisconnected&#x60; - The link on this port is currently not established. * &#x60;OfflineUser&#x60; - The port is administratively disabled. * &#x60;OfflineSystem&#x60; - The port is set to offline by the system. This happens when the port encounters too many errors. * &#x60;NodeOffline&#x60; - The state information for the port cannot be retrieved. The node is offline or inaccessible. | [optional] [readonly] [default to "Unknown"]
**Uuid** | **String** | UUID of physical port. | [optional] [readonly] 
**ArrayController** | [**StorageNetAppNodeRelationship**](StorageNetAppNodeRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageNetAppFcPortAllOf = Initialize-IntersightStorageNetAppFcPortAllOf  -ClassId null `
 -ObjectType null `
 -PortStatus null `
 -State null `
 -Uuid null `
 -ArrayController null
```

- Convert the resource to JSON
```powershell
$StorageNetAppFcPortAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

