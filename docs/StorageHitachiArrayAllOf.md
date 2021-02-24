# StorageHitachiArrayAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "storage.HitachiArray"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "storage.HitachiArray"]
**Ctl1Ip** | **String** | IP address of controller 1 of the storage system. | [optional] [readonly] 
**Ctl1MicroVersion** | **String** | GUM (Gateway for Unified Management) version of the controller 1. | [optional] [readonly] 
**Ctl2Ip** | **String** | IP address of controller 2 of the storage system. | [optional] [readonly] 
**Ctl2MicroVersion** | **String** | GUM (Gateway for Unified Management) version of the controller 2. | [optional] [readonly] 
**DeviceId** | **String** | ID of the Storage device. | [optional] [readonly] 
**SvpIp** | **String** | IP address of the SVP. | [optional] [readonly] 
**TargetCtl** | **String** | Controller operated by the REST API. | [optional] [readonly] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$StorageHitachiArrayAllOf = Initialize-IntersightStorageHitachiArrayAllOf  -ClassId null `
 -ObjectType null `
 -Ctl1Ip null `
 -Ctl1MicroVersion null `
 -Ctl2Ip null `
 -Ctl2MicroVersion null `
 -DeviceId null `
 -SvpIp null `
 -TargetCtl null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$StorageHitachiArrayAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

