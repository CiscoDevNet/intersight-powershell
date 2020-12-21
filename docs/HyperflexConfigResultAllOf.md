# HyperflexConfigResultAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ConfigResult"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ConfigResult"]
**ConfigProgress** | **String** | The progress percentage of the running configuration or workflow. | [optional] 
**Duration** | **String** | The duration of the running configuration or workflow. | [optional] 
**StartTime** | **String** | The start time of the configuration or workflow. | [optional] 
**ClusterProfile** | [**HyperflexClusterProfileRelationship**](HyperflexClusterProfileRelationship.md) |  | [optional] 
**ResultEntries** | [**HyperflexConfigResultEntryRelationship[]**](HyperflexConfigResultEntryRelationship.md) | An array of relationships to hyperflexConfigResultEntry resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$HyperflexConfigResultAllOf = Initialize-IntersightHyperflexConfigResultAllOf  -ClassId null `
 -ObjectType null `
 -ConfigProgress null `
 -Duration null `
 -StartTime null `
 -ClusterProfile null `
 -ResultEntries null
```

- Convert the resource to JSON
```powershell
$HyperflexConfigResultAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

