# EquipmentFexOperationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminLocatorLedAction** | **String** | Action performed on the locator LED for a FEX. | [optional] [default to "None"]
**AdminLocatorLedActionState** | **String** | Defines status of action performed on AdminLocatorLedState. | [optional] [default to "None"]
**DeviceRegistration** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Fex** | [**EquipmentFexRelationship**](EquipmentFexRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentFexOperationAllOf  -AdminLocatorLedAction null `
 -AdminLocatorLedActionState null `
 -DeviceRegistration null `
 -Fex null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

