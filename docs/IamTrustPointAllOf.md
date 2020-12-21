# IamTrustPointAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iam.TrustPoint"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iam.TrustPoint"]
**Certificates** | [**X509Certificate[]**](X509Certificate.md) |  | [optional] 
**Chain** | **String** | The certificate information for this trusted point. The certificate must be in Base64 encoded X.509 (CER) format. | [optional] 
**Account** | [**IamAccountRelationship**](IamAccountRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IamTrustPointAllOf = Initialize-IntersightIamTrustPointAllOf  -ClassId null `
 -ObjectType null `
 -Certificates null `
 -Chain null `
 -Account null
```

- Convert the resource to JSON
```powershell
$IamTrustPointAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

