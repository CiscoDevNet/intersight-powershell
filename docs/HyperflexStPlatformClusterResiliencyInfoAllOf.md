# HyperflexStPlatformClusterResiliencyInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HddFailuresTolerable** | **Int64** |  | [optional] [readonly] 
**Messages** | **String[]** |  | [optional] 
**MessagesIterator** | [**AnyType**](.md) |  | [optional] [readonly] 
**MessagesSize** | **Int64** |  | [optional] [readonly] 
**NodeFailuresTolerable** | **Int64** |  | [optional] [readonly] 
**SsdFailuresTolerable** | **Int64** |  | [optional] [readonly] 
**State** | **String** |  | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexStPlatformClusterResiliencyInfoAllOf  -HddFailuresTolerable null `
 -Messages null `
 -MessagesIterator null `
 -MessagesSize null `
 -NodeFailuresTolerable null `
 -SsdFailuresTolerable null `
 -State null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

