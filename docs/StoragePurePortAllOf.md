# StoragePurePortAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.PurePort"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.PurePort"]
**Failover** | **String** | Name of the port to which this port has failed over. | [optional] [readonly] 
**Portal** | **String** | Ip address of iSCSI portal configured on the port. | [optional] [readonly] 
**Array** | [**StoragePureArrayRelationship**](StoragePureArrayRelationship.md) |  | [optional] 
**Controller** | [**StoragePureControllerRelationship**](StoragePureControllerRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StoragePurePortAllOf = Initialize-IntersightStoragePurePortAllOf  -ClassId null `
 -ObjectType null `
 -Failover null `
 -Portal null `
 -Array null `
 -Controller null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$StoragePurePortAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

