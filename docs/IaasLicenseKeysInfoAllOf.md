# IaasLicenseKeysInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **Int64** | Number of licenses available for the UCSD PID (Product ID). | [optional] [readonly] 
**ExpirationDate** | **String** | Expiration date for the license. | [optional] [readonly] 
**LicenseId** | **String** | UCS Director Unique license ID. | [optional] [readonly] 
**VarPid** | **String** | PID (Product ID) for UCSD License. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIaasLicenseKeysInfoAllOf  -Count null `
 -ExpirationDate null `
 -LicenseId null `
 -VarPid null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

