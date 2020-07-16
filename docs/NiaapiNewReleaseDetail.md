# NiaapiNewReleaseDetail
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Description** | **String** | Description of this new verison release post. | [optional] 
**Link** | **String** | Link of downloading the release file. | [optional] 
**ReleaseNoteLink** | **String** | The link used to provide a gateway for customer to review the release note. | [optional] 
**ReleaseNoteLinkTitle** | **String** | The link title used to provide a gateway for customer to review the release note. | [optional] 
**SoftwareDownloadLink** | **String** | The link used to provide a gateway for customer to download the release. | [optional] 
**SoftwareDownloadLinkTitle** | **String** | The link title used to provide a gateway for customer to download the release. | [optional] 
**Title** | **String** | Title of the new verison release post. | [optional] 
**Version** | **String** | Version number Associate with this Post. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNiaapiNewReleaseDetail  -ClassId null `
 -ObjectType null `
 -Description null `
 -Link null `
 -ReleaseNoteLink null `
 -ReleaseNoteLinkTitle null `
 -SoftwareDownloadLink null `
 -SoftwareDownloadLinkTitle null `
 -Title null `
 -Version null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

