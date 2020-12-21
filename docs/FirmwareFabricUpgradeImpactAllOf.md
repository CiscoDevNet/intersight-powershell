# FirmwareFabricUpgradeImpactAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.FabricUpgradeImpact"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.FabricUpgradeImpact"]
**ImpactDetail** | [**FirmwareComponentImpact[]**](FirmwareComponentImpact.md) |  | [optional] 
**Serial** | **String** | Details for the Fabric Interconnect that will be impacted by the upgrade. | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareFabricUpgradeImpactAllOf = Initialize-IntersightFirmwareFabricUpgradeImpactAllOf  -ClassId null `
 -ObjectType null `
 -ImpactDetail null `
 -Serial null
```

- Convert the resource to JSON
```powershell
$FirmwareFabricUpgradeImpactAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

