# FirmwareFabricUpgradeImpactAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ImpactDetail** | [**FirmwareComponentImpact[]**](FirmwareComponentImpact.md) |  | [optional] 
**Serial** | **String** | Details for the Fabric Interconnect that will be impacted by the upgrade. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareFabricUpgradeImpactAllOf  -ImpactDetail null `
 -Serial null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

