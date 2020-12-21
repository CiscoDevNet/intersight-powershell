# EquipmentFexOperationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "equipment.FexOperation"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "equipment.FexOperation"]
**AdminLocatorLedAction** | **String** | Action performed on the locator LED for a FEX. * &#x60;None&#x60; - No operation action for the Locator Led of an equipment. * &#x60;TurnOn&#x60; - Turn on the Locator Led of an equipment. * &#x60;TurnOff&#x60; - Turn off the Locator Led of an equipment. | [optional] [default to "None"]
**AdminLocatorLedActionState** | **String** | Defines status of action performed on AdminLocatorLedState. * &#x60;None&#x60; - Nil value when no action has been triggered by the user. * &#x60;Applied&#x60; - User configured settings are in applied state. * &#x60;Applying&#x60; - User settings are being applied on the target server. * &#x60;Failed&#x60; - User configured settings could not be applied. | [optional] [default to "None"]
**DeviceRegistration** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Fex** | [**EquipmentFexRelationship**](EquipmentFexRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$EquipmentFexOperationAllOf = Initialize-IntersightEquipmentFexOperationAllOf  -ClassId null `
 -ObjectType null `
 -AdminLocatorLedAction null `
 -AdminLocatorLedActionState null `
 -DeviceRegistration null `
 -Fex null
```

- Convert the resource to JSON
```powershell
$EquipmentFexOperationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

