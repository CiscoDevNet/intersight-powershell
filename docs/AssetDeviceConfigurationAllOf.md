# AssetDeviceConfigurationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocalConfigurationLocked** | **Boolean** | Specifies whether configuration through the platforms local management interface has been disabled, with only configuration through the Intersight service enabled. | [optional] 
**LogLevel** | **String** | The log level of the device connector service. | [optional] 
**Device** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightAssetDeviceConfigurationAllOf  -LocalConfigurationLocked null `
 -LogLevel null `
 -Device null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

