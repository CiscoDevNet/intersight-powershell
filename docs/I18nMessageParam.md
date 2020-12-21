# I18nMessageParam
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "i18n.MessageParam"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "i18n.MessageParam"]
**Name** | **String** | The name of a variable which is referenced in a i18n text template. | [optional] [readonly] 
**Value** | **String** | The value of a variable which is substituted in a i18n text template. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$I18nMessageParam = Initialize-IntersightI18nMessageParam  -ClassId null `
 -ObjectType null `
 -Name null `
 -Value null
```

- Convert the resource to JSON
```powershell
$I18nMessageParam | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

