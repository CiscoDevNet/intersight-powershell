# NiaapiNewReleasePostAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PostDate** | **System.DateTime** | The date when this new release notice is posted. | [optional] 
**PostDetail** | [**NiaapiNewReleaseDetail**](NiaapiNewReleaseDetail.md) |  | [optional] 
**PostType** | **String** | The document type of this post. | [optional] 
**Postid** | **String** | Identificator of this inbox post. | [optional] 
**Revision** | **String** | Revision number of this notice. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNiaapiNewReleasePostAllOf  -PostDate null `
 -PostDetail null `
 -PostType null `
 -Postid null `
 -Revision null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

