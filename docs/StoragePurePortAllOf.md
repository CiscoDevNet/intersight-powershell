# StoragePurePortAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Failover** | **String** | Name of the port to which this port has failed over. | [optional] [readonly] 
**Portal** | **String** | Ip address of iSCSI portal configured on the port. | [optional] [readonly] 
**Array** | [**StoragePureArrayRelationship**](StoragePureArrayRelationship.md) |  | [optional] 
**Controller** | [**StoragePureControllerRelationship**](StoragePureControllerRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightStoragePurePortAllOf  -Failover null `
 -Portal null `
 -Array null `
 -Controller null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

