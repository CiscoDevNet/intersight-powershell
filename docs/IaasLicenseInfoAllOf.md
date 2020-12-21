# IaasLicenseInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iaas.LicenseInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iaas.LicenseInfo"]
**LicenseExpirationDate** | **String** | UCS Director license expiration date. | [optional] [readonly] 
**LicenseKeysInfo** | [**IaasLicenseKeysInfo[]**](IaasLicenseKeysInfo.md) |  | [optional] 
**LicenseType** | **String** | License type of UCSD whether it is EVAL/Permanent/Subscription.. | [optional] [readonly] 
**LicenseUtilizationInfo** | [**IaasLicenseUtilizationInfo[]**](IaasLicenseUtilizationInfo.md) |  | [optional] 
**Guid** | [**IaasUcsdInfoRelationship**](IaasUcsdInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IaasLicenseInfoAllOf = Initialize-IntersightIaasLicenseInfoAllOf  -ClassId null `
 -ObjectType null `
 -LicenseExpirationDate null `
 -LicenseKeysInfo null `
 -LicenseType null `
 -LicenseUtilizationInfo null `
 -Guid null
```

- Convert the resource to JSON
```powershell
$IaasLicenseInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

