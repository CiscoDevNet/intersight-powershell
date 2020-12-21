# FirmwareBaseImpact
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ComputationError** | **String** | Details for the error that occurred during the reboot validation analysis. | [optional] 
**ComputationStatusDetail** | **String** | The computation status of the estimate operation for a component. * &#x60;Inprogress&#x60; - Upgrade impact calculation is in progress. * &#x60;Completed&#x60; - Upgrade impact calculation is completed. * &#x60;Unavailable&#x60; - Upgrade impact is not available since the image is not present in the Fabric Interconnect. * &#x60;Failed&#x60; - Upgrade impact is not available due to an unknown error. | [optional] [default to "Inprogress"]
**DomainName** | **String** | The endpoint type or name. | [optional] 
**EndPoint** | **String** | A reference to a REST resource, uniquely identified by object type and MOID. | [optional] 
**FirmwareVersion** | **String** | The current firmware version of the component. | [optional] 
**ImpactType** | **String** | The impact type of the endpoint, whether a reboot is required or not. * &#x60;NoReboot&#x60; - A reboot is not required for the endpoint after upgrade. * &#x60;Reboot&#x60; - A reboot is required to the endpoint after upgrade. | [optional] [default to "NoReboot"]
**Model** | **String** | The model details of the component. | [optional] 
**TargetFirmwareVersion** | **String** | The target firmware version of the component. | [optional] 
**VersionImpact** | **String** | The change of version impact for the endpoint. * &#x60;None&#x60; - No change in version for the component. * &#x60;Upgrade&#x60; - The component will be upgraded. * &#x60;Downgrade&#x60; - The component will be downgraded. | [optional] [default to "None"]

## Examples

- Prepare the resource
```powershell
$FirmwareBaseImpact = Initialize-IntersightFirmwareBaseImpact  -ClassId null `
 -ObjectType null `
 -ComputationError null `
 -ComputationStatusDetail null `
 -DomainName null `
 -EndPoint null `
 -FirmwareVersion null `
 -ImpactType null `
 -Model null `
 -TargetFirmwareVersion null `
 -VersionImpact null
```

- Convert the resource to JSON
```powershell
$FirmwareBaseImpact | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

