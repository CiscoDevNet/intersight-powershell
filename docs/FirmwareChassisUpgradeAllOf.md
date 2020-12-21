# FirmwareChassisUpgradeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.ChassisUpgrade"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.ChassisUpgrade"]
**ExcludeComponentList** | **String[]** |  | [optional] 
**Chassis** | [**EquipmentChassisRelationship**](EquipmentChassisRelationship.md) |  | [optional] 
**Device** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareChassisUpgradeAllOf = Initialize-IntersightFirmwareChassisUpgradeAllOf  -ClassId null `
 -ObjectType null `
 -ExcludeComponentList null `
 -Chassis null `
 -Device null
```

- Convert the resource to JSON
```powershell
$FirmwareChassisUpgradeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

