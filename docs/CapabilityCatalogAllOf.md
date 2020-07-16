# CapabilityCatalogAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | A unique name for the catalog. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**Sections** | [**CapabilitySectionRelationship[]**](CapabilitySectionRelationship.md) | An array of relationships to capabilitySection resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightCapabilityCatalogAllOf  -Name null `
 -Organization null `
 -Sections null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

