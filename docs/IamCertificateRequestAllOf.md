# IamCertificateRequestAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmailAddress** | **String** | User input email address, an optional part of the subject of the certificate request. | [optional] 
**Name** | **String** | Name of the certificate request. | [optional] 
**Request** | **String** | Generated certificate signing request (CSR) in PEM format. | [optional] [readonly] 
**SelfSigned** | **Boolean** | Whether the user wants the generated CSR to be self-signed by the appliance. | [optional] 
**Subject** | [**PkixDistinguishedName**](PkixDistinguishedName.md) |  | [optional] 
**SubjectAlternateName** | [**PkixSubjectAlternateName**](PkixSubjectAlternateName.md) |  | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 
**Certificate** | [**IamCertificateRelationship**](IamCertificateRelationship.md) |  | [optional] 
**PrivateKeySpec** | [**IamPrivateKeySpecRelationship**](IamPrivateKeySpecRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamCertificateRequestAllOf  -EmailAddress null `
 -Name null `
 -Request null `
 -SelfSigned null `
 -Subject null `
 -SubjectAlternateName null `
 -Account null `
 -Certificate null `
 -PrivateKeySpec null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

