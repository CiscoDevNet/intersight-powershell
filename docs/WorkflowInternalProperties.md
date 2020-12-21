# WorkflowInternalProperties
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.InternalProperties"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.InternalProperties"]
**BaseTaskType** | **String** | This field will hold the base task type like HttpBaseTask or RemoteAnsibleBaseTask. | [optional] [readonly] 
**Constraints** | [**WorkflowTaskConstraints**](WorkflowTaskConstraints.md) |  | [optional] 
**Internal** | **Boolean** | Denotes this is an internal task. Internal tasks will be hidden from the UI when executing a workflow. | [optional] [readonly] 
**Owner** | **String** | The service that owns and is responsible for execution of the task. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$WorkflowInternalProperties = Initialize-IntersightWorkflowInternalProperties  -ClassId null `
 -ObjectType null `
 -BaseTaskType null `
 -Constraints null `
 -Internal null `
 -Owner null
```

- Convert the resource to JSON
```powershell
$WorkflowInternalProperties | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

