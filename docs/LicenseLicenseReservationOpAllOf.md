# LicenseLicenseReservationOpAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthCode** | **String** | Revervation code used to install the license. | [optional] 
**AuthCodeInstalled** | **Boolean** | Flag to indicate whether authorization code is installed. | [optional] [readonly] 
**ConfirmCode** | **String** | Confirm code used to complete the license update on smart license account. | [optional] [readonly] 
**GenerateRequestCode** | **Boolean** | Trigger the generation of request code for specific license reservation. | [optional] 
**GenerateReturnCode** | **Boolean** | Trigger the generation of return code for specific license reservation. | [optional] 
**RequestCode** | **String** | Revervation code used to generate authorization code from CSSM. | [optional] [readonly] 
**ReturnCode** | **String** | Return code used to return the reserved license to smart license account. | [optional] [readonly] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightLicenseLicenseReservationOpAllOf  -AuthCode null `
 -AuthCodeInstalled null `
 -ConfirmCode null `
 -GenerateRequestCode null `
 -GenerateReturnCode null `
 -RequestCode null `
 -ReturnCode null `
 -Account null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

