# StoragePureProtectionGroupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Size** | **Int64** | Overall size of all snapshots in the protection group, represented in bytes. | [optional] 
**Source** | **String** | Name of PureStorage array name on which the protection group is created. | [optional] [readonly] 
**Targets** | **String[]** |  | [optional] 
**Array** | [**StoragePureArrayRelationship**](StoragePureArrayRelationship.md) |  | [optional] 
**HostGroups** | [**StoragePureHostGroupRelationship[]**](StoragePureHostGroupRelationship.md) | An array of relationships to storagePureHostGroup resources. | [optional] [readonly] 
**Hosts** | [**StoragePureHostRelationship[]**](StoragePureHostRelationship.md) | An array of relationships to storagePureHost resources. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Volumes** | [**StoragePureVolumeRelationship[]**](StoragePureVolumeRelationship.md) | An array of relationships to storagePureVolume resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStoragePureProtectionGroupAllOf  -Size null `
 -Source null `
 -Targets null `
 -Array null `
 -HostGroups null `
 -Hosts null `
 -RegisteredDevice null `
 -Volumes null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

