# MemoryPersistentMemoryLogicalNamespace
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Capacity** | **Int32** | Capacity of this Namespace that is created or modified. | [optional] 
**Mode** | **String** | Mode of this Namespace that is created or modified. | [optional] [default to "raw"]
**Name** | **String** | Name of this Namespace to be created on the server. | [optional] 
**SocketId** | **Int32** | Socket ID of the region on which this Namespace has to be created or modified. | [optional] [default to 1]
**SocketMemoryId** | **String** | Socket Memory ID of the region on which this Namespace has to be created or modified. | [optional] [default to "Not Applicable"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMemoryPersistentMemoryLogicalNamespace  -ClassId null `
 -ObjectType null `
 -Capacity null `
 -Mode null `
 -Name null `
 -SocketId null `
 -SocketMemoryId null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

