# IaasMostRunTasksAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "iaas.MostRunTasks"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "iaas.MostRunTasks"]
**TaskCategory** | **String** | A functional area to which a task belongs to. | [optional] [readonly] 
**TaskExecutionCount** | **Int64** | Number of times this task has executed. | [optional] [readonly] 
**TaskName** | **String** | Name of the task executed in UCSD. | [optional] [readonly] 
**TaskType** | **String** | Type of the task whether it is system task or custom task. | [optional] [readonly] 
**Guid** | [**IaasUcsdInfoRelationship**](IaasUcsdInfoRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$IaasMostRunTasksAllOf = Initialize-IntersightIaasMostRunTasksAllOf  -ClassId null `
 -ObjectType null `
 -TaskCategory null `
 -TaskExecutionCount null `
 -TaskName null `
 -TaskType null `
 -Guid null
```

- Convert the resource to JSON
```powershell
$IaasMostRunTasksAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

