# WorkflowSubWorkflowTaskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.SubWorkflowTask"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.SubWorkflowTask"]
**CatalogMoid** | **String** | Specify the catalog moid that this task belongs. | [optional] 
**Version** | **Int64** | The workflow definition version to use as subworkflow. When no version is specified then the default version of the workflow at the time of creating or updating this workflow is used. | [optional] 
**WorkflowDefinitionId** | **String** | The resolved referenced workflow definition managed object. | [optional] [readonly] 
**WorkflowDefinitionName** | **String** | The qualified name of workflow that should be executed as a task. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowSubWorkflowTaskAllOf = Initialize-IntersightWorkflowSubWorkflowTaskAllOf  -ClassId null `
 -ObjectType null `
 -CatalogMoid null `
 -Version null `
 -WorkflowDefinitionId null `
 -WorkflowDefinitionName null
```

- Convert the resource to JSON
```powershell
$WorkflowSubWorkflowTaskAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

