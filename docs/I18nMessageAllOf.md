# I18nMessageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Message** | **String** | The default (en-US) localized message. Default localized message will be stored and directly retrieved when the user&#39;s locale setting is en-US. | [optional] [readonly] 
**MessageId** | **String** | The unique message identitifer used to lookup text templates in a multi-language message catalog. | [optional] [readonly] 
**MessageParams** | [**I18nMessageParam[]**](I18nMessageParam.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightI18nMessageAllOf  -Message null `
 -MessageId null `
 -MessageParams null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

