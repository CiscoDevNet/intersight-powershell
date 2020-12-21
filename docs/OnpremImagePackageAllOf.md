# OnpremImagePackageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "onprem.ImagePackage"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "onprem.ImagePackage"]
**FilePath** | **String** | Optional file path of the image package. | [optional] [readonly] 
**FileSha** | **String** | Image file&#39;s fingerprint. Fingerprint is calculated using SHA256 algorithm. | [optional] [readonly] 
**FileSize** | **Int64** | Image file size in bytes. | [optional] [readonly] 
**FileTime** | **System.DateTime** | Image file&#39;s last modified date and time. | [optional] [readonly] 
**Filename** | **String** | Filename of the image package. | [optional] [readonly] 
**Name** | **String** | Name of the software image package. | [optional] [readonly] 
**PackageType** | **String** | Image package type (e.g. service, system etc.). | [optional] [readonly] 
**Version** | **String** | Image package version string. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$OnpremImagePackageAllOf = Initialize-IntersightOnpremImagePackageAllOf  -ClassId null `
 -ObjectType null `
 -FilePath null `
 -FileSha null `
 -FileSize null `
 -FileTime null `
 -Filename null `
 -Name null `
 -PackageType null `
 -Version null
```

- Convert the resource to JSON
```powershell
$OnpremImagePackageAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

