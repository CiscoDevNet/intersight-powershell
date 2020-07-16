# HyperflexConfigResultAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigProgress** | **String** | The progress percentage of the running configuration or workflow. | [optional] 
**Duration** | **String** | The duration of the running configuration or workflow. | [optional] 
**StartTime** | **String** | The start time of the configuration or workflow. | [optional] 
**ClusterProfile** | [**HyperflexClusterProfileRelationship**](HyperflexClusterProfileRelationship.md) |  | [optional] 
**ResultEntries** | [**HyperflexConfigResultEntryRelationship[]**](HyperflexConfigResultEntryRelationship.md) | An array of relationships to hyperflexConfigResultEntry resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexConfigResultAllOf  -ConfigProgress null `
 -Duration null `
 -StartTime null `
 -ClusterProfile null `
 -ResultEntries null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

