# WorkflowSubWorkflowTaskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CatalogMoid** | **String** | Specify the catalog moid that this task belongs. | [optional] 
**Version** | **Int64** | The workflow definition version to use as subworkflow. When no version is specified then the default version of the workflow at the time of creating or updating this workflow is used. | [optional] 
**WorkflowDefinitionId** | **String** | The resolved referenced workflow definition managed object. | [optional] [readonly] 
**WorkflowDefinitionName** | **String** | The qualified name of workflow that should be executed as a task. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowSubWorkflowTaskAllOf  -CatalogMoid null `
 -Version null `
 -WorkflowDefinitionId null `
 -WorkflowDefinitionName null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

