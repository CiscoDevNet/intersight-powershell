# StorageHitachiHostLunAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.HitachiHostLun"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.HitachiHostLun"]
**PortId** | **String** | Port ID of the lun. | [optional] [readonly] 
**Array** | [**StorageHitachiArrayRelationship**](StorageHitachiArrayRelationship.md) |  | [optional] 
**VarHost** | [**StorageHitachiHostRelationship**](StorageHitachiHostRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Volume** | [**StorageHitachiVolumeRelationship**](StorageHitachiVolumeRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageHitachiHostLunAllOf = Initialize-IntersightStorageHitachiHostLunAllOf  -ClassId null `
 -ObjectType null `
 -PortId null `
 -Array null `
 -VarHost null `
 -RegisteredDevice null `
 -Volume null
```

- Convert the resource to JSON
```powershell
$StorageHitachiHostLunAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

