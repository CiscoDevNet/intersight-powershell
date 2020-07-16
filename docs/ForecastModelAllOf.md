# ForecastModelAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accuracy** | **Double** | The standard error of the estimate is a measure of the accuracy of predictions from predective modeling. | [optional] 
**ModelData** | **Decimal[]** |  | [optional] 
**ModelType** | **String** | Model type indicating type of predictive model used for computing forecast. | [optional] [default to "Linear"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightForecastModelAllOf  -Accuracy null `
 -ModelData null `
 -ModelType null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

