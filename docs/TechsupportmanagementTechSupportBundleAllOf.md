# TechsupportmanagementTechSupportBundleAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceIdentifier** | **String** | The device identifier used to uniquely identify an individual device. | [optional] [readonly] 
**DeviceType** | **String** | The device type obtained from the inventory. | [optional] [readonly] 
**VarPid** | **String** | Product identification of the device. | [optional] 
**PlatformParam** | [**ConnectorPlatformParamBase**](ConnectorPlatformParamBase.md) |  | [optional] 
**PlatformType** | **String** | The platform type of the device. | [optional] [default to ""]
**Serial** | **String** | Serial number of the device. | [optional] 
**DeviceRegistration** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**TargetResource** | [**MoBaseMoRelationship**](MoBaseMoRelationship.md) |  | [optional] 
**TechSupportStatus** | [**TechsupportmanagementTechSupportStatusRelationship**](TechsupportmanagementTechSupportStatusRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTechsupportmanagementTechSupportBundleAllOf  -DeviceIdentifier null `
 -DeviceType null `
 -VarPid null `
 -PlatformParam null `
 -PlatformType null `
 -Serial null `
 -DeviceRegistration null `
 -TargetResource null `
 -TechSupportStatus null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

