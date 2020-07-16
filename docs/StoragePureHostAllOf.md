# StoragePureHostAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostGroupName** | **String** | Name of host group where the host belongs to. Empty if host is not part of any HostGroup. | [optional] [readonly] 
**Array** | [**StoragePureArrayRelationship**](StoragePureArrayRelationship.md) |  | [optional] 
**HostGroup** | [**StoragePureHostGroupRelationship**](StoragePureHostGroupRelationship.md) |  | [optional] 
**ProtectionGroup** | [**StoragePureProtectionGroupRelationship**](StoragePureProtectionGroupRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStoragePureHostAllOf  -HostGroupName null `
 -Array null `
 -HostGroup null `
 -ProtectionGroup null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

