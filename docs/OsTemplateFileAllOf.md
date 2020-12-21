# OsTemplateFileAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "os.TemplateFile"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "os.TemplateFile"]
**Name** | **String** | The name of the OS Template File that user uploads for unattended installation. | [optional] 
**Placeholders** | **String[]** |  | [optional] 
**TemplateContent** | **String** | The content of the entire template file is stored as value. The content can either be a static file content or a template content. The template is expected to conform to the golang template syntax.  The placeholders, if any, would be populated and the values provided would be  used to populate this template. | [optional] 

## Examples

- Prepare the resource
```powershell
$OsTemplateFileAllOf = Initialize-IntersightOsTemplateFileAllOf  -ClassId null `
 -ObjectType null `
 -Name null `
 -Placeholders null `
 -TemplateContent null
```

- Convert the resource to JSON
```powershell
$OsTemplateFileAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

