# MemoryPersistentMemoryRegionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "memory.PersistentMemoryRegion"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "memory.PersistentMemoryRegion"]
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
$MemoryPersistentMemoryRegionAllOf = Initialize-IntersightMemoryPersistentMemoryRegionAllOf  -ClassId null `
 -ObjectType null `
 -FreeCapacity null `
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
$MemoryPersistentMemoryRegionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

