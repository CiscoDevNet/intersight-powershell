# OsCatalogAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | The catalog name. There will be one for system and one for each user account. | [optional] 
**ConfigurationFiles** | [**OsConfigurationFileRelationship[]**](OsConfigurationFileRelationship.md) | An array of relationships to osConfigurationFile resources. | [optional] 
**Distributions** | [**OsDistributionRelationship[]**](OsDistributionRelationship.md) | An array of relationships to osDistribution resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightOsCatalogAllOf  -Name null `
 -ConfigurationFiles null `
 -Distributions null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

