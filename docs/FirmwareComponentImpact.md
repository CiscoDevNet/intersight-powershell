# FirmwareComponentImpact
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.ComponentImpact"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.ComponentImpact"]
**ComputationError** | **String** | Details for the error that occurred during the reboot validation analysis. | [optional] 
**ComputationStatusDetail** | **String** | The computation status of the estimate operation for a component. * &#x60;Inprogress&#x60; - Upgrade impact calculation is in progress. * &#x60;Completed&#x60; - Upgrade impact calculation is completed. * &#x60;Unavailable&#x60; - Upgrade impact is not available since the image is not present in the Fabric Interconnect. * &#x60;Failed&#x60; - Upgrade impact is not available due to an unknown error. | [optional] [default to "Inprogress"]
**DomainName** | **String** | The endpoint type or name. | [optional] 
**EndPoint** | **String** | A reference to a REST resource, uniquely identified by object type and MOID. | [optional] 
**FirmwareVersion** | **String** | The current firmware version of the component. | [optional] 
**ImpactType** | **String** | The impact type of the endpoint, whether a reboot is required or not. * &#x60;NoReboot&#x60; - A reboot is not required for the endpoint after upgrade. * &#x60;Reboot&#x60; - A reboot is required to the endpoint after upgrade. | [optional] [default to "NoReboot"]
**Model** | **String** | The model details of the component. | [optional] 
**TargetFirmwareVersion** | **String** | The target firmware version of the component. | [optional] 
**VersionImpact** | **String** | The change of version impact for the endpoint. * &#x60;None&#x60; - No change in version for the component. * &#x60;Upgrade&#x60; - The component will be upgraded. * &#x60;Downgrade&#x60; - The component will be downgraded. | [optional] [default to "None"]
**Component** | **String** | Impact on the component after the upgrade. * &#x60;ALL&#x60; - This represents all the components. * &#x60;ALL,HDD&#x60; - This represents all the components plus the HDDs. * &#x60;None&#x60; - This represents none of the components. * &#x60;NXOS&#x60; - This represents NXOS components. * &#x60;IOM&#x60; - This represents IOM components. * &#x60;PSU&#x60; - This represents PSU components. * &#x60;CIMC&#x60; - This represents CIMC components. * &#x60;BIOS&#x60; - This represents BIOS components. * &#x60;PCIE&#x60; - This represents PCIE components. * &#x60;Drive&#x60; - This represents Storage components. * &#x60;DIMM&#x60; - This represents DIMM components. * &#x60;BoardController&#x60; - This represents Board Controller components. * &#x60;StorageController&#x60; - This represents Storage Controller components. * &#x60;HBA&#x60; - This represents HBA components. * &#x60;GPU&#x60; - This represents GPU components. * &#x60;SasExpander&#x60; - This represents SasExpander components. * &#x60;MSwitch&#x60; - This represents mSwitch components. * &#x60;CMC&#x60; - This represents CMC components. | [optional] [default to "ALL"]

## Examples

- Prepare the resource
```powershell
$FirmwareComponentImpact = Initialize-IntersightFirmwareComponentImpact  -ClassId null `
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
 -Component null
```

- Convert the resource to JSON
```powershell
$FirmwareComponentImpact | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

