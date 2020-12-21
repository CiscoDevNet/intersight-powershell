# AssetConnectionControlMessageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.ConnectionControlMessage"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.ConnectionControlMessage"]
**Account** | **String** | The account id to which the device belongs. | [optional] 
**ConnectorVersion** | **String** | The version of the device connector currently running on the platform. Deprecated by newer connectors that will report this directly to the device connector gateway in a websocket header, but included to continue to support older versions which report any version change after connect. | [optional] 
**DeviceId** | **String** | The Moid of the device under change. Used to route the message to a devices connection. | [optional] 
**DomainGroup** | **String** | The domain group id to which the device belongs. | [optional] 
**Evict** | **Boolean** | Flag to force any open connections to be evicted. Used in case device has been deleted or blacklisted. | [optional] 
**Leadership** | **String** | The current leadership of a device cluster member. * &#x60;Unknown&#x60; - The node is unable to complete election or determine the current state. If the device has been registered before and the node has access to the current credentials it will establish a connection to Intersight with limited capabilities that can be used to debug the HA failure from Intersight. * &#x60;Primary&#x60; - The node has been elected as the primary and will establish a connection to the Intersight service and accept all message types enabled for a primary node. There can only be one primary in a given cluster, while the underlying platform may be active-active only one connector will assume the primary role. * &#x60;Secondary&#x60; - The node has been elected as a secondary node in the cluster. The device connector will establish a connection to the Intersight service with limited capabilities. e.g. file upload will be enabled, but requests to the underlying platform management will be disabled. | [optional] [default to "Unknown"]
**NewIdentity** | **String** | The new identity assigned to a device on ownership change (claim/unclaim). | [optional] 
**Partition** | **Int64** | The partition the device was last connected to, used to address the control message to the device connector gateway instance holding the devices connection. | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetConnectionControlMessageAllOf = Initialize-IntersightAssetConnectionControlMessageAllOf  -ClassId null `
 -ObjectType null `
 -Account null `
 -ConnectorVersion null `
 -DeviceId null `
 -DomainGroup null `
 -Evict null `
 -Leadership null `
 -NewIdentity null `
 -Partition null
```

- Convert the resource to JSON
```powershell
$AssetConnectionControlMessageAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

