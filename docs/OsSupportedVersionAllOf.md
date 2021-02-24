# OsSupportedVersionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "os.SupportedVersion"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "os.SupportedVersion"]
**VersionName** | **String** | The OsInstall Supported Operating System Version Name. | [optional] [readonly] 
**Vendor** | [**HclOperatingSystemVendorRelationship**](HclOperatingSystemVendorRelationship.md) |  | [optional] 
**Version** | [**HclOperatingSystemRelationship**](HclOperatingSystemRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$OsSupportedVersionAllOf = Initialize-IntersightOsSupportedVersionAllOf  -ClassId null `
 -ObjectType null `
 -VersionName null `
 -Vendor null `
 -Version null
```

- Convert the resource to JSON
```powershell
$OsSupportedVersionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

