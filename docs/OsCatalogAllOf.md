# OsCatalogAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "os.Catalog"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "os.Catalog"]
**Name** | **String** | The catalog name. There will be one for system and one for each user account. | [optional] 
**ConfigurationFiles** | [**OsConfigurationFileRelationship[]**](OsConfigurationFileRelationship.md) | An array of relationships to osConfigurationFile resources. | [optional] 
**Distributions** | [**OsDistributionRelationship[]**](OsDistributionRelationship.md) | An array of relationships to osDistribution resources. | [optional] 
**Organization** | [**OrganizationOrganizationRelationship**](OrganizationOrganizationRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$OsCatalogAllOf = Initialize-IntersightOsCatalogAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -ConfigurationFiles null `
 -Distributions null `
 -Organization null
```

- Convert the resource to JSON
```powershell
$OsCatalogAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

