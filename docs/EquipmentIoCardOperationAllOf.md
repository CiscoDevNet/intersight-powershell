# EquipmentIoCardOperationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminPowerState** | **String** | User configured power state of the iomodule. | [optional] [default to "None"]
**ConfigState** | **String** | The configured state of these settings in the target chassis. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the settings are applied successfully in the target chassis iomodule. Applying - This state denotes that the settings are being applied in the target chassis iomodule. Failed - This state denotes that the settings could not be applied in the target chassis iomodule. | [optional] [readonly] [default to "None"]
**DeviceRegistration** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**IoCard** | [**EquipmentIoCardRelationship**](EquipmentIoCardRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentIoCardOperationAllOf  -AdminPowerState null `
 -ConfigState null `
 -DeviceRegistration null `
 -IoCard null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

