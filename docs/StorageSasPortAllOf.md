# StorageSasPortAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.SasPort"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.SasPort"]
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
$StorageSasPortAllOf = Initialize-IntersightStorageSasPortAllOf  -ClassId null `
 -ObjectType null `
 -Address null `
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
$StorageSasPortAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

