# WorkflowBuildTaskMetaAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **String** | Name for the BuildTaskMeta instance used to created a dynamic workflow. | [optional] [readonly] 
**Src** | **String** | Microservice owner for the task in this workflow. | [optional] [readonly] 
**TaskList** | [**AnyType**](.md) | Task list used to build the dynamic workflow. | [optional] [readonly] 
**TaskType** | **String** | The type of the task within this workflow. | [optional] [readonly] 
**WorkflowType** | **String** | The type for the dynamic workflow. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowBuildTaskMetaAllOf  -Name null `
 -Src null `
 -TaskList null `
 -TaskType null `
 -WorkflowType null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

