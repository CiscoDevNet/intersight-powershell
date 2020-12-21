# FabricQosClassAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "fabric.QosClass"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "fabric.QosClass"]
**AdminState** | **String** | Administrative state for this QoS class. * &#x60;Disabled&#x60; - Admin configured Disabled State. * &#x60;Enabled&#x60; - Admin configured Enabled State. | [optional] [default to "Disabled"]
**BandwidthPercent** | **Int64** | Percentage of bandwidth received by the traffic tagged with this QoS. | [optional] 
**Cos** | **Int64** | Class of service received by the traffic tagged with this QoS. | [optional] 
**Mtu** | **Int64** | Maximum transmission unit (MTU) is the largest size packet or frame, that can be sent in a packet- or frame-based network such as the Internet. User can select from the following: 1. Any value between 1500 and 9216 2. &#39;Normal&#39; (default) mapping to a value of 1500. 3. &#39;FC&#39; mapping to a value of 2240. | [optional] [default to 1500]
**MulticastOptimize** | **Boolean** | If enabled, this QoS class will be optimized to send multiple packets. | [optional] [default to $false]
**Name** | **String** | The &#39;name&#39; of this QoS Class. * &#x60;Best Effort&#x60; - QoS Priority for Best-effort traffic. * &#x60;FC&#x60; - QoS Priority for FC traffic. * &#x60;Platinum&#x60; - QoS Priority for Platinum traffic. * &#x60;Gold&#x60; - QoS Priority for Gold traffic. * &#x60;Silver&#x60; - QoS Priority for Silver traffic. * &#x60;Bronze&#x60; - QoS Priority for Bronze traffic. | [optional] [default to "Best Effort"]
**PacketDrop** | **Boolean** | If enabled, this QoS class will allow packet drops within an acceptable limit. | [optional] [default to $true]
**Weight** | **Int64** | The weight of the QoS Class controls the distribution of bandwidth between QoS Classes, with the same priority after the Guarantees for the QoS Classes are reached. | [optional] 

## Examples

- Prepare the resource
```powershell
$FabricQosClassAllOf = Initialize-IntersightFabricQosClassAllOf  -ClassId null `
 -ObjectType null `
 -AdminState null `
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
$FabricQosClassAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

