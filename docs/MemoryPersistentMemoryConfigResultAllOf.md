# MemoryPersistentMemoryConfigResultAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigErrorDesc** | **String** | Error in the result of a previously applied Persistent Memory configuration on a server. | [optional] [readonly] 
**ConfigResult** | **String** | Result of a previously applied Persistent Memory configuration on a server. | [optional] [readonly] 
**ConfigSequenceNo** | **Int64** | Sequence number of a previously applied Persistent Memory configuration on a server. | [optional] [readonly] 
**ConfigState** | **String** | State of a previously applied Persistent Memory configuration on a server. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**MemoryPersistentMemoryConfiguration** | [**MemoryPersistentMemoryConfigurationRelationship**](MemoryPersistentMemoryConfigurationRelationship.md) |  | [optional] 
**PersistentMemoryNamespaceConfigResults** | [**MemoryPersistentMemoryNamespaceConfigResultRelationship[]**](MemoryPersistentMemoryNamespaceConfigResultRelationship.md) | An array of relationships to memoryPersistentMemoryNamespaceConfigResult resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMemoryPersistentMemoryConfigResultAllOf  -ConfigErrorDesc null `
 -ConfigResult null `
 -ConfigSequenceNo null `
 -ConfigState null `
 -InventoryDeviceInfo null `
 -MemoryPersistentMemoryConfiguration null `
 -PersistentMemoryNamespaceConfigResults null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

