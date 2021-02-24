# FirmwareSwitchUpgradeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.SwitchUpgrade"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.SwitchUpgrade"]
**EnableFabricEvacuation** | **Boolean** | The flag to enable or disable fabric evacuation during the switch firmware upgrade. In case of IMM, it is mandatory to have the Fabric Interconnects associated with domain profile for fabric evacuation to happen. | [optional] [default to $true]
**Device** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 
**NetworkElements** | [**NetworkElementRelationship[]**](NetworkElementRelationship.md) | An array of relationships to networkElement resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareSwitchUpgradeAllOf = Initialize-IntersightFirmwareSwitchUpgradeAllOf  -ClassId null `
 -ObjectType null `
 -EnableFabricEvacuation null `
 -Device null `
 -NetworkElements null
```

- Convert the resource to JSON
```powershell
$FirmwareSwitchUpgradeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

