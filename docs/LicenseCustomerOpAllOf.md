# LicenseCustomerOpAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveAdmin** | **Boolean** | The license administrative state. Set this property to &#39;true&#39; to activate the license entitlements. | [optional] 
**DeregisterDevice** | **Boolean** | Trigger de-registration/disable. | [optional] 
**EnableTrial** | **Boolean** | Enable trial for Intersight licensing. | [optional] 
**EvaluationPeriod** | **Int64** | The default Trial or Grace period customer is entitled to. | [optional] 
**ExtraEvaluation** | **Int64** | The number of days the trial Trial or Grace period is extended. The trial or grace period can be extended once. | [optional] 
**RenewAuthorization** | **Boolean** | Trigger renew authorization. | [optional] 
**RenewIdCertificate** | **Boolean** | Trigger renew registration. | [optional] 
**ShowAgentTechSupport** | **Boolean** | Trigger show tech support feature. | [optional] 
**AccountLicenseData** | [**LicenseAccountLicenseDataRelationship**](LicenseAccountLicenseDataRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightLicenseCustomerOpAllOf  -ActiveAdmin null `
 -DeregisterDevice null `
 -EnableTrial null `
 -EvaluationPeriod null `
 -ExtraEvaluation null `
 -RenewAuthorization null `
 -RenewIdCertificate null `
 -ShowAgentTechSupport null `
 -AccountLicenseData null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

