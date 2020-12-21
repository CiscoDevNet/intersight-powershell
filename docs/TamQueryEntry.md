# TamQueryEntry
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "tam.QueryEntry"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "tam.QueryEntry"]
**Name** | **String** | Name is used to unique identify and result of the given query which can be used by subsequent queries as input data source. | [optional] 
**Priority** | **Int64** | An integer value depicting the priority of the query among the queries that are part of the same QueryEntry collection. | [optional] 
**Query** | **String** | A SparkSQL query to be used on a given data source. | [optional] 

## Examples

- Prepare the resource
```powershell
$TamQueryEntry = Initialize-IntersightTamQueryEntry  -ClassId null `
 -ObjectType null `
 -Name null `
 -Priority null `
 -Query null
```

- Convert the resource to JSON
```powershell
$TamQueryEntry | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

