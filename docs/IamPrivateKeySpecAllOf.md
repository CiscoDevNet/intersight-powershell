# IamPrivateKeySpecAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Algorithm** | [**PkixKeyGenerationSpec**](PkixKeyGenerationSpec.md) |  | [optional] 
**CertificateRequest** | [**IamCertificateRequestRelationship**](IamCertificateRequestRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamPrivateKeySpecAllOf  -Algorithm null `
 -CertificateRequest null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

