# IamTrustPointAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Certificates** | [**X509Certificate[]**](X509Certificate.md) |  | [optional] 
**Chain** | **String** | The certificate information for this trusted point. The certificate must be in Base64 encoded X.509 (CER) format. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIamTrustPointAllOf  -Certificates null `
 -Chain null `
 -Account null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

