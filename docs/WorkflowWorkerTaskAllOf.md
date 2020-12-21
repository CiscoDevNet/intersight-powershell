# WorkflowWorkerTaskAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.WorkerTask"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.WorkerTask"]
**CatalogMoid** | **String** | Specify the catalog moid that this task belongs. | [optional] 
**TaskDefinitionId** | **String** | The resolved referenced task definition managed object. | [optional] [readonly] 
**TaskDefinitionName** | **String** | The qualified name of task that should be executed. | [optional] 
**Version** | **Int64** | The task definition version to use in this workflow. When no version is specified then the default version of the task at the time of creating or updating this workflow is used. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowWorkerTaskAllOf = Initialize-IntersightWorkflowWorkerTaskAllOf  -ClassId null `
 -ObjectType null `
 -CatalogMoid null `
 -TaskDefinitionId null `
 -TaskDefinitionName null `
 -Version null
```

- Convert the resource to JSON
```powershell
$WorkflowWorkerTaskAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

