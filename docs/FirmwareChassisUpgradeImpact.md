# FirmwareChassisUpgradeImpact
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**ComputationError** | **String** | Details for the error that occurred during the reboot validation analysis. | [optional] 
**ComputationStatusDetail** | **String** | The computation status of the estimate operation for a component. | [optional] [default to "Inprogress"]
**DomainName** | **String** | The endpoint type or name. | [optional] 
**EndPoint** | **String** | A reference to a REST resource, uniquely identified by object type and MOID. | [optional] 
**FirmwareVersion** | **String** | The current firmware version of the component. | [optional] 
**ImpactType** | **String** | The impact type of the endpoint, whether a reboot is required or not. | [optional] [default to "NoReboot"]
**Model** | **String** | The model details of the component. | [optional] 
**TargetFirmwareVersion** | **String** | The target firmware version of the component. | [optional] 
**VersionImpact** | **String** | The change of version impact for the endpoint. | [optional] [default to "None"]
**ImpactDetail** | [**FirmwareComponentImpact[]**](FirmwareComponentImpact.md) |  | [optional] 
**Name** | **String** | Name of the chassis that will be affected by the upgrade. | [optional] 
**UserLabel** | **String** | Details for the chassis that will be impacted by the upgrade. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareChassisUpgradeImpact  -ClassId null `
 -ObjectType null `
 -ComputationError null `
 -ComputationStatusDetail null `
 -DomainName null `
 -EndPoint null `
 -FirmwareVersion null `
 -ImpactType null `
 -Model null `
 -TargetFirmwareVersion null `
 -VersionImpact null `
 -ImpactDetail null `
 -Name null `
 -UserLabel null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

