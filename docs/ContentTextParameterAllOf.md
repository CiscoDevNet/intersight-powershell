# ContentTextParameterAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsDelimiter** | **Boolean** | Data to be extracted from text content can be simple type or complex type or collection of simple/complex types. Complex types are group of simple or complex type. Delimiter is required to stop parsing list and complex data types. isDelimiter specifies whether given TextParameter is a delimiter or regular rule to capture the text data. | [optional] 
**IsNextCaptureOnSameLine** | **Boolean** | Set to true of the next value to capture resides on the same text line of current match. By default textFSM engine gets the next text line on finding the first match. | [optional] 
**RegexLine** | **String** | Regular expression of the line containing the data to be extracted from text content. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightContentTextParameterAllOf  -IsDelimiter null `
 -IsNextCaptureOnSameLine null `
 -RegexLine null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

