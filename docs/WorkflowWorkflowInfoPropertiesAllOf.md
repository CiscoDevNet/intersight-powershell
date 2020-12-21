# WorkflowWorkflowInfoPropertiesAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.WorkflowInfoProperties"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.WorkflowInfoProperties"]
**Retryable** | **Boolean** | When true, this workflow can be retried if has not been modified for more than a period of 2 weeks. | [optional] [default to $false]
**RollbackAction** | **String** | Status of rollback for this workflow instance. The rollback action of the workflow can be enabled, disabled, completed. * &#x60;Disabled&#x60; - Status of the rollback action when workflow is disabled for rollback. * &#x60;Enabled&#x60; - Status of the rollback action when workflow is enabled for rollback. * &#x60;Completed&#x60; - Status of the rollback action once workflow completes the rollback for all eligiable tasks. | [optional] [readonly] [default to "Disabled"]

## Examples

- Prepare the resource
```powershell
$WorkflowWorkflowInfoPropertiesAllOf = Initialize-IntersightWorkflowWorkflowInfoPropertiesAllOf  -ClassId null `
 -ObjectType null `
 -Retryable null `
 -RollbackAction null
```

- Convert the resource to JSON
```powershell
$WorkflowWorkflowInfoPropertiesAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

