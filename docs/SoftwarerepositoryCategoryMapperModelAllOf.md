# SoftwarerepositoryCategoryMapperModelAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Category** | **String** | The category of the model series. | [optional] 
**DistTag** | **String** | The distributable tag value of the model series. | [optional] 
**RegexPattern** | **String** | The regex that all images of this model follow. | [optional] 
**SeriesId** | **String** | Cisco hardware model series. | [optional] 
**SupportedModels** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSoftwarerepositoryCategoryMapperModelAllOf  -Category null `
 -DistTag null `
 -RegexPattern null `
 -SeriesId null `
 -SupportedModels null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

