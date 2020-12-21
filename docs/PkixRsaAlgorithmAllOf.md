# PkixRsaAlgorithmAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "pkix.RsaAlgorithm"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "pkix.RsaAlgorithm"]
**Modulus** | **Int32** | The length of the RSA key, expressed in bits, for both public and private keys. * &#x60;2048&#x60; - A key length of 2048 bits. * &#x60;2560&#x60; - A key length of 2560 bits. * &#x60;3072&#x60; - A key length of 3072 bits. * &#x60;3584&#x60; - A key length of 3584 bits. * &#x60;4096&#x60; - A key length of 4096 bits. | [optional] [default to 2048]

## Examples

- Prepare the resource
```powershell
$PkixRsaAlgorithmAllOf = Initialize-IntersightPkixRsaAlgorithmAllOf  -ClassId null `
 -ObjectType null `
 -Modulus null
```

- Convert the resource to JSON
```powershell
$PkixRsaAlgorithmAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

