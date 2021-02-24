# NiatelemetryEpgAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niatelemetry.Epg"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niatelemetry.Epg"]
**AzurePackCount** | **Int64** | Azure Pack NAT with ASA feature usage. | [optional] 
**Dn** | **String** | Dn value for the End Point Groups present. | [optional] 
**EpgDelimiterCount** | **Int64** | Number of  objects with delimiter value present in EPG Delimiter attribute. | [optional] 
**FcNpvCount** | **Int64** | Number of ports with FC path attribute of type FC. | [optional] 
**FcoeCount** | **String** | Number of FCoE per End Point Group. | [optional] 
**FvRsDomAttCount** | **Int64** | Number of FvRsDomAtt objects per End Point Group with VMware configuration. | [optional] 
**IntraEpgDvsBmCount** | **Int64** | Intra End Point Group Contract for Distributed Virtual Switch and BM feature usage. | [optional] 
**IntraEpgHyperv** | **String** | Intra EPG Isolation for Hyper-V, enabled if pcEnfPref attribute is set to enforced. | [optional] 
**IsAttrBased** | **String** | Gets the state of End Point Groups with isAttrBasedEPg value as configured. | [optional] 
**Microsegmentation** | **String** | Gets the state of End Point Groups where microsegmentation is present. | [optional] 
**MicrosoftUsegCount** | **Int64** | Number of FvRsDomAtt objects per End Point Group with Microsoft configuration. | [optional] 
**Name** | **String** | Name value for the End Point Groups present. | [optional] 
**OrchslDevVipCfgCount** | **Int64** | Number of objects with Simplified Service Graph Integration with Windows Azure Pack. | [optional] 
**RecordType** | **String** | Type of record DCNM / APIC / SE. This determines the type of platform where inventory was collected. | [optional] 
**RecordVersion** | **String** | Version of record being pushed. This determines what was the API version for data available from the device. | [optional] 
**SiteName** | **String** | The Site name represents an APIC cluster. Service Engine can onboard multiple APIC clusters / sites. | [optional] 
**UsegHypervCount** | **Int64** | Logical Operators for attribute based microsegmentation in a hypervisor. | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$NiatelemetryEpgAllOf = Initialize-IntersightNiatelemetryEpgAllOf  -ClassId null `
 -ObjectType null `
 -AzurePackCount null `
 -Dn null `
 -EpgDelimiterCount null `
 -FcNpvCount null `
 -FcoeCount null `
 -FvRsDomAttCount null `
 -IntraEpgDvsBmCount null `
 -IntraEpgHyperv null `
 -IsAttrBased null `
 -Microsegmentation null `
 -MicrosoftUsegCount null `
 -Name null `
 -OrchslDevVipCfgCount null `
 -RecordType null `
 -RecordVersion null `
 -SiteName null `
 -UsegHypervCount null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$NiatelemetryEpgAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

