# MetaAccessPrivilege
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Method** | **String** | The type of CRUD operation (create, read, update, delete) for which an access privilege is required. | [optional] [readonly] [default to "Update"]
**Privilege** | **String** | The name of the privilege which is required to invoke the specified CRUD method. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMetaAccessPrivilege  -ClassId null `
 -ObjectType null `
 -Method null `
 -Privilege null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

