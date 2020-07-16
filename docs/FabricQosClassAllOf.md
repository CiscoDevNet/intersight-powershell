# FabricQosClassAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminState** | **String** | Administrative state for this QoS class. | [optional] [default to "Disabled"]
**BandwidthPercent** | **Int64** | Percentage of bandwidth received by the traffic tagged with this QoS. | [optional] 
**Cos** | **Int64** | Class of service received by the traffic tagged with this QoS. | [optional] 
**Mtu** | **Int64** | Maximum transmission unit (MTU) is the largest size packet or frame, that can be sent in a packet- or frame-based network such as the Internet. User can select from the following: 1. Any value between 1500 and 9216 2. &#39;Normal&#39; (default) mapping to a value of 1500. 3. &#39;FC&#39; mapping to a value of 2240. | [optional] 
**MulticastOptimize** | **Boolean** | If enabled, this QoS class will be optimized to send multiple packets. | [optional] 
**Name** | **String** | The &#39;name&#39; of this QoS Class. | [optional] 
**PacketDrop** | **Boolean** | If enabled, this QoS class will allow packet drops within an acceptable limit. | [optional] 
**Weight** | **Int64** | The weight of the QoS Class controls the distribution of bandwidth between QoS Classes, with the same priority after the Guarantees for the QoS Classes are reached. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFabricQosClassAllOf  -AdminState null `
 -BandwidthPercent null `
 -Cos null `
 -Mtu null `
 -MulticastOptimize null `
 -Name null `
 -PacketDrop null `
 -Weight null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

