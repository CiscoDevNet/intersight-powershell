# StoragePureHostLunAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostGroupName** | **String** | Name of the host group associated with LUN. | [optional] [readonly] 
**Shared** | **Boolean** | Kind of volume connection to host. True if it is connected through host group. False in case of direct host connection. | [optional] [readonly] 
**Array** | [**StoragePureArrayRelationship**](StoragePureArrayRelationship.md) |  | [optional] 
**VarHost** | [**StoragePureHostRelationship**](StoragePureHostRelationship.md) |  | [optional] 
**HostGroup** | [**StoragePureHostGroupRelationship**](StoragePureHostGroupRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Volume** | [**StoragePureVolumeRelationship**](StoragePureVolumeRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStoragePureHostLunAllOf  -HostGroupName null `
 -Shared null `
 -Array null `
 -VarHost null `
 -HostGroup null `
 -RegisteredDevice null `
 -Volume null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

