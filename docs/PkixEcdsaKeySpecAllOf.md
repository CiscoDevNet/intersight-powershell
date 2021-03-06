# PkixEcdsaKeySpecAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "pkix.EcdsaKeySpec"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "pkix.EcdsaKeySpec"]
**Curve** | **String** | A specific set of Elliptic Curve parameters, as recommended by NIST in FIPS 186-4. * &#x60;P256&#x60; - P256 returns a Curve which implements P-256, as defined in FIPS 186-4, section D.2.3. * &#x60;P224&#x60; - P224 returns a Curve which implements P-224, as defined in FIPS 186-4, section D.2.2. * &#x60;P384&#x60; - P384 returns a Curve which implements P-384, as defined in FIPS 186-4, section D.2.4. * &#x60;P521&#x60; - P521 returns a Curve which implements P-521, as defined in FIPS 186-4, section D.2.5. | [optional] [default to "P256"]

## Examples

- Prepare the resource
```powershell
$PkixEcdsaKeySpecAllOf = Initialize-IntersightPkixEcdsaKeySpecAllOf  -ClassId null `
 -ObjectType null `
 -Curve null
```

- Convert the resource to JSON
```powershell
$PkixEcdsaKeySpecAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

