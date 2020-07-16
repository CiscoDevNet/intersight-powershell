# PoolAbstractPoolAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Assigned** | **Int64** | Number of IDs that are currently assigned. | [optional] [readonly] 
**AssignmentOrder** | **String** | Assignment order decides the order in which the next identifier is allocated. | [optional] [default to "sequential"]
**Size** | **Int64** | Total number of identifiers in this pool. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightPoolAbstractPoolAllOf  -Assigned null `
 -AssignmentOrder null `
 -Size null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

