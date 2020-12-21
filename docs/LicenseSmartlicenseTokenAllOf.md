# LicenseSmartlicenseTokenAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "license.SmartlicenseToken"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "license.SmartlicenseToken"]
**Token** | **String** | Smart license registration token. | [optional] 
**AccountLicenseData** | [**LicenseAccountLicenseDataRelationship**](LicenseAccountLicenseDataRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$LicenseSmartlicenseTokenAllOf = Initialize-IntersightLicenseSmartlicenseTokenAllOf  -ClassId null `
 -ObjectType null `
 -Token null `
 -AccountLicenseData null
```

- Convert the resource to JSON
```powershell
$LicenseSmartlicenseTokenAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

