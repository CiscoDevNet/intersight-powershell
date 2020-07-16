# TechsupportmanagementNiaParam
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**CollectionLevel** | **Int32** | CollectionLevel controls the size / depth of the tech support files collected. | [optional] [default to 1]
**Filename** | **String** | Filename specifies an individual filename to collect from the endpoint. | [optional] 
**ForceFresh** | **Boolean** | ForceFresh controls whether to return pre-collected files or force the collection of new files. | [optional] 
**Pids** | **String[]** |  | [optional] 
**SerialNumbers** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTechsupportmanagementNiaParam  -ClassId null `
 -ObjectType null `
 -CollectionLevel null `
 -Filename null `
 -ForceFresh null `
 -Pids null `
 -SerialNumbers null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

