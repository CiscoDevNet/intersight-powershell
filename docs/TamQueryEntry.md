# TamQueryEntry
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Name** | **String** | Name is used to unique identify and result of the given query which can be used by subsequent queries as input data source. | [optional] 
**Priority** | **Int64** | An integer value depicting the priority of the query among the queries that are part of the same QueryEntry collection. | [optional] 
**Query** | **String** | A SparkSQL query to be used on a given data source. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTamQueryEntry  -ClassId null `
 -ObjectType null `
 -Name null `
 -Priority null `
 -Query null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

