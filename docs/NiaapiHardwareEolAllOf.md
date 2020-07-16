# NiaapiHardwareEolAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AffectedPids** | **String** | String contains the PID of hardwares affected by this notice, seperated by comma. | [optional] 
**AnnouncementDate** | **System.DateTime** | When this notice is announced. | [optional] 
**AnnouncementDateEpoch** | **Int64** | Epoch time of Announcement Date. | [optional] 
**BulletinNo** | **String** | The bulletinno of this hardware end of life notice. | [optional] 
**Description** | **String** | The description of this hardware end of life notice. | [optional] 
**EndofNewServiceAttachmentDate** | **System.DateTime** | Date time of end of new services attachment  . | [optional] 
**EndofNewServiceAttachmentDateEpoch** | **Int64** | Epoch time of New service attachment Date . | [optional] 
**EndofRoutineFailureAnalysisDate** | **System.DateTime** | Date time of end of routinefailure analysis. | [optional] 
**EndofRoutineFailureAnalysisDateEpoch** | **Int64** | Epoch time of End of Routine Failure Analysis Date. | [optional] 
**EndofSaleDate** | **System.DateTime** | When this hardware will end sale. | [optional] 
**EndofSaleDateEpoch** | **Int64** | Epoch time of End of Sale Date. | [optional] 
**EndofSecuritySupport** | **System.DateTime** | Date time of end of security support . | [optional] 
**EndofSecuritySupportEpoch** | **Int64** | Epoch time of End of Security Support Date . | [optional] 
**EndofServiceContractRenewalDate** | **System.DateTime** | Date time of end of service contract renew . | [optional] 
**EndofServiceContractRenewalDateEpoch** | **Int64** | Epoch time of End of Renewal service contract. | [optional] 
**EndofSwMaintenanceDate** | **System.DateTime** | The date of end of maintainance. | [optional] 
**EndofSwMaintenanceDateEpoch** | **Int64** | Epoch time of End of maintenance Date. | [optional] 
**HardwareEolUrl** | **String** | Hardware end of sale URL link to the notice webpage. | [optional] 
**Headline** | **String** | The title of this hardware end of life notice. | [optional] 
**LastDateofSupport** | **System.DateTime** | Date time of end of support . | [optional] 
**LastDateofSupportEpoch** | **Int64** | Epoch time of last date of support . | [optional] 
**LastShipDate** | **System.DateTime** | Date time of Lastship Date. | [optional] 
**LastShipDateEpoch** | **Int64** | Epoch time of last ship Date. | [optional] 
**MigrationUrl** | **String** | The URL of this migration notice. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNiaapiHardwareEolAllOf  -AffectedPids null `
 -AnnouncementDate null `
 -AnnouncementDateEpoch null `
 -BulletinNo null `
 -Description null `
 -EndofNewServiceAttachmentDate null `
 -EndofNewServiceAttachmentDateEpoch null `
 -EndofRoutineFailureAnalysisDate null `
 -EndofRoutineFailureAnalysisDateEpoch null `
 -EndofSaleDate null `
 -EndofSaleDateEpoch null `
 -EndofSecuritySupport null `
 -EndofSecuritySupportEpoch null `
 -EndofServiceContractRenewalDate null `
 -EndofServiceContractRenewalDateEpoch null `
 -EndofSwMaintenanceDate null `
 -EndofSwMaintenanceDateEpoch null `
 -HardwareEolUrl null `
 -Headline null `
 -LastDateofSupport null `
 -LastDateofSupportEpoch null `
 -LastShipDate null `
 -LastShipDateEpoch null `
 -MigrationUrl null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

