# IaasLicenseUtilizationInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iaas.LicenseUtilizationInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iaas.LicenseUtilizationInfo"]
**ActualUsed** | **Int64** | Number of licenses actually used for this feature. | [optional] [readonly] 
**Label** | **String** | License label of UCSD license. | [optional] [readonly] 
**LicensedLimit** | **String** | License limit for this license feature. | [optional] [readonly] 
**Sku** | **String** | SKU for the UCSD license. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$IaasLicenseUtilizationInfoAllOf = Initialize-IntersightIaasLicenseUtilizationInfoAllOf  -ClassId null `
 -ObjectType null `
 -ActualUsed null `
 -Label null `
 -LicensedLimit null `
 -Sku null
```

- Convert the resource to JSON
```powershell
$IaasLicenseUtilizationInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

