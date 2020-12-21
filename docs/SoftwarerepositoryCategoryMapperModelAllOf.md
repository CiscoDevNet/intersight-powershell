# SoftwarerepositoryCategoryMapperModelAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "softwarerepository.CategoryMapperModel"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "softwarerepository.CategoryMapperModel"]
**Category** | **String** | The category of the model series. | [optional] 
**DistTag** | **String** | The distributable tag value of the model series. | [optional] 
**RegexPattern** | **String** | The regex that all images of this model follow. | [optional] 
**SeriesId** | **String** | Cisco hardware model series. | [optional] 
**SupportedModels** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SoftwarerepositoryCategoryMapperModelAllOf = Initialize-IntersightSoftwarerepositoryCategoryMapperModelAllOf  -ClassId null `
 -ObjectType null `
 -Category null `
 -DistTag null `
 -RegexPattern null `
 -SeriesId null `
 -SupportedModels null
```

- Convert the resource to JSON
```powershell
$SoftwarerepositoryCategoryMapperModelAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

