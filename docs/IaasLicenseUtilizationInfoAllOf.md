# IaasLicenseUtilizationInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActualUsed** | **Int64** | Number of licenses actually used for this feature. | [optional] [readonly] 
**Label** | **String** | License label of UCSD license. | [optional] [readonly] 
**LicensedLimit** | **String** | License limit for this license feature. | [optional] [readonly] 
**Sku** | **String** | SKU for the UCSD license. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIaasLicenseUtilizationInfoAllOf  -ActualUsed null `
 -Label null `
 -LicensedLimit null `
 -Sku null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

