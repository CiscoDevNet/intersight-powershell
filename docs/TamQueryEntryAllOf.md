# TamQueryEntryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | Name is used to unique identify and result of the given query which can be used by subsequent queries as input data source. | [optional] 
**Priority** | **Int64** | An integer value depicting the priority of the query among the queries that are part of the same QueryEntry collection. | [optional] 
**Query** | **String** | A SparkSQL query to be used on a given data source. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTamQueryEntryAllOf  -Name null `
 -Priority null `
 -Query null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

