# OsConfigurationFileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileContent** | **String** | The content of the entire configuration file is stored as value. The content can either be a static file content or a template content. The template is expected to conform to the golang template syntax. The values from os.Answers properties will be used to populate this template. | [optional] 
**Name** | **String** | The name of the OS ConfigurationFile that uniquely identifies the configuration file. | [optional] 
**Placeholders** | [**OsPlaceHolder[]**](OsPlaceHolder.md) |  | [optional] 
**Supported** | **Boolean** | An internal property that is used to distinguish between the pre-canned OS configuration file entries and user provided entries. | [optional] [readonly] 
**Catalog** | [**OsCatalogRelationship**](OsCatalogRelationship.md) |  | [optional] 
**Distributions** | [**HclOperatingSystemRelationship[]**](HclOperatingSystemRelationship.md) | An array of relationships to hclOperatingSystem resources. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightOsConfigurationFileAllOf  -FileContent null `
 -Name null `
 -Placeholders null `
 -Supported null `
 -Catalog null `
 -Distributions null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

