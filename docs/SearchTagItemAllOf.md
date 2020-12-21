# SearchTagItemAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "search.TagItem"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "search.TagItem"]
**Count** | **Int64** | The number of times this tag key has been set across all resources. | [optional] [readonly] 
**Key** | **String** | Key of the Tag from all the resources in Intersight. | [optional] [readonly] 
**Values** | **String[]** |  | [optional] 

## Examples

- Prepare the resource
```powershell
$SearchTagItemAllOf = Initialize-IntersightSearchTagItemAllOf  -ClassId null `
 -ObjectType null `
 -Count null `
 -Key null `
 -Values null
```

- Convert the resource to JSON
```powershell
$SearchTagItemAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

