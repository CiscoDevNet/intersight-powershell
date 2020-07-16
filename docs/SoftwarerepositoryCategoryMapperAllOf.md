# SoftwarerepositoryCategoryMapperAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Category** | **String** | The category of the model series. | [optional] 
**FileType** | **String** | The type of distributable image, example huu, scu, driver, os. | [optional] [default to "Distributable"]
**MdfId** | **String** | Cisco software repository image category identifier. | [optional] 
**RegexPattern** | **String** | The regex that all images of this category follow. | [optional] 
**Source** | **String** | The image can be downloaded from cisco.com or external cloud store. | [optional] [default to "Cisco"]
**SupportedModels** | **String[]** |  | [optional] 
**SwId** | **String** | The software type id provided by cisco.com. | [optional] 
**TagTypes** | **String[]** |  | [optional] 
**Version** | **String** | The version from which user can download images from amazon store, if source is external cloud store. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSoftwarerepositoryCategoryMapperAllOf  -Category null `
 -FileType null `
 -MdfId null `
 -RegexPattern null `
 -Source null `
 -SupportedModels null `
 -SwId null `
 -TagTypes null `
 -Version null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

