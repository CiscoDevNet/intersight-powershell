# MemoryPersistentMemoryLocalSecurity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Enabled** | **Boolean** | Persistent Memory Security state. | [optional] 
**IsSecurePassphraseSet** | **Boolean** | Indicates whether the value of the &#39;securePassphrase&#39; property has been set. | [optional] [readonly] 
**SecurePassphrase** | **String** | Secure passphrase to be applied on the Persistent Memory Modules on the server. The allowed characters are a-z, A to Z, 0-9, and special characters &#x3D;, \\u0021, &amp;, \\#, $, %, +, ^, @, _, *, -. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMemoryPersistentMemoryLocalSecurity  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -IsSecurePassphraseSet null `
 -SecurePassphrase null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

