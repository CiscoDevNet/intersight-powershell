# FirmwareComponentMetaAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "firmware.ComponentMeta"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "firmware.ComponentMeta"]
**ComponentLabel** | **String** | The name of the component in the compressed HSU bundle. | [optional] 
**ComponentType** | **String** | The type of component image within the distributable. * &#x60;ALL&#x60; - This represents all the components. * &#x60;ALL,HDD&#x60; - This represents all the components plus the HDDs. * &#x60;None&#x60; - This represents none of the components. * &#x60;NXOS&#x60; - This represents NXOS components. * &#x60;IOM&#x60; - This represents IOM components. * &#x60;PSU&#x60; - This represents PSU components. * &#x60;CIMC&#x60; - This represents CIMC components. * &#x60;BIOS&#x60; - This represents BIOS components. * &#x60;PCIE&#x60; - This represents PCIE components. * &#x60;Drive&#x60; - This represents Storage components. * &#x60;DIMM&#x60; - This represents DIMM components. * &#x60;BoardController&#x60; - This represents Board Controller components. * &#x60;StorageController&#x60; - This represents Storage Controller components. * &#x60;HBA&#x60; - This represents HBA components. * &#x60;GPU&#x60; - This represents GPU components. * &#x60;SasExpander&#x60; - This represents SasExpander components. * &#x60;MSwitch&#x60; - This represents mSwitch components. * &#x60;CMC&#x60; - This represents CMC components. | [optional] [default to "ALL"]
**Description** | **String** | This shows the description of component image within the distributable. | [optional] 
**Disruption** | **String** | The type of disruption on each component. For example, host reboot, automatic power cycle, and manual power cycle. * &#x60;None&#x60; - Indicates that the component did not receive a disruption request. * &#x60;HostReboot&#x60; - Indicates that the component received a host reboot request. * &#x60;EndpointReboot&#x60; - Indicates that the component received an end point reboot request. * &#x60;ManualPowerCycle&#x60; - Indicates that the component received a manual power cycle request. * &#x60;AutomaticPowerCycle&#x60; - Indicates that the component received an automatic power cycle request. | [optional] [default to "None"]
**ImagePath** | **String** | This shows the path of component image within the distributable. | [optional] 
**IsOobSupported** | **Boolean** | If set, the component can be updated through out-of-band management, else, is updated through host service utility boot. | [optional] 
**Model** | **String** | The model of the component image in the distributable. | [optional] 
**OobManageability** | **String[]** |  | [optional] 
**PackedVersion** | **String** | The image version of components packaged in the distributable. | [optional] 
**RedfishUrl** | **String** | The redfish target for each component. | [optional] 
**Vendor** | **String** | The version of component image in the distributable. | [optional] 

## Examples

- Prepare the resource
```powershell
$FirmwareComponentMetaAllOf = Initialize-IntersightFirmwareComponentMetaAllOf  -ClassId null `
 -ObjectType null `
 -ComponentLabel null `
 -ComponentType null `
 -Description null `
 -Disruption null `
 -ImagePath null `
 -IsOobSupported null `
 -Model null `
 -OobManageability null `
 -PackedVersion null `
 -RedfishUrl null `
 -Vendor null
```

- Convert the resource to JSON
```powershell
$FirmwareComponentMetaAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

