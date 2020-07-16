# SoftwarerepositoryCatalogAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | The name of the catalog. The names are populated and predefined during MO creation. | [optional] [readonly] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 
**System** | [**IamSystemRelationship**](IamSystemRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSoftwarerepositoryCatalogAllOf  -Name null `
 -Organization null `
 -System null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

