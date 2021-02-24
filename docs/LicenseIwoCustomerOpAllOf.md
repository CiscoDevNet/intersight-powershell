# LicenseIwoCustomerOpAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "license.IwoCustomerOp"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "license.IwoCustomerOp"]
**ActiveAdmin** | **Boolean** | The workload optimizer license administrative state. Set this property to &#39;true&#39; to activate the workload optimizer license entitlements. | [optional] 
**ActiveLicenseType** | **String** | Active workload optimizer license tier set by user. * &#x60;Base&#x60; - Base as a License type. It is default license type. * &#x60;Essential&#x60; - Essential as a License type. * &#x60;Standard&#x60; - Standard as a License type. * &#x60;Advantage&#x60; - Advantage as a License type. * &#x60;Premier&#x60; - Premier as a License type. * &#x60;IWO-Essential&#x60; - IWO-Essential as a License type. * &#x60;IWO-Advantage&#x60; - IWO-Advantage as a License type. * &#x60;IWO-Premier&#x60; - IWO-Premier as a License type. | [optional] [default to "Base"]
**EnableTrial** | **Boolean** | Enable trial for Intersight licensing. | [optional] 
**EvaluationPeriod** | **Int64** | The default Trial or Grace period customer is entitled to. | [optional] 
**ExtraEvaluation** | **Int64** | The number of days the trial Trial or Grace period is extended. The trial or grace period can be extended once. | [optional] 
**AccountLicenseData** | [**LicenseAccountLicenseDataRelationship**](LicenseAccountLicenseDataRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$LicenseIwoCustomerOpAllOf = Initialize-IntersightLicenseIwoCustomerOpAllOf  -ClassId null `
 -ObjectType null `
 -ActiveAdmin null `
 -ActiveLicenseType null `
 -EnableTrial null `
 -EvaluationPeriod null `
 -ExtraEvaluation null `
 -AccountLicenseData null
```

- Convert the resource to JSON
```powershell
$LicenseIwoCustomerOpAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

