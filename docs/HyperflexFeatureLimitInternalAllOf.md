# HyperflexFeatureLimitInternalAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FeatureLimitEntries** | [**HyperflexFeatureLimitEntry[]**](HyperflexFeatureLimitEntry.md) |  | [optional] 
**AppCatalog** | [**HyperflexAppCatalogRelationship**](HyperflexAppCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexFeatureLimitInternalAllOf  -FeatureLimitEntries null `
 -AppCatalog null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

