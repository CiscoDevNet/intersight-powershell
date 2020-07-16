# OsTemplateFileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | The name of the OS Template File that user uploads for unattended installation. | [optional] 
**Placeholders** | **String[]** |  | [optional] 
**TemplateContent** | **String** | The content of the entire template file is stored as value. The content can either be a static file content or a template content. The template is expected to conform to the golang template syntax.  The placeholders, if any, would be populated and the values provided would be  used to populate this template. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightOsTemplateFileAllOf  -Name null `
 -Placeholders null `
 -TemplateContent null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

