# HyperflexHxResiliencyInfoDt
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
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
Initialize-IntersightHyperflexHxResiliencyInfoDt  -ClassId null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

