# MemoryPersistentMemoryUnitAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "memory.PersistentMemoryUnit"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "memory.PersistentMemoryUnit"]
**AppDirectCapacity** | **String** | AppDirect capacity in GiB of the Persistent Memory Module on a server. | [optional] [readonly] 
**CountStatus** | **String** | Count status of the Persistent Memory Module on a server. | [optional] [readonly] 
**FirmwareVersion** | **String** | Firmware version of the firware running on the Persistent Memory Module on a server. | [optional] [readonly] 
**FrozenStatus** | **String** | Frozen status of the Persistent Memory Module on a server. | [optional] [readonly] 
**HealthState** | **String** | Health state of the Persistent Memory Module on a server. | [optional] [readonly] 
**LockStatus** | **String** | Lock status of the Persistent Memory Module on a server. | [optional] [readonly] 
**MemoryCapacity** | **String** | Memory capacity in GiB of the Persistent Memory Module on a server. | [optional] [readonly] 
**MemoryId** | **Int64** | ID of the Persistent Memory Module on a server. | [optional] [readonly] 
**PersistentMemoryCapacity** | **String** | Persistent Memory capacity in GiB of the Persistent Memory Module on a server. | [optional] [readonly] 
**ReservedCapacity** | **String** | Reserved capacity in GiB of the Persistent Memory Module on a server. | [optional] [readonly] 
**SecurityStatus** | **String** | Security status of the Persistent Memory Module on a server. | [optional] [readonly] 
**SocketId** | **String** | Socket ID of the Persistent Memory Module on a server. | [optional] [readonly] 
**SocketMemoryId** | **String** | Socket Memory ID of the Persistent Memory Module on a server. | [optional] [readonly] 
**TotalCapacity** | **String** | Total capacity in GiB of the Persistent Memory Module on a server. | [optional] [readonly] 
**Uid** | **String** | UID of the Persistent Memory Module on a server. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**MemoryArray** | [**MemoryArrayRelationship**](MemoryArrayRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$MemoryPersistentMemoryUnitAllOf = Initialize-IntersightMemoryPersistentMemoryUnitAllOf  -ClassId null `
 -ObjectType null `
 -AppDirectCapacity null `
 -CountStatus null `
 -FirmwareVersion null `
 -FrozenStatus null `
 -HealthState null `
 -LockStatus null `
 -MemoryCapacity null `
 -MemoryId null `
 -PersistentMemoryCapacity null `
 -ReservedCapacity null `
 -SecurityStatus null `
 -SocketId null `
 -SocketMemoryId null `
 -TotalCapacity null `
 -Uid null `
 -InventoryDeviceInfo null `
 -MemoryArray null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$MemoryPersistentMemoryUnitAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

