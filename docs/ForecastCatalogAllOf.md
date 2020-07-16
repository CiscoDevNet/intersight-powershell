# ForecastCatalogAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SchedTime** | **String** | The time at which the regression model needs to run for all the metrics specified in catalog. | [optional] [readonly] 
**Version** | **String** | The catalog version used in forecast configuration service. | [optional] [readonly] 
**Definition** | [**ForecastDefinitionRelationship[]**](ForecastDefinitionRelationship.md) | An array of relationships to forecastDefinition resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightForecastCatalogAllOf  -SchedTime null `
 -Version null `
 -Definition null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

