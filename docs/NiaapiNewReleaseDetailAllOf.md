# NiaapiNewReleaseDetailAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niaapi.NewReleaseDetail"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niaapi.NewReleaseDetail"]
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
$NiaapiNewReleaseDetailAllOf = Initialize-IntersightNiaapiNewReleaseDetailAllOf  -ClassId null `
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
$NiaapiNewReleaseDetailAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

