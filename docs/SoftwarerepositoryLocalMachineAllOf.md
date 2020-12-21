# SoftwarerepositoryLocalMachineAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "softwarerepository.LocalMachine"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "softwarerepository.LocalMachine"]
**DownloadUrl** | **String** | When the import action in the file MO is updated with &#39;GeneratePreSignedDownloadUrl&#39;, Intersight returns a pre-signed URL in this property as part of the patch response. The user is expected to subsequently download the file using this URL. | [optional] [readonly] 
**PartSize** | **Int64** | The chunk size (in bytes) for each part of the file to be uploaded. | [optional] 
**UploadId** | **String** | When the import action in file MO is updated with &#39;GeneratePreSignedUploadUrl&#39;, Intersight shall return a upload Id in this property as part of the PATCH response. | [optional] 
**UploadUrl** | **String** | When a file MO is created with &#39;LocalMachine&#39; as the source, Intersight returns a pre-signed URL in this property as part of the POST response. The user is expected to subsequently upload the file content using this URL. Once the upload is completed, the user is expected to patch the uploader object&#39;s transfer state to success. | [optional] [readonly] 
**UploadUrls** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SoftwarerepositoryLocalMachineAllOf = Initialize-IntersightSoftwarerepositoryLocalMachineAllOf  -ClassId null `
 -ObjectType null `
 -DownloadUrl null `
 -PartSize null `
 -UploadId null `
 -UploadUrl null `
 -UploadUrls null
```

- Convert the resource to JSON
```powershell
$SoftwarerepositoryLocalMachineAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

