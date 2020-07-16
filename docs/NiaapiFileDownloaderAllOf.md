# NiaapiFileDownloaderAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileName** | **String** | Filename of this Metadata package file, folder will be handled by api. | [optional] 
**PresignedUrl** | **String** | The presigned URL from server to download this file. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNiaapiFileDownloaderAllOf  -FileName null `
 -PresignedUrl null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

