# SearchSuggestItemAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompleteMo** | **Boolean** | Flag for returning complete objects that matched the global search criteria. | [optional] 
**Rawquery** | **String** | Additional filter parameters for global search. You can also specify OData select fields here. Maximum Query Length is limited to 10000. | [optional] 
**Skip** | **Int64** | Starting offset for the results to be returned from external search engine. | [optional] 
**SuggestTerm** | **String** | Main search term used for global search across all Managed Objects that has search enabled. Search Term can be up to 200 characters long. | [optional] 
**Top** | **Int64** | Maximum number of results to be returned from external search engine. | [optional] 
**Type** | **String** | Object type filter of a Managed Object. Search will be restricted only on the specified object types.  Do not provide IndexMoTypes filter in the rawquery, if you specify values in this field. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSearchSuggestItemAllOf  -CompleteMo null `
 -Rawquery null `
 -Skip null `
 -SuggestTerm null `
 -Top null `
 -Type null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

