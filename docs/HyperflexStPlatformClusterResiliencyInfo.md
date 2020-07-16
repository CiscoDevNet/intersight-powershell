# HyperflexStPlatformClusterResiliencyInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
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
Initialize-IntersightHyperflexStPlatformClusterResiliencyInfo  -ClassId null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

