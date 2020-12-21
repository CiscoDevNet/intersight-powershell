# PkixEddsaKeySpecAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "pkix.EddsaKeySpec"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "pkix.EddsaKeySpec"]
**Algorithm** | **String** | The EdDSA algorithm, as defined in RFC 8032. * &#x60;Ed25519&#x60; - The edwards25519 curve, as defined in RFC 8032 section 5.1. * &#x60;Ed25519ph&#x60; - The edwards25519 curve for the PureEdDSA variant. * &#x60;Ed25519ctx&#x60; - The edwards25519 curve for the HashEdDSA variant. | [optional] [default to "Ed25519"]

## Examples

- Prepare the resource
```powershell
$PkixEddsaKeySpecAllOf = Initialize-IntersightPkixEddsaKeySpecAllOf  -ClassId null `
 -ObjectType null `
 -Algorithm null
```

- Convert the resource to JSON
```powershell
$PkixEddsaKeySpecAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

