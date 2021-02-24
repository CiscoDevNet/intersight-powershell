# FirmwareUnsupportedVersionUpgradeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.UnsupportedVersionUpgrade"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.UnsupportedVersionUpgrade"]
**UpgradeStatus** | **String** | Workflow status of firmware upgrade. * &#x60;None&#x60; - Upgrade status is none when upgrade is in progress. * &#x60;Completed&#x60; - Upgrade completed successfully. * &#x60;Failed&#x60; - Upgrade status is failed when upgrade has failed. | [optional] [default to "None"]
**Device** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**Distributable** | [**FirmwareDistributableRelationship**](FirmwareDistributableRelationship.md) |  | [optional] 
**PhysicalIdentity** | [**EquipmentPhysicalIdentityRelationship**](EquipmentPhysicalIdentityRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareUnsupportedVersionUpgradeAllOf = Initialize-IntersightFirmwareUnsupportedVersionUpgradeAllOf  -ClassId null `
 -ObjectType null `
 -UpgradeStatus null `
 -Device null `
 -Distributable null `
 -PhysicalIdentity null
```

- Convert the resource to JSON
```powershell
$FirmwareUnsupportedVersionUpgradeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

