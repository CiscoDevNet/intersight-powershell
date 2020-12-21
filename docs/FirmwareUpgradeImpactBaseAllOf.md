# FirmwareUpgradeImpactBaseAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Components** | **String[]** |  | [optional] 
**ComputationState** | **String** | Captures the status of an upgrade impact calculation. Indicates whether the calculation is complete, in progress or the calculation is impossible due to the absence of the target image on the endpoint. * &#x60;Inprogress&#x60; - Upgrade impact calculation is in progress. * &#x60;Completed&#x60; - Upgrade impact calculation is completed. * &#x60;Unavailable&#x60; - Upgrade impact is not available since image is not present in FI. | [optional] [default to "Inprogress"]
**ExcludeComponents** | **String[]** |  | [optional] 
**Impacts** | [**FirmwareBaseImpact[]**](FirmwareBaseImpact.md) |  | [optional] 
**Summary** | **String** | The summary on the component or components getting impacted by the upgrade. * &#x60;Basic&#x60; - Summary of a single instance involved in the upgrade operation. * &#x60;Detail&#x60; - Summary of the collection of single instances for a complex component involved in the upgrade operation. For example, in case of a server upgrade, a detailed summary indicates impact of all the single instances which are part of the server, such as storage controller, drives, and BIOS. | [optional] [default to "Basic"]

## Examples

- Prepare the resource
```powershell
$FirmwareUpgradeImpactBaseAllOf = Initialize-IntersightFirmwareUpgradeImpactBaseAllOf  -ClassId null `
 -ObjectType null `
 -Components null `
 -ComputationState null `
 -ExcludeComponents null `
 -Impacts null `
 -Summary null
```

- Convert the resource to JSON
```powershell
$FirmwareUpgradeImpactBaseAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

