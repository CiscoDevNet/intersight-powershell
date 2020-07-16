# EquipmentIdentitySummaryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdapterSerial** | **String** | Serial Identifier of an adapter participating in SWM. | [optional] [readonly] 
**AdminAction** | **String** | Updated by UI/API to trigger specific chassis action type. | [optional] [readonly] [default to "None"]
**AdminActionState** | **String** | The state of Maintenance Action performed. This will have three states. Applying - Action is in progress. Applied - Action is completed and applied. Failed - Action has failed. | [optional] [readonly] [default to "None"]
**ChassisId** | **Int64** | Chassis Identifier of a blade server. | [optional] [readonly] 
**DeviceMoId** | **String** | FI Device registration Mo ID. | [optional] [readonly] 
**Identifier** | **Int64** | Numeric Identifier assigned by the management system to the equipment. | [optional] [readonly] 
**IoCardIdentityList** | [**EquipmentIoCardIdentity[]**](EquipmentIoCardIdentity.md) |  | [optional] 
**Lifecycle** | **String** | The equipment&#39;s lifecycle status. | [optional] [readonly] [default to "None"]
**Model** | **String** | The vendor provided model name for the equipment. | [optional] [readonly] 
**PendingDiscovery** | **String** | Indicates pending discovery flag. | [optional] [readonly] 
**Serial** | **String** | The serial number of the equipment. | [optional] [readonly] 
**SlotId** | **Int64** | Chassis slot number of a blade server. | [optional] [readonly] 
**SourceObjectType** | **String** | The source object type of this view MO. | [optional] [readonly] 
**SwitchId** | **Int64** | Switch ID to which Fabric Extender is connected, ID can be either 1 or 2, equalent to A or B. | [optional] [readonly] 
**Vendor** | **String** | The manufacturer of the equipment. | [optional] [readonly] 
**DeviceRegistration** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightEquipmentIdentitySummaryAllOf  -AdapterSerial null `
 -AdminAction null `
 -AdminActionState null `
 -ChassisId null `
 -DeviceMoId null `
 -Identifier null `
 -IoCardIdentityList null `
 -Lifecycle null `
 -Model null `
 -PendingDiscovery null `
 -Serial null `
 -SlotId null `
 -SourceObjectType null `
 -SwitchId null `
 -Vendor null `
 -DeviceRegistration null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

