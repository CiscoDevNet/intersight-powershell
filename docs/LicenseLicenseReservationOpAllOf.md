# LicenseLicenseReservationOpAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "license.LicenseReservationOp"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "license.LicenseReservationOp"]
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
$LicenseLicenseReservationOpAllOf = Initialize-IntersightLicenseLicenseReservationOpAllOf  -ClassId null `
 -ObjectType null `
 -AuthCode null `
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
$LicenseLicenseReservationOpAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

