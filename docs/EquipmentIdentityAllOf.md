# EquipmentIdentityAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminAction** | **String** | Updated by UI/API to trigger specific chassis action type. | [optional] [default to "None"]
**AdminActionState** | **String** | The state of Maintenance Action performed. This will have three states. Applying - Action is in progress. Applied - Action is completed and applied. Failed - Action has failed. | [optional] [default to "None"]
**Identifier** | **Int64** | Numeric Identifier assigned by the management system to the equipment. | [optional] 
**Lifecycle** | **String** | The equipment&#39;s lifecycle status. | [optional] [default to "None"]
**Model** | **String** | The vendor provided model name for the equipment. | [optional] 
**Serial** | **String** | The serial number of the equipment. | [optional] 
**Vendor** | **String** | The manufacturer of the equipment. | [optional] 
**DeviceRegistration** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentIdentityAllOf  -AdminAction null `
 -AdminActionState null `
 -Identifier null `
 -Lifecycle null `
 -Model null `
 -Serial null `
 -Vendor null `
 -DeviceRegistration null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

