# OnpremImagePackage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
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
Initialize-IntersightOnpremImagePackage  -ClassId null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

