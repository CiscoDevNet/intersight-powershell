# AssetDeviceConnectionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiVersion** | **Int64** | The version of the connector API, describes the capability of the connector&#39;s framework. If the version is lower than the current minimum supported version defined in the service managing the connection, the device connector will be connected with limited capabilities until the device connector is upgraded to a fully supported version. For example if a device connector that was released without delta inventory capabilities registers and connects to Intersight, inventory collection may be disabled until it has been upgraded. | [optional] [readonly] 
**AppPartitionNumber** | **Int64** | The partition number corresponding to the instance of the Proxy App which is managing the web-socket to the device connector. | [optional] [readonly] 
**ConnectionId** | **String** | The unique identifier for the current connection. The identifier persists across network connectivity loss and is reset on device connector process restart or platform administrator toggle of the Intersight connectivity. The connectionId can be used by services that need to interact with stateful plugins running in the device connector process. For example if a service schedules an inventory in a devices job scheduler plugin at registration it is not necessary to reschedule the job if the device loses network connectivity due to an Intersight service upgrade or intermittent network issues in the devices datacenter. | [optional] [readonly] 
**ConnectionReason** | **String** | If &#39;connectionStatus&#39; is not equal to Connected, connectionReason provides further details about why the device is not connected with Intersight. | [optional] [readonly] 
**ConnectionStatus** | **String** | The status of the persistent connection between the device connector and Intersight. | [optional] [readonly] [default to ""]
**ConnectionStatusLastChangeTime** | **System.DateTime** | The last time at which the &#39;connectionStatus&#39; property value changed. If connectionStatus is Connected, this time can be interpreted as the starting time since which a persistent connection has been maintained between Intersight and Device Connector. If connectionStatus is NotConnected, this time can be interpreted as the last time the device connector was connected with Intersight. | [optional] [readonly] 
**ConnectorVersion** | **String** | The version of the device connector running on the managed device. | [optional] [readonly] 
**DeviceExternalIpAddress** | **String** | The IP Address of the managed device as seen from Intersight at the time of registration. This could be the IP address of the managed device&#39;s interface which has a route to the internet or a NAT IP addresss when the managed device is deployed in a private network. | [optional] [readonly] 
**ProxyApp** | **String** | The name of the app which will proxy the messages to the device connector. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAssetDeviceConnectionAllOf  -ApiVersion null `
 -AppPartitionNumber null `
 -ConnectionId null `
 -ConnectionReason null `
 -ConnectionStatus null `
 -ConnectionStatusLastChangeTime null `
 -ConnectorVersion null `
 -DeviceExternalIpAddress null `
 -ProxyApp null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

