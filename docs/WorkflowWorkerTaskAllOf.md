# WorkflowWorkerTaskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CatalogMoid** | **String** | Specify the catalog moid that this task belongs. | [optional] 
**TaskDefinitionId** | **String** | The resolved referenced task definition managed object. | [optional] [readonly] 
**TaskDefinitionName** | **String** | The qualified name of task that should be executed. | [optional] 
**Version** | **Int64** | The task definition version to use in this workflow. When no version is specified then the default version of the task at the time of creating or updating this workflow is used. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowWorkerTaskAllOf  -CatalogMoid null `
 -TaskDefinitionId null `
 -TaskDefinitionName null `
 -Version null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

