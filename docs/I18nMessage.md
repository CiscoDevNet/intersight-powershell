# I18nMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Message** | **String** | The default (en-US) localized message. Default localized message will be stored and directly retrieved when the user&#39;s locale setting is en-US. | [optional] [readonly] 
**MessageId** | **String** | The unique message identitifer used to lookup text templates in a multi-language message catalog. | [optional] [readonly] 
**MessageParams** | [**I18nMessageParam[]**](I18nMessageParam.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightI18nMessage  -ClassId null `
 -ObjectType null `
 -Message null `
 -MessageId null `
 -MessageParams null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

