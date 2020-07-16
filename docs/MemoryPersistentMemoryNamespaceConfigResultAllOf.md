# MemoryPersistentMemoryNamespaceConfigResultAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
Initialize-IntersightMemoryPersistentMemoryNamespaceConfigResultAllOf  -ConfigStatus null `
 -Name null `
 -SocketId null `
 -SocketMemoryId null `
 -InventoryDeviceInfo null `
 -MemoryPersistentMemoryConfigResult null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

