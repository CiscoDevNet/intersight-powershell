# IaasMostRunTasksAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskCategory** | **String** | A functional area to which a task belongs to. | [optional] [readonly] 
**TaskExecutionCount** | **Int64** | Number of times this task has executed. | [optional] [readonly] 
**TaskName** | **String** | Name of the task executed in UCSD. | [optional] [readonly] 
**TaskType** | **String** | Type of the task whether it is system task or custom task. | [optional] [readonly] 
**Guid** | [**IaasUcsdInfoRelationship**](IaasUcsdInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightIaasMostRunTasksAllOf  -TaskCategory null `
 -TaskExecutionCount null `
 -TaskName null `
 -TaskType null `
 -Guid null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

