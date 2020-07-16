# FirmwareServerUpgradeImpactAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ImpactDetail** | [**FirmwareComponentImpact[]**](FirmwareComponentImpact.md) |  | [optional] 
**Name** | **String** | Name of the server impacted by the upgrade. | [optional] 
**UserLabel** | **String** | Details about the server which will be impacted by the upgrade. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareServerUpgradeImpactAllOf  -ImpactDetail null `
 -Name null `
 -UserLabel null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

