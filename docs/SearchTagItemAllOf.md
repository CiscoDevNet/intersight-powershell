# SearchTagItemAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **Int64** | The number of times this tag key has been set across all resources. | [optional] [readonly] 
**Key** | **String** | Key of the Tag from all the resources in Intersight. | [optional] [readonly] 
**Values** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSearchTagItemAllOf  -Count null `
 -Key null `
 -Values null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

