# IamCertificateAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.Certificate"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.Certificate"]
**Certificate** | [**X509Certificate**](X509Certificate.md) |  | [optional] 
**Status** | **String** | Status of the certificate. * &#x60;PendingValidation&#x60; - The certificate has not been validated. * &#x60;Valid&#x60; - The certificate is valid. * &#x60;Invalid&#x60; - Ther certificate is invalid. | [optional] [readonly] [default to "PendingValidation"]
**CertificateRequest** | [**IamCertificateRequestRelationship**](IamCertificateRequestRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamCertificateAllOf = Initialize-IntersightIamCertificateAllOf  -ClassId null `
 -ObjectType null `
 -Certificate null `
 -Status null `
 -CertificateRequest null
```

- Convert the resource to JSON
```powershell
$IamCertificateAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

