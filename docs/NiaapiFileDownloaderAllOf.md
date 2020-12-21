# NiaapiFileDownloaderAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "niaapi.FileDownloader"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "niaapi.FileDownloader"]
**FileName** | **String** | Filename of this Metadata package file, folder will be handled by api. | [optional] 
**PresignedUrl** | **String** | The presigned URL from server to download this file. | [optional] 

## Examples

- Prepare the resource
```powershell
$NiaapiFileDownloaderAllOf = Initialize-IntersightNiaapiFileDownloaderAllOf  -ClassId null `
 -ObjectType null `
 -FileName null `
 -PresignedUrl null
```

- Convert the resource to JSON
```powershell
$NiaapiFileDownloaderAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

