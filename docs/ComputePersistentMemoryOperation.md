# ComputePersistentMemoryOperation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "compute.PersistentMemoryOperation"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "compute.PersistentMemoryOperation"]
**AdminAction** | **String** | Administrative actions that can be performed on the Persistent Memory Modules. * &#x60;None&#x60; - No action on the selected Persistent Memory Modules. * &#x60;SecureErase&#x60; - Secure Erase action on the selected Persistent Memory Modules. * &#x60;Unlock&#x60; - Unlock action on the selected Persistent Memory Modules. | [optional] [default to "None"]
**IsSecurePassphraseSet** | **Boolean** | Indicates whether the value of the &#39;securePassphrase&#39; property has been set. | [optional] [readonly] [default to $false]
**Modules** | [**ComputePersistentMemoryModule[]**](ComputePersistentMemoryModule.md) |  | [optional] 
**SecurePassphrase** | **String** | Secure passphrase of the Persistent Memory Modules of the server. | [optional] 

## Examples

- Prepare the resource
```powershell
$ComputePersistentMemoryOperation = Initialize-IntersightComputePersistentMemoryOperation  -ClassId null `
 -ObjectType null `
 -AdminAction null `
 -IsSecurePassphraseSet null `
 -Modules null `
 -SecurePassphrase null
```

- Convert the resource to JSON
```powershell
$ComputePersistentMemoryOperation | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

