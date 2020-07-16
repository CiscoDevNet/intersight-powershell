# MemoryPersistentMemoryLocalSecurityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **Boolean** | Persistent Memory Security state. | [optional] 
**IsSecurePassphraseSet** | **Boolean** | Indicates whether the value of the &#39;securePassphrase&#39; property has been set. | [optional] [readonly] 
**SecurePassphrase** | **String** | Secure passphrase to be applied on the Persistent Memory Modules on the server. The allowed characters are a-z, A to Z, 0-9, and special characters &#x3D;, \\u0021, &amp;, \\#, $, %, +, ^, @, _, *, -. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMemoryPersistentMemoryLocalSecurityAllOf  -Enabled null `
 -IsSecurePassphraseSet null `
 -SecurePassphrase null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

