# FirmwareUpgradeImpactAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Chassis** | [**EquipmentChassisRelationship[]**](EquipmentChassisRelationship.md) | An array of relationships to equipmentChassis resources. | [optional] 
**Device** | [**AssetDeviceRegistrationRelationship[]**](AssetDeviceRegistrationRelationship.md) | An array of relationships to assetDeviceRegistration resources. | [optional] [readonly] 
**Distributable** | [**FirmwareDistributableRelationship**](FirmwareDistributableRelationship.md) |  | [optional] 
**NetworkElements** | [**NetworkElementRelationship[]**](NetworkElementRelationship.md) | An array of relationships to networkElement resources. | [optional] 
**Release** | [**SoftwarerepositoryReleaseRelationship**](SoftwarerepositoryReleaseRelationship.md) |  | [optional] 
**Server** | [**ComputePhysicalRelationship[]**](ComputePhysicalRelationship.md) | An array of relationships to computePhysical resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareUpgradeImpactAllOf  -Chassis null `
 -Device null `
 -Distributable null `
 -NetworkElements null `
 -Release null `
 -Server null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

