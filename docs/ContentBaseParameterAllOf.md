# ContentBaseParameterAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcceptSingleValue** | **Boolean** | The flag that allows single values in content to be extracted as a single element collection in case the parameter is of Collection type. This flag is applicable for parameters of type Collection only. | [optional] 
**ComplexType** | **String** | The name of the complex type definition in case this is a complex parameter. The content.Grammar object must have a complex type, content.ComplexType, defined with the specified name in types collection property. | [optional] 
**ItemType** | **String** | The type of the collection item in case this is a collection parameter. | [optional] [default to "simple"]
**Name** | **String** | The name of the parameter. | [optional] 
**Path** | **String** | The content specific path information that identifies the parameter value within the content. The value is usually a XPath or JSONPath or a regular expression in case of text content. | [optional] 
**Type** | **String** | The type of the parameter. Accepted values are simple, complex, collection. | [optional] [default to "simple"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightContentBaseParameterAllOf  -AcceptSingleValue null `
 -ComplexType null `
 -ItemType null `
 -Name null `
 -Path null `
 -Type null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

