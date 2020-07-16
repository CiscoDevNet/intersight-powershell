# NiaapiSoftwareEolAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AffectedVersions** | **String** | String contains the Release versions affected by this notice, seperated by comma. | [optional] 
**AnnouncementDate** | **System.DateTime** | Date time of this notice Announced. | [optional] 
**AnnouncementDateEpoch** | **Int64** | Epoch time of this notice Announced. | [optional] 
**BulletinNo** | **String** | The bulletinno of this software release end of life notice. | [optional] 
**Description** | **String** | The description of this software release end of life notice. | [optional] 
**EndofNewServiceAttachmentDate** | **System.DateTime** | Date time of End of New service attachment . | [optional] 
**EndofNewServiceAttachmentDateEpoch** | **Int64** | Epoch time of End of New service attachment . | [optional] 
**EndofServiceContractRenewalDate** | **System.DateTime** | Date time of End of Renewal of service contract . | [optional] 
**EndofServiceContractRenewalDateEpoch** | **Int64** | Epoch time of End of Renewal of service contract . | [optional] 
**EndofSwMaintenanceDate** | **System.DateTime** | Date time of End of Maintenance. | [optional] 
**EndofSwMaintenanceDateEpoch** | **Int64** | Epoch time of End of Maintenance. | [optional] 
**Headline** | **String** | The title of this software release end of life notice. | [optional] 
**LastDateofSupport** | **System.DateTime** | Date time of Last day of Support . | [optional] 
**LastDateofSupportEpoch** | **Int64** | Epoch time of Last day of Support . | [optional] 
**LastShipDate** | **System.DateTime** | Date time of Lastship Date. | [optional] 
**LastShipDateEpoch** | **Int64** | Epoch time of Lastship Date. | [optional] 
**MigrationUrl** | **String** | The URL of this migration notice. | [optional] 
**SoftwareEolUrl** | **String** | Software end of life notice URL link to the notice webpage. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNiaapiSoftwareEolAllOf  -AffectedVersions null `
 -AnnouncementDate null `
 -AnnouncementDateEpoch null `
 -BulletinNo null `
 -Description null `
 -EndofNewServiceAttachmentDate null `
 -EndofNewServiceAttachmentDateEpoch null `
 -EndofServiceContractRenewalDate null `
 -EndofServiceContractRenewalDateEpoch null `
 -EndofSwMaintenanceDate null `
 -EndofSwMaintenanceDateEpoch null `
 -Headline null `
 -LastDateofSupport null `
 -LastDateofSupportEpoch null `
 -LastShipDate null `
 -LastShipDateEpoch null `
 -MigrationUrl null `
 -SoftwareEolUrl null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

