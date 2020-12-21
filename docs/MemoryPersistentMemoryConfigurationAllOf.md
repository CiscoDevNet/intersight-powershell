# MemoryPersistentMemoryConfigurationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "memory.PersistentMemoryConfiguration"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "memory.PersistentMemoryConfiguration"]
**MemoryCapacity** | **String** | Memory capacity in GiB of a Persistent Memory configuration on a server. | [optional] [readonly] 
**NumOfModules** | **String** | Number of Persistent Memory Modules on a server. | [optional] [readonly] 
**NumOfRegions** | **String** | Number of Persistent Memory Regions on a server. | [optional] [readonly] 
**PersistentMemoryCapacity** | **String** | Persistent memory capacity in GiB of a Persistent Memory configuration on a server. | [optional] [readonly] 
**ReservedCapacity** | **String** | Reserved capacity in GiB of a Persistent Memory configuration on a server. | [optional] [readonly] 
**SecurityState** | **String** | Collective security state of all Persistent Memory modules on a server. | [optional] [readonly] 
**TotalCapacity** | **String** | Total capacity in GiB of a Persistent Memory configuration on a server. | [optional] [readonly] 
**ComputeBoard** | [**ComputeBoardRelationship**](ComputeBoardRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**PersistentMemoryConfigResult** | [**MemoryPersistentMemoryConfigResultRelationship**](MemoryPersistentMemoryConfigResultRelationship.md) |  | [optional] 
**PersistentMemoryRegions** | [**MemoryPersistentMemoryRegionRelationship[]**](MemoryPersistentMemoryRegionRelationship.md) | An array of relationships to memoryPersistentMemoryRegion resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$MemoryPersistentMemoryConfigurationAllOf = Initialize-IntersightMemoryPersistentMemoryConfigurationAllOf  -ClassId null `
 -ObjectType null `
 -MemoryCapacity null `
 -NumOfModules null `
 -NumOfRegions null `
 -PersistentMemoryCapacity null `
 -ReservedCapacity null `
 -SecurityState null `
 -TotalCapacity null `
 -ComputeBoard null `
 -InventoryDeviceInfo null `
 -PersistentMemoryConfigResult null `
 -PersistentMemoryRegions null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$MemoryPersistentMemoryConfigurationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

