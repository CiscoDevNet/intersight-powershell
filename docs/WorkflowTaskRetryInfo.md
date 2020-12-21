# WorkflowTaskRetryInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.TaskRetryInfo"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.TaskRetryInfo"]
**Status** | **String** | Status of the retried task. | [optional] 
**TaskInstId** | **String** | Retry instance will get a unique instance id. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowTaskRetryInfo = Initialize-IntersightWorkflowTaskRetryInfo  -ClassId null `
 -ObjectType null `
 -Status null `
 -TaskInstId null
```

- Convert the resource to JSON
```powershell
$WorkflowTaskRetryInfo | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

