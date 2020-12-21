# ForecastModelAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "forecast.Model"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "forecast.Model"]
**Accuracy** | **Double** | The standard error of the estimate is a measure of the accuracy of predictions from predective modeling. | [optional] 
**ModelData** | **Decimal[]** |  | [optional] 
**ModelType** | **String** | Model type indicating type of predictive model used for computing forecast. * &#x60;Linear&#x60; - The Enum value Linear represents that the predictive model type used for forecast computation is linear regression. | [optional] [default to "Linear"]

## Examples

- Prepare the resource
```powershell
$ForecastModelAllOf = Initialize-IntersightForecastModelAllOf  -ClassId null `
 -ObjectType null `
 -Accuracy null `
 -ModelData null `
 -ModelType null
```

- Convert the resource to JSON
```powershell
$ForecastModelAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

