# LicenseLicenseInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveAdmin** | **Boolean** | The license administrative state. Set this property to &#39;true&#39; to activate the license entitlements. | [optional] [readonly] 
**DaysLeft** | **Int64** | The number of days left for licenseState to stay in TrialPeriod or OutOfCompliance state. | [optional] [readonly] 
**EndTime** | **System.DateTime** | The date and time when the trial period expires. The value of the &#39;endTime&#39; property is set when the account enters the TrialPeriod or OutOfCompliance state. | [optional] [readonly] 
**EnforceMode** | **String** | The entitlement mode reported by Cisco Smart Software Manager. | [optional] [readonly] 
**ErrorDesc** | **String** | The detailed error message when there is any error related to this licensing entitlement. | [optional] [readonly] 
**EvaluationPeriod** | **Int64** | The default Trial or Grace period customer is entitled to. | [optional] 
**ExtraEvaluation** | **Int64** | The number of days the trial Trial or Grace period is extended. The trial or grace period can be extended once. | [optional] 
**LicenseCount** | **Int64** | The total number of devices claimed in the Intersight account. | [optional] [readonly] 
**LicenseState** | **String** | The license state defined by Intersight. The value may be one of NotLicensed, TrialPeriod, OutOfCompliance, Compliance, GraceExpired, or TrialExpired. | [optional] [readonly] [default to "NotLicensed"]
**LicenseType** | **String** | The name of the Intersight license entitlement. For example, this property may be set to &#39;Essential&#39;. | [optional] [readonly] [default to "Base"]
**StartTime** | **System.DateTime** | The date and time when the licenseState entered the TrialPeriod or OutOfCompliance state. | [optional] [readonly] 
**TrialAdmin** | **Boolean** | The administrative state of the trial license. When the LicenseState is set to &#39;NotLicensed&#39;, &#39;trialAdmin&#39; can be set to true to start the trial period, i.e. licenseState is set to be TrialPeriod. | [optional] [readonly] 
**AccountLicenseData** | [**LicenseAccountLicenseDataRelationship**](LicenseAccountLicenseDataRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightLicenseLicenseInfoAllOf  -ActiveAdmin null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

