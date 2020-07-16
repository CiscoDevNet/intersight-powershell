# WorkflowPropertiesAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalMeta** | **Boolean** | When set to false the task definition can only be used by internal system workflows. When set to true then the task can be included in user defined workflows. | [optional] 
**InputDefinition** | [**WorkflowBaseDataType[]**](WorkflowBaseDataType.md) |  | [optional] 
**OutputDefinition** | [**WorkflowBaseDataType[]**](WorkflowBaseDataType.md) |  | [optional] 
**RetryCount** | **Int64** | The number of times a task should be tried before marking as failed. | [optional] 
**RetryDelay** | **Int64** | The delay in seconds after which the the task is re-tried. | [optional] 
**RetryPolicy** | **String** | The retry policy for the task. | [optional] [default to "Fixed"]
**SupportStatus** | **String** | Supported status of the definition. | [optional] [default to "Supported"]
**Timeout** | **Int64** | The timeout value in seconds after which task will be marked as timed out. Max allowed value is 7 days. | [optional] 
**TimeoutPolicy** | **String** | The timeout policy for the task. | [optional] [default to "Timeout"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowPropertiesAllOf  -ExternalMeta null `
 -InputDefinition null `
 -OutputDefinition null `
 -RetryCount null `
 -RetryDelay null `
 -RetryPolicy null `
 -SupportStatus null `
 -Timeout null `
 -TimeoutPolicy null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

