# StoragePureVolumeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Created** | **System.DateTime** | Creation time of the volume. | [optional] [readonly] 
**Serial** | **String** | Serial number of the volume. | [optional] [readonly] 
**Source** | **String** | Source from which the volume is created. Applicable only if the volume is cloned from other volume or snapshot. | [optional] [readonly] 
**Array** | [**StoragePureArrayRelationship**](StoragePureArrayRelationship.md) |  | [optional] 
**ProtectionGroup** | [**StoragePureProtectionGroupRelationship**](StoragePureProtectionGroupRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStoragePureVolumeAllOf  -Created null `
 -Serial null `
 -Source null `
 -Array null `
 -ProtectionGroup null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

