# ContentTextParameterAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "content.TextParameter"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "content.TextParameter"]
**IsDelimiter** | **Boolean** | Data to be extracted from text content can be simple type or complex type or collection of simple/complex types. Complex types are group of simple or complex type. Delimiter is required to stop parsing list and complex data types. isDelimiter specifies whether given TextParameter is a delimiter or regular rule to capture the text data. | [optional] [default to $false]
**IsNextCaptureOnSameLine** | **Boolean** | Set to true of the next value to capture resides on the same text line of current match. By default textFSM engine gets the next text line on finding the first match. | [optional] [default to $false]
**RegexLine** | **String** | Regular expression of the line containing the data to be extracted from text content. | [optional] 

## Examples

- Prepare the resource
```powershell
$ContentTextParameterAllOf = Initialize-IntersightContentTextParameterAllOf  -ClassId null `
 -ObjectType null `
 -IsDelimiter null `
 -IsNextCaptureOnSameLine null `
 -RegexLine null
```

- Convert the resource to JSON
```powershell
$ContentTextParameterAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

