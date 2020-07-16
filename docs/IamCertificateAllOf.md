# IamCertificateAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Certificate** | [**X509Certificate**](X509Certificate.md) |  | [optional] 
**Status** | **String** | Status of the certificate. | [optional] [readonly] [default to "PendingValidation"]
**CertificateRequest** | [**IamCertificateRequestRelationship**](IamCertificateRequestRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamCertificateAllOf  -Certificate null `
 -Status null `
 -CertificateRequest null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

