# HyperflexStPlatformClusterHealingInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.StPlatformClusterHealingInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.StPlatformClusterHealingInfo"]
**EstimatedCompletionTimeInSeconds** | **Int64** | The estimated time in seconds it will take to complete the auto-healing process. | [optional] [readonly] 
**InProgress** | **Boolean** | The status of the cluster&#39;s auto-healing process. If &#39;true&#39;, auto-healing is in progress for the cluster. | [optional] [readonly] 
**Messages** | **String[]** |  | [optional] 
**MessagesIterator** | [**AnyType**](.md) | The current message describing the auto-healing process of the cluster. | [optional] [readonly] 
**MessagesSize** | **Int64** | The number of elements in the messages collection. | [optional] [readonly] 
**PercentComplete** | **Int64** | The progress of the auto-healing process as a percentage. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexStPlatformClusterHealingInfoAllOf = Initialize-IntersightHyperflexStPlatformClusterHealingInfoAllOf  -ClassId null `
 -ObjectType null `
 -EstimatedCompletionTimeInSeconds null `
 -InProgress null `
 -Messages null `
 -MessagesIterator null `
 -MessagesSize null `
 -PercentComplete null
```

- Convert the resource to JSON
```powershell
$HyperflexStPlatformClusterHealingInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

