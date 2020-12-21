# MemoryPersistentMemoryNamespaceConfigResultAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "memory.PersistentMemoryNamespaceConfigResult"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "memory.PersistentMemoryNamespaceConfigResult"]
**ConfigStatus** | **String** | Status of the Persistent Memory Namespace needed to be configured. | [optional] [readonly] 
**Name** | **String** | Name of a Persistent Memory Namespace that needed to be configured. | [optional] [readonly] 
**SocketId** | **String** | Socket ID in which the Persistent Memory Namespace needed to be configured. | [optional] [readonly] 
**SocketMemoryId** | **String** | Socket Memory ID in which the Persistent Memory Namespace needed to be configured. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**MemoryPersistentMemoryConfigResult** | [**MemoryPersistentMemoryConfigResultRelationship**](MemoryPersistentMemoryConfigResultRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$MemoryPersistentMemoryNamespaceConfigResultAllOf = Initialize-IntersightMemoryPersistentMemoryNamespaceConfigResultAllOf  -ClassId null `
 -ObjectType null `
 -ConfigStatus null `
 -Name null `
 -SocketId null `
 -SocketMemoryId null `
 -InventoryDeviceInfo null `
 -MemoryPersistentMemoryConfigResult null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$MemoryPersistentMemoryNamespaceConfigResultAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

