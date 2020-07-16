# WorkflowForkTaskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ForkedTasks** | **String[]** |  | [optional] 
**JoinTask** | **String** | Task name for the join control task that must follow a fork control task. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowForkTaskAllOf  -ForkedTasks null `
 -JoinTask null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

