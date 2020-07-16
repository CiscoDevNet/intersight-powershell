# HyperflexHxResiliencyInfoDtAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataReplicationFactor** | **String** |  | [optional] [readonly] [default to "ONE_COPY"]
**HddFailuresTolerable** | **Int64** |  | [optional] [readonly] 
**Messages** | **String[]** |  | [optional] 
**NodeFailuresTolerable** | **Int64** |  | [optional] [readonly] 
**PolicyCompliance** | **String** |  | [optional] [readonly] [default to "UNKNOWN"]
**ResiliencyState** | **String** |  | [optional] [readonly] [default to "UNKNOWN"]
**SsdFailuresTolerable** | **Int64** |  | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexHxResiliencyInfoDtAllOf  -DataReplicationFactor null `
 -HddFailuresTolerable null `
 -Messages null `
 -NodeFailuresTolerable null `
 -PolicyCompliance null `
 -ResiliencyState null `
 -SsdFailuresTolerable null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

