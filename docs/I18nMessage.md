# I18nMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "i18n.Message"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "i18n.Message"]
**Message** | **String** | The default (en-US) localized message. Default localized message will be stored and directly retrieved when the user&#39;s locale setting is en-US. | [optional] [readonly] 
**MessageId** | **String** | The unique message identitifer used to lookup text templates in a multi-language message catalog. | [optional] [readonly] 
**MessageParams** | [**I18nMessageParam[]**](I18nMessageParam.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$I18nMessage = Initialize-IntersightI18nMessage  -ClassId null `
 -ObjectType null `
 -Message null `
 -MessageId null `
 -MessageParams null
```

- Convert the resource to JSON
```powershell
$I18nMessage | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

