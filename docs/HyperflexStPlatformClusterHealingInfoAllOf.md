# HyperflexStPlatformClusterHealingInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EstimatedCompletionTimeInSeconds** | **Int64** |  | [optional] [readonly] 
**InProgress** | **Boolean** |  | [optional] [readonly] 
**Messages** | **String[]** |  | [optional] 
**MessagesIterator** | [**AnyType**](.md) |  | [optional] [readonly] 
**MessagesSize** | **Int64** |  | [optional] [readonly] 
**PercentComplete** | **Int64** |  | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexStPlatformClusterHealingInfoAllOf  -EstimatedCompletionTimeInSeconds null `
 -InProgress null `
 -Messages null `
 -MessagesIterator null `
 -MessagesSize null `
 -PercentComplete null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

