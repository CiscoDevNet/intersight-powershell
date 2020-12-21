# IamCertificateRequestAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.CertificateRequest"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.CertificateRequest"]
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
$IamCertificateRequestAllOf = Initialize-IntersightIamCertificateRequestAllOf  -ClassId null `
 -ObjectType null `
 -EmailAddress null `
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
$IamCertificateRequestAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

