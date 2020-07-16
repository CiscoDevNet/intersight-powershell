# IaasLicenseInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LicenseExpirationDate** | **String** | UCS Director license expiration date. | [optional] [readonly] 
**LicenseKeysInfo** | [**IaasLicenseKeysInfo[]**](IaasLicenseKeysInfo.md) |  | [optional] 
**LicenseType** | **String** | License type of UCSD whether it is EVAL/Permanent/Subscription.. | [optional] [readonly] 
**LicenseUtilizationInfo** | [**IaasLicenseUtilizationInfo[]**](IaasLicenseUtilizationInfo.md) |  | [optional] 
**Guid** | [**IaasUcsdInfoRelationship**](IaasUcsdInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIaasLicenseInfoAllOf  -LicenseExpirationDate null `
 -LicenseKeysInfo null `
 -LicenseType null `
 -LicenseUtilizationInfo null `
 -Guid null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

