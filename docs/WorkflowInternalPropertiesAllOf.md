# WorkflowInternalPropertiesAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseTaskType** | **String** | This field will hold the base task type like HttpBaseTask or RemoteAnsibleBaseTask. | [optional] [readonly] 
**Constraints** | [**WorkflowTaskConstraints**](WorkflowTaskConstraints.md) |  | [optional] 
**Internal** | **Boolean** | Denotes this is an internal task. Internal tasks will be hidden from the UI when executing a workflow. | [optional] [readonly] 
**Owner** | **String** | The service that owns and is responsible for execution of the task. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowInternalPropertiesAllOf  -BaseTaskType null `
 -Constraints null `
 -Internal null `
 -Owner null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

