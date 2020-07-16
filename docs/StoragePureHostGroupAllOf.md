# StoragePureHostGroupAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostNames** | **String[]** |  | [optional] 
**Array** | [**StoragePureArrayRelationship**](StoragePureArrayRelationship.md) |  | [optional] 
**Hosts** | [**StoragePureHostRelationship[]**](StoragePureHostRelationship.md) | An array of relationships to storagePureHost resources. | [optional] [readonly] 
**ProtectionGroup** | [**StoragePureProtectionGroupRelationship**](StoragePureProtectionGroupRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStoragePureHostGroupAllOf  -HostNames null `
 -Array null `
 -Hosts null `
 -ProtectionGroup null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

