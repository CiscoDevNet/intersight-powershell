# FirmwareUpgradeImpactAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.UpgradeImpact"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.UpgradeImpact"]
**Chassis** | [**EquipmentChassisRelationship[]**](EquipmentChassisRelationship.md) | An array of relationships to equipmentChassis resources. | [optional] 
**Device** | [**AssetDeviceRegistrationRelationship[]**](AssetDeviceRegistrationRelationship.md) | An array of relationships to assetDeviceRegistration resources. | [optional] [readonly] 
**Distributable** | [**FirmwareDistributableRelationship**](FirmwareDistributableRelationship.md) |  | [optional] 
**NetworkElements** | [**NetworkElementRelationship[]**](NetworkElementRelationship.md) | An array of relationships to networkElement resources. | [optional] 
**Release** | [**SoftwarerepositoryReleaseRelationship**](SoftwarerepositoryReleaseRelationship.md) |  | [optional] 
**Server** | [**ComputePhysicalRelationship[]**](ComputePhysicalRelationship.md) | An array of relationships to computePhysical resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareUpgradeImpactAllOf = Initialize-IntersightFirmwareUpgradeImpactAllOf  -ClassId null `
 -ObjectType null `
 -Chassis null `
 -Device null `
 -Distributable null `
 -NetworkElements null `
 -Release null `
 -Server null
```

- Convert the resource to JSON
```powershell
$FirmwareUpgradeImpactAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

