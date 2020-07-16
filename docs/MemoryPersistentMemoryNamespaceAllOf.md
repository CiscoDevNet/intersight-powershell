# MemoryPersistentMemoryNamespaceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capacity** | **String** | Capacity in GiB of the Persistent Memory Namespace. | [optional] [readonly] 
**HealthState** | **String** | Health state of the Persistent Memory Namespace. | [optional] [readonly] 
**LabelVersion** | **String** | Label version of the Persistent Memory Namespace. | [optional] [readonly] 
**Mode** | **String** | Mode of the Persistent Memory Namespace. | [optional] [readonly] 
**Name** | **String** | Name of the Persistent Memory Namespace. | [optional] [readonly] 
**Uuid** | **String** | UUID of the Persistent Memory Namespace. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**MemoryPersistentMemoryRegion** | [**MemoryPersistentMemoryRegionRelationship**](MemoryPersistentMemoryRegionRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMemoryPersistentMemoryNamespaceAllOf  -Capacity null `
 -HealthState null `
 -LabelVersion null `
 -Mode null `
 -Name null `
 -Uuid null `
 -InventoryDeviceInfo null `
 -MemoryPersistentMemoryRegion null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

