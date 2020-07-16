# MemoryArrayAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArrayId** | **Int64** | The instance number of the memory array. | [optional] [readonly] 
**CpuId** | **Int64** | ID of the CPU that access this memory array. | [optional] [readonly] 
**CurrentCapacity** | **String** | Current capacity of all the memory units on a server. | [optional] [readonly] 
**ErrorCorrection** | **String** | The primary hardware error detection or correction method supported by the memory array. | [optional] [readonly] 
**MaxCapacity** | **String** | Maximum capacity of all the memory units on a server. | [optional] [readonly] 
**MaxDevices** | **String** | The maximum number of slots or sockets available for memory devices in the memory array. | [optional] [readonly] 
**OperPowerState** | **String** | The power state indicator of the memory array. | [optional] [readonly] 
**Presence** | **String** | The presence of atleast one memory device in the array. Valid values are &#39;equipped&#39; and &#39;absent&#39;. | [optional] [readonly] 
**ComputeBlade** | [**ComputeBladeRelationship**](ComputeBladeRelationship.md) |  | [optional] 
**ComputeBoard** | [**ComputeBoardRelationship**](ComputeBoardRelationship.md) |  | [optional] 
**ComputeRackUnit** | [**ComputeRackUnitRelationship**](ComputeRackUnitRelationship.md) |  | [optional] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**PersistentMemoryUnits** | [**MemoryPersistentMemoryUnitRelationship[]**](MemoryPersistentMemoryUnitRelationship.md) | An array of relationships to memoryPersistentMemoryUnit resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Units** | [**MemoryUnitRelationship[]**](MemoryUnitRelationship.md) | An array of relationships to memoryUnit resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMemoryArrayAllOf  -ArrayId null `
 -CpuId null `
 -CurrentCapacity null `
 -ErrorCorrection null `
 -MaxCapacity null `
 -MaxDevices null `
 -OperPowerState null `
 -Presence null `
 -ComputeBlade null `
 -ComputeBoard null `
 -ComputeRackUnit null `
 -InventoryDeviceInfo null `
 -PersistentMemoryUnits null `
 -RegisteredDevice null `
 -Units null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

