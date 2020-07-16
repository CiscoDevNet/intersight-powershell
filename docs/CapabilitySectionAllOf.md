# CapabilitySectionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **String** | Administrative action to initialize/load the catalog section from a particular source. | [optional] [readonly] [default to "None"]
**CatalogName** | **String** | The catalog name reference. | [optional] 
**Name** | **String** | A unique name for the section inside a catalog. | [optional] 
**Source** | **String** | The configured source for this section of the catalog. | [optional] [readonly] [default to "Local"]
**Version** | **String** | Version of the section inside a catalog. | [optional] 
**Catalog** | [**CapabilityCatalogRelationship**](CapabilityCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCapabilitySectionAllOf  -Action null `
 -CatalogName null `
 -Name null `
 -Source null `
 -Version null `
 -Catalog null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

