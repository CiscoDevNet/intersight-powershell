# LicenseIwoLicenseCountAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "license.IwoLicenseCount"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "license.IwoLicenseCount"]
**VmLicenseCount** | **Int64** | The total number of devices claimed in the Intersight account. | [optional] [readonly] 
**AccountLicenseData** | [**LicenseAccountLicenseDataRelationship**](LicenseAccountLicenseDataRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$LicenseIwoLicenseCountAllOf = Initialize-IntersightLicenseIwoLicenseCountAllOf  -ClassId null `
 -ObjectType null `
 -VmLicenseCount null `
 -AccountLicenseData null
```

- Convert the resource to JSON
```powershell
$LicenseIwoLicenseCountAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

