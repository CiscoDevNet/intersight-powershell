# StorageHyperFlexVolumeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.HyperFlexVolume"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.HyperFlexVolume"]
**Capacity** | **Int64** | Provisioned Capacity of the Storage container in bytes. | [optional] [readonly] 
**SerialNumber** | **String** | Serial number of the volume. | [optional] [readonly] 
**Uuid** | **String** | Uuid of the Datastore/Storage Container. | [optional] [readonly] 
**Cluster** | [**HyperflexClusterRelationship**](HyperflexClusterRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**StorageContainer** | [**StorageHyperFlexStorageContainerRelationship**](StorageHyperFlexStorageContainerRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageHyperFlexVolumeAllOf = Initialize-IntersightStorageHyperFlexVolumeAllOf  -ClassId null `
 -ObjectType null `
 -Capacity null `
 -SerialNumber null `
 -Uuid null `
 -Cluster null `
 -RegisteredDevice null `
 -StorageContainer null
```

- Convert the resource to JSON
```powershell
$StorageHyperFlexVolumeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

