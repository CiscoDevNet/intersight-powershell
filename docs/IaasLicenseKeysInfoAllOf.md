# IaasLicenseKeysInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iaas.LicenseKeysInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iaas.LicenseKeysInfo"]
**Count** | **Int64** | Number of licenses available for the UCSD PID (Product ID). | [optional] [readonly] 
**ExpirationDate** | **String** | Expiration date for the license. | [optional] [readonly] 
**LicenseId** | **String** | UCS Director Unique license ID. | [optional] [readonly] 
**VarPid** | **String** | PID (Product ID) for UCSD License. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$IaasLicenseKeysInfoAllOf = Initialize-IntersightIaasLicenseKeysInfoAllOf  -ClassId null `
 -ObjectType null `
 -Count null `
 -ExpirationDate null `
 -LicenseId null `
 -VarPid null
```

- Convert the resource to JSON
```powershell
$IaasLicenseKeysInfoAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

