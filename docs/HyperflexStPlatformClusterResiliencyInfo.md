# HyperflexStPlatformClusterResiliencyInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.StPlatformClusterResiliencyInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.StPlatformClusterResiliencyInfo"]
**HddFailuresTolerable** | **Int64** | The number of persistent storage device failures tolerable before the storage cluster becomes offline. | [optional] [readonly] 
**Messages** | **String[]** |  | [optional] 
**MessagesIterator** | [**AnyType**](.md) | The current message describing the auto-healing process of the cluster. | [optional] [readonly] 
**MessagesSize** | **Int64** | The number of elements in the messages collection. | [optional] [readonly] 
**NodeFailuresTolerable** | **Int64** | The number of node failures tolerable before the storage cluster becomes offline. | [optional] [readonly] 
**SsdFailuresTolerable** | **Int64** | The number of caching device failures tolerable before the storage cluster becomes offline. | [optional] [readonly] 
**State** | **String** | The resiliency state of the cluster. The resiliency status is &#39;HEALTHY&#39; if there are no failures and the storage cluster is fully operational. The resiliency status is &#39;WARNING&#39; when the cluster has experienced failures that may adversely affect the cluster. It is &#39;UNKNOWN&#39; if the cluster is offline or if the state cannot be determined. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexStPlatformClusterResiliencyInfo = Initialize-IntersightHyperflexStPlatformClusterResiliencyInfo  -ClassId null `
 -ObjectType null `
 -HddFailuresTolerable null `
 -Messages null `
 -MessagesIterator null `
 -MessagesSize null `
 -NodeFailuresTolerable null `
 -SsdFailuresTolerable null `
 -State null
```

- Convert the resource to JSON
```powershell
$HyperflexStPlatformClusterResiliencyInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

