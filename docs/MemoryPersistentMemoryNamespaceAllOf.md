# MemoryPersistentMemoryNamespaceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "memory.PersistentMemoryNamespace"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "memory.PersistentMemoryNamespace"]
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
$MemoryPersistentMemoryNamespaceAllOf = Initialize-IntersightMemoryPersistentMemoryNamespaceAllOf  -ClassId null `
 -ObjectType null `
 -Capacity null `
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
$MemoryPersistentMemoryNamespaceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

