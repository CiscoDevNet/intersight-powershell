# ForecastDefinitionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AlertThresholdInPercentage** | **Int64** | Threshold above which user needs to be indicated through alarm/alert. | [optional] [readonly] 
**DataSource** | **String** | Data source from where we get the data for the metrics to compute regression model. For example Druid. | [optional] [readonly] 
**MetricName** | **String** | Metric for which forecast prediction is done. Metrics are defined in the catalog file. Currently its only HyperFlex cluster storage capacity usage. | [optional] [readonly] 
**MinNumOfDaysOfData** | **Int64** | Minimum number of days of data required for computing forecast model. | [optional] [readonly] 
**NumOfDaysOfHistoricalData** | **Int64** | Number of days of data queried from the data source (example Druid ) which is used as input data for computing forecast model. | [optional] [readonly] 
**PlatformType** | **String** | The platform type for which we want to compute forecast. For example HyperFlex, NetworkElement. | [optional] [readonly] 
**Catalog** | [**ForecastCatalogRelationship**](ForecastCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightForecastDefinitionAllOf  -AlertThresholdInPercentage null `
 -DataSource null `
 -MetricName null `
 -MinNumOfDaysOfData null `
 -NumOfDaysOfHistoricalData null `
 -PlatformType null `
 -Catalog null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

