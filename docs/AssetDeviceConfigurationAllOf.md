# AssetDeviceConfigurationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "asset.DeviceConfiguration"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "asset.DeviceConfiguration"]
**LocalConfigurationLocked** | **Boolean** | Specifies whether configuration through the platforms local management interface has been disabled, with only configuration through the Intersight service enabled. | [optional] 
**LogLevel** | **String** | The log level of the device connector service. | [optional] 
**Device** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$AssetDeviceConfigurationAllOf = Initialize-IntersightAssetDeviceConfigurationAllOf  -ClassId null `
 -ObjectType null `
 -LocalConfigurationLocked null `
 -LogLevel null `
 -Device null
```

- Convert the resource to JSON
```powershell
$AssetDeviceConfigurationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

