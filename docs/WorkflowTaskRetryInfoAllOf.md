# WorkflowTaskRetryInfoAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **String** | Status of the retried task. | [optional] 
**TaskInstId** | **String** | Retry instance will get a unique instance id. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowTaskRetryInfoAllOf  -Status null `
 -TaskInstId null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

