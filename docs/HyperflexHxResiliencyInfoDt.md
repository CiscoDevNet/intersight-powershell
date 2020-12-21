# HyperflexHxResiliencyInfoDt
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.HxResiliencyInfoDt"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.HxResiliencyInfoDt"]
**DataReplicationFactor** | **String** | The number of copies of data replicated by the cluster. * &#x60;ONE_COPY&#x60; - The HyperFlex cluster does not replicate data. * &#x60;TWO_COPIES&#x60; - The HyperFlex cluster keeps 2 copies of data. * &#x60;THREE_COPIES&#x60; - The HyperFlex cluster keeps 3 copies of data. * &#x60;FOUR_COPIES&#x60; - The HyperFlex cluster keeps 4 copies of data. * &#x60;SIX_COPIES&#x60; - The HyperFlex cluster keeps 6 copies of data. | [optional] [readonly] [default to "ONE_COPY"]
**HddFailuresTolerable** | **Int64** | The number of persistent device disruptions the HyperFlex storage cluster can handle at this point in time. | [optional] [readonly] 
**Messages** | **String[]** |  | [optional] 
**NodeFailuresTolerable** | **Int64** | The number of node disruptions the HyperFlex storage cluster can handle at this point in time. | [optional] [readonly] 
**PolicyCompliance** | **String** | The state of the storage cluster&#39;s compliance with the cluster access policy. * &#x60;UNKNOWN&#x60; - The HyperFlex cluster&#39;s compliance with the data replication policy could not be determined. * &#x60;COMPLIANT&#x60; - The HyperFlex cluster is compliant with the data replication policy and data is replicated to the configured replication factor. * &#x60;NON_COMPLIANT&#x60; - The HyperFlex cluster is not compliant with the data replication policy because some data is not replicated. | [optional] [readonly] [default to "UNKNOWN"]
**ResiliencyState** | **String** | The resiliency state of the storage platform. The resiliency state is the storage cluster&#39;s current ability to maintain data. * &#x60;UNKNOWN&#x60; - The resiliency status of the HyperFlex cluster cannot be determined, or the cluster is transitioning into ONLINE state. * &#x60;HEALTHY&#x60; - The HyperFlex cluster is healthy. The cluster is able to perform IO operations and data is available. * &#x60;WARNING&#x60; - The HyperFlex cluster or data availability is adversely affected. This can happen if there are node or storage device failures beyond the tolerable failure threshold. * &#x60;OFFLINE&#x60; - The HyperFlex cluster is offline and not performing IO operations. | [optional] [readonly] [default to "UNKNOWN"]
**SsdFailuresTolerable** | **Int64** | The number of cache device disruptions the HyperFlex storage cluster can handle at this point in time. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexHxResiliencyInfoDt = Initialize-IntersightHyperflexHxResiliencyInfoDt  -ClassId null `
 -ObjectType null `
 -DataReplicationFactor null `
 -HddFailuresTolerable null `
 -Messages null `
 -NodeFailuresTolerable null `
 -PolicyCompliance null `
 -ResiliencyState null `
 -SsdFailuresTolerable null
```

- Convert the resource to JSON
```powershell
$HyperflexHxResiliencyInfoDt | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

