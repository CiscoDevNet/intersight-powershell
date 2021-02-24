# StorageNetAppVolumeSnapshotAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.NetAppVolumeSnapshot"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.NetAppVolumeSnapshot"]
**Uuid** | **String** | UUID of the volume snapshot. | [optional] [readonly] 
**Array** | [**StorageNetAppClusterRelationship**](StorageNetAppClusterRelationship.md) |  | [optional] 
**StorageContainer** | [**StorageNetAppVolumeRelationship**](StorageNetAppVolumeRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageNetAppVolumeSnapshotAllOf = Initialize-IntersightStorageNetAppVolumeSnapshotAllOf  -ClassId null `
 -ObjectType null `
 -Uuid null `
 -Array null `
 -StorageContainer null
```

- Convert the resource to JSON
```powershell
$StorageNetAppVolumeSnapshotAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

