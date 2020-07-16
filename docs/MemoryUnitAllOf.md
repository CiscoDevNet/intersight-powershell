# MemoryUnitAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MemoryId** | **Int64** | This represents the ID of a regular DIMM on a server. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**MemoryArray** | [**MemoryArrayRelationship**](MemoryArrayRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightMemoryUnitAllOf  -MemoryId null `
 -InventoryDeviceInfo null `
 -MemoryArray null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

