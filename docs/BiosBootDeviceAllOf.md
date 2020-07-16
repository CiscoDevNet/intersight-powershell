# BiosBootDeviceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceName** | **String** | Name of the Configured Boot Device. | [optional] [readonly] 
**DeviceType** | **String** | Type of the Configured Boot Device. | [optional] [readonly] 
**BiosSystemBootOrder** | [**BiosSystemBootOrderRelationship**](BiosSystemBootOrderRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightBiosBootDeviceAllOf  -DeviceName null `
 -DeviceType null `
 -BiosSystemBootOrder null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

