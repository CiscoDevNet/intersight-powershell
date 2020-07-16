# FirmwareDistributableMetaAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BucketName** | **String** | The S3 bucket name where the images are present, if source is external cloud store. | [optional] 
**FileType** | **String** | The type of distributable image, example huu, scu, driver, os. | [optional] [default to "Distributable"]
**FromVersion** | **String** | The version from which user can download images from amazon store, if source is external cloud store. | [optional] 
**Mdfid** | **String** | The mdfid of the image provided by cisco.com. | [optional] 
**SoftwareTypeId** | **String** | The software type id provided by cisco.com. | [optional] 
**Source** | **String** | The image can be downloaded from cisco.com or external cloud store. | [optional] [default to "Cisco"]
**SupportedModels** | **String[]** |  | [optional] 
**ToVersion** | **String** | The version till which user can download images from amazon store, if source is external cloud store. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightFirmwareDistributableMetaAllOf  -BucketName null `
 -FileType null `
 -FromVersion null `
 -Mdfid null `
 -SoftwareTypeId null `
 -Source null `
 -SupportedModels null `
 -ToVersion null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

