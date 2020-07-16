# MemoryPersistentMemoryRegionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FreeCapacity** | **String** | Free capacity in GiB of the Persistent Memory Region. | [optional] [readonly] 
**HealthState** | **String** | Health state of the Persistent Memory Region. | [optional] [readonly] 
**InterleavedSetId** | **String** | ID of the Interleaved Set formed for this Persistent Memory Region. | [optional] [readonly] 
**LocaterIds** | **String** | Set of locator IDs that are included in the Persistent Memory Region. | [optional] [readonly] 
**PersistentMemoryType** | **String** | Persistent Memory type of the Persistent Memory Region. | [optional] [readonly] 
**RegionId** | **String** | ID of the Persistent Memory Region. | [optional] [readonly] 
**SocketId** | **String** | Socket ID of the Persistent Memory Region. | [optional] [readonly] 
**SocketMemoryId** | **String** | Socket Memory ID of the Persistent Memory Region. | [optional] [readonly] 
**TotalCapacity** | **String** | Total capacity in GiB of the Persistent Memory Region. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**MemoryPersistentMemoryConfiguration** | [**MemoryPersistentMemoryConfigurationRelationship**](MemoryPersistentMemoryConfigurationRelationship.md) |  | [optional] 
**PersistentMemoryNamespaces** | [**MemoryPersistentMemoryNamespaceRelationship[]**](MemoryPersistentMemoryNamespaceRelationship.md) | An array of relationships to memoryPersistentMemoryNamespace resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMemoryPersistentMemoryRegionAllOf  -FreeCapacity null `
 -HealthState null `
 -InterleavedSetId null `
 -LocaterIds null `
 -PersistentMemoryType null `
 -RegionId null `
 -SocketId null `
 -SocketMemoryId null `
 -TotalCapacity null `
 -InventoryDeviceInfo null `
 -MemoryPersistentMemoryConfiguration null `
 -PersistentMemoryNamespaces null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

