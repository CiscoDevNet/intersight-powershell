# OsConfigurationFileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "os.ConfigurationFile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "os.ConfigurationFile"]
**Description** | **String** | Description of the OS ConfigurationFile. | [optional] 
**FileContent** | **String** | The content of the entire configuration file is stored as value. The content can either be a static file content or a template content. The template is expected to conform to the golang template syntax. The values from os.Answers properties will be used to populate this template. | [optional] 
**Internal** | **Boolean** | The internal flag is set to true when configuration file is uploaded from OS Install wizard. Internal Configuration files will not be displayed in Answer Management Page. | [optional] [default to $false]
**Name** | **String** | The name of the OS ConfigurationFile that uniquely identifies the configuration file. | [optional] 
**Placeholders** | [**OsPlaceHolder[]**](OsPlaceHolder.md) |  | [optional] 
**Supported** | **Boolean** | An internal property that is used to distinguish between the pre-canned OS configuration file entries and user provided entries. | [optional] [readonly] 
**Catalog** | [**OsCatalogRelationship**](OsCatalogRelationship.md) |  | [optional] 
**Distributions** | [**HclOperatingSystemRelationship[]**](HclOperatingSystemRelationship.md) | An array of relationships to hclOperatingSystem resources. | [optional] 

## Examples

- Prepare the resource
```powershell
$OsConfigurationFileAllOf = Initialize-IntersightOsConfigurationFileAllOf  -ClassId null `
 -ObjectType null `
 -Description null `
 -FileContent null `
 -Internal null `
 -Name null `
 -Placeholders null `
 -Supported null `
 -Catalog null `
 -Distributions null
```

- Convert the resource to JSON
```powershell
$OsConfigurationFileAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

