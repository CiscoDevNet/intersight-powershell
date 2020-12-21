# StoragePhysicalDiskUsageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.PhysicalDiskUsage"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.PhysicalDiskUsage"]
**NumberOfBlocks** | **String** | The number of blocks that are a part of the virtual drive. | [optional] [readonly] 
**PhysicalDrive** | **String** | The physical disk for which the usage is reported. | [optional] [readonly] 
**Span** | **String** | The span of the physical disk. | [optional] [readonly] 
**StartingBlock** | **String** | The starting block id of the virtual drive within the physical drive. | [optional] [readonly] 
**State** | **String** | The current state of the physical disk usage. | [optional] [readonly] 
**VirtualDrive** | **String** | The virtual drive corresponding to the physical disk. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StoragePhysicalDiskUsageAllOf = Initialize-IntersightStoragePhysicalDiskUsageAllOf  -ClassId null `
 -ObjectType null `
 -NumberOfBlocks null `
 -PhysicalDrive null `
 -Span null `
 -StartingBlock null `
 -State null `
 -VirtualDrive null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$StoragePhysicalDiskUsageAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

