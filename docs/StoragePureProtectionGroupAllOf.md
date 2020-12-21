# StoragePureProtectionGroupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.PureProtectionGroup"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.PureProtectionGroup"]
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
$StoragePureProtectionGroupAllOf = Initialize-IntersightStoragePureProtectionGroupAllOf  -ClassId null `
 -ObjectType null `
 -Size null `
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
$StoragePureProtectionGroupAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

