# SoftwareHyperflexBundleDistributableAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Catalog** | [**SoftwarerepositoryCatalogRelationship**](SoftwarerepositoryCatalogRelationship.md) |  | [optional] 
**Images** | [**SoftwareHyperflexDistributableRelationship[]**](SoftwareHyperflexDistributableRelationship.md) | An array of relationships to softwareHyperflexDistributable resources. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSoftwareHyperflexBundleDistributableAllOf  -Catalog null `
 -Images null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

