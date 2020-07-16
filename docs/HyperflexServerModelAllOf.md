# HyperflexServerModelAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServerModelEntries** | [**HyperflexServerModelEntry[]**](HyperflexServerModelEntry.md) |  | [optional] 
**AppCatalog** | [**HyperflexAppCatalogRelationship**](HyperflexAppCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHyperflexServerModelAllOf  -ServerModelEntries null `
 -AppCatalog null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

