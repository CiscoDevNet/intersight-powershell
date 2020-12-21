# ForecastInstanceAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "forecast.Instance"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "forecast.Instance"]
**AltModel** | **Decimal[]** |  | [optional] 
**DeviceId** | **String** | The Moid of the Intersight managed device instance for which regression model is derived. | [optional] [readonly] 
**FullCapDays** | **Int64** | The number of days remaining before the device reaches its full functional capacity. | [optional] [readonly] 
**MetricName** | **String** | The name of the metric for which regression model is generated. | [optional] [readonly] 
**MinDaysForForecast** | **Int64** | The minimum number of days the HyperFlex cluster should be up for computing forecast. | [optional] [readonly] 
**Model** | [**ForecastModel**](ForecastModel.md) |  | [optional] 
**ThresholdDays** | **Int64** | The number of days remaining before the device reaches the specified threshold for the metric as defined in definition. | [optional] [readonly] [default to 2147483647]
**ForecastDef** | [**ForecastDefinitionRelationship**](ForecastDefinitionRelationship.md) |  | [optional] 
**RegisteredDevice** | [**AssetDeviceRegistrationRelationship**](AssetDeviceRegistrationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ForecastInstanceAllOf = Initialize-IntersightForecastInstanceAllOf  -ClassId null `
 -ObjectType null `
 -AltModel null `
 -DeviceId null `
 -FullCapDays null `
 -MetricName null `
 -MinDaysForForecast null `
 -Model null `
 -ThresholdDays null `
 -ForecastDef null `
 -RegisteredDevice null
```

- Convert the resource to JSON
```powershell
$ForecastInstanceAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

