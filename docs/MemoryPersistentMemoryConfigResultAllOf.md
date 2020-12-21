# MemoryPersistentMemoryConfigResultAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "memory.PersistentMemoryConfigResult"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "memory.PersistentMemoryConfigResult"]
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
$MemoryPersistentMemoryConfigResultAllOf = Initialize-IntersightMemoryPersistentMemoryConfigResultAllOf  -ClassId null `
 -ObjectType null `
 -ConfigErrorDesc null `
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
$MemoryPersistentMemoryConfigResultAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

