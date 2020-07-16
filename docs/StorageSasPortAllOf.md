# StorageSasPortAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **String** | The SAS Address assigned to storage port. | [optional] [readonly] 
**DiskId** | **Int64** | The unique disk identifier. | [optional] [readonly] 
**EndPointId** | **Int64** | The end-point Id assigned to storage port. | [optional] [readonly] 
**LinkDescription** | **String** | The description for the link. | [optional] [readonly] 
**LinkSpeed** | **String** | The link speed negotiated for communication. | [optional] [readonly] 
**InventoryDeviceInfo** | [**InventoryDeviceInfoRelationship**](InventoryDeviceInfoRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StoragePhysicalDisk** | [**StoragePhysicalDiskRelationship**](StoragePhysicalDiskRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageSasPortAllOf  -Address null `
 -DiskId null `
 -EndPointId null `
 -LinkDescription null `
 -LinkSpeed null `
 -InventoryDeviceInfo null `
 -RegisteredDevice null `
 -StoragePhysicalDisk null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

