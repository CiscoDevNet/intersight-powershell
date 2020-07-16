# ComputePersistentMemoryOperationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminAction** | **String** | Administrative actions that can be performed on the Persistent Memory Modules. | [optional] [default to "None"]
**IsSecurePassphraseSet** | **Boolean** | Indicates whether the value of the &#39;securePassphrase&#39; property has been set. | [optional] [readonly] 
**Modules** | [**ComputePersistentMemoryModule[]**](ComputePersistentMemoryModule.md) |  | [optional] 
**SecurePassphrase** | **String** | Secure passphrase of the Persistent Memory Modules of the server. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightComputePersistentMemoryOperationAllOf  -AdminAction null `
 -IsSecurePassphraseSet null `
 -Modules null `
 -SecurePassphrase null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

