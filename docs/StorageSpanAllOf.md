# StorageSpanAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.Span"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.Span"]
**Slots** | **Int64[]** |  | [optional] 
**SpanId** | **Int64** | Unique identifier value of this span. | [optional] 
**DiskGroup** | [**StorageDiskGroupRelationship**](StorageDiskGroupRelationship.md) |  | [optional] 
**PhysicalDisks** | [**StoragePhysicalDiskRelationship[]**](StoragePhysicalDiskRelationship.md) | An array of relationships to storagePhysicalDisk resources. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageSpanAllOf = Initialize-IntersightStorageSpanAllOf  -ClassId null `
 -ObjectType null `
 -Slots null `
 -SpanId null `
 -DiskGroup null `
 -PhysicalDisks null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$StorageSpanAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

