# ConnectorExpectPrompt
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Expect** | **String** | The regex of the expect prompt of the interactive command. | [optional] 
**ExpectTimeout** | **Int64** | The timeout for the expect prompt while executing interactive command. If timeout is not set a default of 60 seconds will be used. | [optional] 
**Send** | **String** | The answer string to the expect prompt. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConnectorExpectPrompt  -ClassId null `
 -ObjectType null `
 -Expect null `
 -ExpectTimeout null `
 -Send null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

