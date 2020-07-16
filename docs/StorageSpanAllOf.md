# StorageSpanAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Slots** | **Int64[]** |  | [optional] 
**SpanId** | **Int64** | Unique identifier value of this span. | [optional] 
**DiskGroup** | [**StorageDiskGroupRelationship**](StorageDiskGroupRelationship.md) |  | [optional] 
**PhysicalDisks** | [**StoragePhysicalDiskRelationship[]**](StoragePhysicalDiskRelationship.md) | An array of relationships to storagePhysicalDisk resources. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStorageSpanAllOf  -Slots null `
 -SpanId null `
 -DiskGroup null `
 -PhysicalDisks null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

