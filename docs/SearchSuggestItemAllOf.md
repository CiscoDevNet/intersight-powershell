# SearchSuggestItemAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "search.SuggestItem"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "search.SuggestItem"]
**CompleteMo** | **Boolean** | Flag for returning complete objects that matched the global search criteria. | [optional] 
**Rawquery** | **String** | Additional filter parameters for global search. You can also specify OData select fields here. Maximum Query Length is limited to 10000. | [optional] 
**Skip** | **Int64** | Starting offset for the results to be returned from external search engine. | [optional] 
**SuggestTerm** | **String** | Main search term used for global search across all Managed Objects that has search enabled. Search Term can be up to 200 characters long. | [optional] 
**Top** | **Int64** | Maximum number of results to be returned from external search engine. | [optional] 
**Type** | **String** | Object type filter of a Managed Object. Search will be restricted only on the specified object types.  Do not provide IndexMoTypes filter in the rawquery, if you specify values in this field. | [optional] 

## Examples

- Prepare the resource
```powershell
$SearchSuggestItemAllOf = Initialize-IntersightSearchSuggestItemAllOf  -ClassId null `
 -ObjectType null `
 -CompleteMo null `
 -Rawquery null `
 -Skip null `
 -SuggestTerm null `
 -Top null `
 -Type null
```

- Convert the resource to JSON
```powershell
$SearchSuggestItemAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

