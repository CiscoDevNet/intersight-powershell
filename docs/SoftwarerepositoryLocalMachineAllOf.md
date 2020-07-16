# SoftwarerepositoryLocalMachineAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DownloadUrl** | **String** | When the import action in the file MO is updated with &#39;GeneratePreSignedDownloadUrl&#39;, Intersight returns a pre-signed URL in this property as part of the patch response. The user is expected to subsequently download the file using this URL. | [optional] [readonly] 
**PartSize** | **Int64** | The chunk size (in bytes) for each part of the file to be uploaded. | [optional] 
**UploadId** | **String** | When the import action in file MO is updated with &#39;GeneratePreSignedUploadUrl&#39;, Intersight shall return a upload Id in this property as part of the PATCH response. | [optional] 
**UploadUrl** | **String** | When a file MO is created with &#39;LocalMachine&#39; as the source, Intersight returns a pre-signed URL in this property as part of the POST response. The user is expected to subsequently upload the file content using this URL. Once the upload is completed, the user is expected to patch the Uploader object&#39;s transfer to a success state. | [optional] [readonly] 
**UploadUrls** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSoftwarerepositoryLocalMachineAllOf  -DownloadUrl null `
 -PartSize null `
 -UploadId null `
 -UploadUrl null `
 -UploadUrls null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

