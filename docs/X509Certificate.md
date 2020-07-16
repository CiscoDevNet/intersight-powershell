# X509Certificate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Issuer** | [**PkixDistinguishedName**](PkixDistinguishedName.md) |  | [optional] 
**NotAfter** | **System.DateTime** | The date on which the certificate&#39;s validity period ends. | [optional] [readonly] 
**NotBefore** | **System.DateTime** | The date on which the certificate&#39;s validity period begins. | [optional] [readonly] 
**PemCertificate** | **String** | The base64 encoded certificate in PEM format. | [optional] 
**Sha256Fingerprint** | **String** | The computed SHA-256 fingerprint of the certificate. Equivalent to &#39;openssl x509 -fingerprint -sha256&#39;. | [optional] [readonly] 
**SignatureAlgorithm** | **String** | Signature algorithm, as specified in [RFC 5280](https://tools.ietf.org/html/rfc5280). | [optional] [readonly] 
**Subject** | [**PkixDistinguishedName**](PkixDistinguishedName.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightX509Certificate  -ClassId null `
 -ObjectType null `
 -Issuer null `
 -NotAfter null `
 -NotBefore null `
 -PemCertificate null `
 -Sha256Fingerprint null `
 -SignatureAlgorithm null `
 -Subject null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

