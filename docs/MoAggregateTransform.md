# MoAggregateTransform
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectType** | **String** | A discriminator value to disambiguate the schema of a HTTP GET response body. | 
**Results** | [**SystemCollectionsHashtable[]**](SystemCollectionsHashtable.md) | The results of the aggregation query. | [optional] 

## Examples

- Prepare the resource
```powershell
$MoAggregateTransform = Initialize-IntersightMoAggregateTransform  -ObjectType null `
 -Results null
```

- Convert the resource to JSON
```powershell
$MoAggregateTransform | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

