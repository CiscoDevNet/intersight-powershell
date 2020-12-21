# LicenseLicenseInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "license.LicenseInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "license.LicenseInfo"]
**ActiveAdmin** | **Boolean** | The license administrative state. Set this property to &#39;true&#39; to activate the license entitlements. | [optional] [readonly] 
**DaysLeft** | **Int64** | The number of days left for licenseState to stay in TrialPeriod or OutOfCompliance state. | [optional] [readonly] 
**EndTime** | **System.DateTime** | The date and time when the trial period expires. The value of the &#39;endTime&#39; property is set when the account enters the TrialPeriod or OutOfCompliance state. | [optional] [readonly] 
**EnforceMode** | **String** | The entitlement mode reported by Cisco Smart Software Manager. | [optional] [readonly] 
**ErrorDesc** | **String** | The detailed error message when there is any error related to this licensing entitlement. | [optional] [readonly] 
**EvaluationPeriod** | **Int64** | The default Trial or Grace period customer is entitled to. | [optional] 
**ExtraEvaluation** | **Int64** | The number of days the trial Trial or Grace period is extended. The trial or grace period can be extended once. | [optional] 
**LicenseCount** | **Int64** | The total number of devices claimed in the Intersight account. | [optional] [readonly] 
**LicenseState** | **String** | The license state defined by Intersight. The value may be one of NotLicensed, TrialPeriod, OutOfCompliance, Compliance, GraceExpired, or TrialExpired. * &#x60;NotLicensed&#x60; - The license token is neither activated nor registered. * &#x60;GraceExpired&#x60; - The license grace period has expired. * &#x60;TrialPeriod&#x60; - The 90 days of trial period. * &#x60;OutOfCompliance&#x60; - The license is out of compliance. * &#x60;Compliance&#x60; - The license is in compliance. * &#x60;TrialExpired&#x60; - The trial period of 90 days has expired. | [optional] [readonly] [default to "NotLicensed"]
**LicenseType** | **String** | The name of the Intersight license entitlement. For example, this property may be set to &#39;Essential&#39;. * &#x60;Base&#x60; - Base as a License type. It is default license type. * &#x60;Essential&#x60; - Essential as a License type. * &#x60;Standard&#x60; - Standard as a License type. * &#x60;Advantage&#x60; - Advantage as a License type. * &#x60;Premier&#x60; - Premier as a License type. * &#x60;IWO-Essential&#x60; - IWO-Essential as a License type. * &#x60;IWO-Advantage&#x60; - IWO-Advantage as a License type. * &#x60;IWO-Premier&#x60; - IWO-Premier as a License type. | [optional] [readonly] [default to "Base"]
**StartTime** | **System.DateTime** | The date and time when the licenseState entered the TrialPeriod or OutOfCompliance state. | [optional] [readonly] 
**TrialAdmin** | **Boolean** | The administrative state of the trial license. When the LicenseState is set to &#39;NotLicensed&#39;, &#39;trialAdmin&#39; can be set to true to start the trial period, i.e. licenseState is set to be TrialPeriod. | [optional] [readonly] 
**AccountLicenseData** | [**LicenseAccountLicenseDataRelationship**](LicenseAccountLicenseDataRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$LicenseLicenseInfoAllOf = Initialize-IntersightLicenseLicenseInfoAllOf  -ClassId null `
 -ObjectType null `
 -ActiveAdmin null `
 -DaysLeft null `
 -EndTime null `
 -EnforceMode null `
 -ErrorDesc null `
 -EvaluationPeriod null `
 -ExtraEvaluation null `
 -LicenseCount null `
 -LicenseState null `
 -LicenseType null `
 -StartTime null `
 -TrialAdmin null `
 -AccountLicenseData null
```

- Convert the resource to JSON
```powershell
$LicenseLicenseInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

