# EquipmentIoCardOperationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "equipment.IoCardOperation"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "equipment.IoCardOperation"]
**AdminPowerState** | **String** | User configured power state of the iomodule. * &#x60;None&#x60; - Placeholder default value for iom power state property. * &#x60;Reboot&#x60; - IO Module reboot state property value. | [optional] [default to "None"]
**ConfigState** | **String** | The configured state of these settings in the target chassis. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the settings are applied successfully in the target chassis iomodule. Applying - This state denotes that the settings are being applied in the target chassis iomodule. Failed - This state denotes that the settings could not be applied in the target chassis iomodule. * &#x60;None&#x60; - Nil value when no action has been triggered by the user. * &#x60;Applied&#x60; - User configured settings are in applied state. * &#x60;Applying&#x60; - User settings are being applied on the target server. * &#x60;Failed&#x60; - User configured settings could not be applied. | [optional] [readonly] [default to "None"]
**DeviceRegistration** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**IoCard** | [**EquipmentIoCardRelationship**](EquipmentIoCardRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$EquipmentIoCardOperationAllOf = Initialize-IntersightEquipmentIoCardOperationAllOf  -ClassId null `
 -ObjectType null `
 -AdminPowerState null `
 -ConfigState null `
 -DeviceRegistration null `
 -IoCard null
```

- Convert the resource to JSON
```powershell
$EquipmentIoCardOperationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

