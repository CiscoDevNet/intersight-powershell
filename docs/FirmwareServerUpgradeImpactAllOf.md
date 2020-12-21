# FirmwareServerUpgradeImpactAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.ServerUpgradeImpact"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.ServerUpgradeImpact"]
**ImpactDetail** | [**FirmwareComponentImpact[]**](FirmwareComponentImpact.md) |  | [optional] 
**Name** | **String** | Name of the server impacted by the upgrade. | [optional] 
**UserLabel** | **String** | Details about the server which will be impacted by the upgrade. | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareServerUpgradeImpactAllOf = Initialize-IntersightFirmwareServerUpgradeImpactAllOf  -ClassId null `
 -ObjectType null `
 -ImpactDetail null `
 -Name null `
 -UserLabel null
```

- Convert the resource to JSON
```powershell
$FirmwareServerUpgradeImpactAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

