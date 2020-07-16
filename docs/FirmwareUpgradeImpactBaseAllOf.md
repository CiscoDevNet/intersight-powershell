# FirmwareUpgradeImpactBaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Components** | **String[]** |  | [optional] 
**ComputationState** | **String** | Captures the status of an upgrade impact calculation. Indicates whether the calculation is complete, in progress or the calculation is impossible due to the absence of the target image on the endpoint. | [optional] [default to "Inprogress"]
**ExcludeComponents** | **String[]** |  | [optional] 
**Impacts** | [**FirmwareBaseImpact[]**](FirmwareBaseImpact.md) |  | [optional] 
**Summary** | **String** | The summary on the component or components getting impacted by the upgrade. | [optional] [default to "Basic"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareUpgradeImpactBaseAllOf  -Components null `
 -ComputationState null `
 -ExcludeComponents null `
 -Impacts null `
 -Summary null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

