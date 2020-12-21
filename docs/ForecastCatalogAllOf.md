# ForecastCatalogAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "forecast.Catalog"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "forecast.Catalog"]
**SchedTime** | **String** | The time at which the regression model needs to run for all the metrics specified in catalog. | [optional] [readonly] 
**Version** | **String** | The catalog version used in forecast configuration service. | [optional] [readonly] 
**Definition** | [**ForecastDefinitionRelationship[]**](ForecastDefinitionRelationship.md) | An array of relationships to forecastDefinition resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$ForecastCatalogAllOf = Initialize-IntersightForecastCatalogAllOf  -ClassId null `
 -ObjectType null `
 -SchedTime null `
 -Version null `
 -Definition null
```

- Convert the resource to JSON
```powershell
$ForecastCatalogAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

