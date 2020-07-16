# SoftwarerepositoryDownloadSpecAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthToken** | **String** | The OAuth2 token that will be used during image download by the endpoint to authenticate with file server. | [optional] 
**Certificate** | **String** | The certificate of file server that will be used by the endpoint to validate the server before starting the file download. | [optional] 
**Filename** | **String** | The name of the firmware image. | [optional] 
**Md5sum** | **String** | MD5 sum of the firmware image that will be used by the endpoint to validate the integrity of the image, post download. | [optional] 
**Size** | **Int64** | The size (in bytes) of the firmware image. | [optional] 
**Url** | **String** | The URL of this file in file server. The endpoint uses this URL to download the file from the file server. | [optional] 
**File** | [**SoftwarerepositoryFileRelationship**](SoftwarerepositoryFileRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSoftwarerepositoryDownloadSpecAllOf  -AuthToken null `
 -Certificate null `
 -Filename null `
 -Md5sum null `
 -Size null `
 -Url null `
 -File null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

