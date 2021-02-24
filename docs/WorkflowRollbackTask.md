# WorkflowRollbackTask
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.RollbackTask"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.RollbackTask"]
**CatalogMoid** | **String** | The catalog under which the task definition has been added. | [optional] 
**Description** | **String** | Description of rollback task definition. | [optional] 
**InputParameters** | [**AnyType**](.md) | Input parameters mapping for rollback task from the input or output of the main task definition. | [optional] 
**Name** | **String** | Name of the task definition which is capable of doing rollback of this task. | [optional] 
**TaskMoid** | **String** | The resolved referenced rollback task definition managed object. | [optional] 
**Version** | **Int64** | The version of the task definition. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowRollbackTask = Initialize-IntersightWorkflowRollbackTask  -ClassId null `
 -ObjectType null `
 -CatalogMoid null `
 -Description null `
 -InputParameters null `
 -Name null `
 -TaskMoid null `
 -Version null
```

- Convert the resource to JSON
```powershell
$WorkflowRollbackTask | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

