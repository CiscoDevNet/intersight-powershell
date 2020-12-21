# MemoryPersistentMemoryLocalSecurityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "memory.PersistentMemoryLocalSecurity"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "memory.PersistentMemoryLocalSecurity"]
**Enabled** | **Boolean** | Persistent Memory Security state. | [optional] [default to $false]
**IsSecurePassphraseSet** | **Boolean** | Indicates whether the value of the &#39;securePassphrase&#39; property has been set. | [optional] [readonly] [default to $false]
**SecurePassphrase** | **String** | Secure passphrase to be applied on the Persistent Memory Modules on the server. The allowed characters are a-z, A to Z, 0-9, and special characters &#x3D;, \u0021, &amp;, \#, $, %, +, ^, @, _, *, -. | [optional] 

## Examples

- Prepare the resource
```powershell
$MemoryPersistentMemoryLocalSecurityAllOf = Initialize-IntersightMemoryPersistentMemoryLocalSecurityAllOf  -ClassId null `
 -ObjectType null `
 -Enabled null `
 -IsSecurePassphraseSet null `
 -SecurePassphrase null
```

- Convert the resource to JSON
```powershell
$MemoryPersistentMemoryLocalSecurityAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

