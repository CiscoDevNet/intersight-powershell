# NiaapiNiaMetadataAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | [**NiaapiDetail[]**](NiaapiDetail.md) |  | [optional] 
**Date** | **System.DateTime** | The date when this package is generated. | [optional] 
**MetadataChksum** | **String** | Chksum used to check the integrity of the Metadata file downloaded. | [optional] 
**MetadataFilename** | **String** | The Filename of this Metadata package. | [optional] 
**Version** | **Int64** | The version number of the Metadata package. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightNiaapiNiaMetadataAllOf  -Content null `
 -Date null `
 -MetadataChksum null `
 -MetadataFilename null `
 -Version null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

