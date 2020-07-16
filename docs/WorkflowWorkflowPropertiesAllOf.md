# WorkflowWorkflowPropertiesAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalMeta** | **Boolean** | When set to false the workflow is owned by the system and used for internal services. Such workflows cannot be directly used by external entities. | [optional] 
**Retryable** | **Boolean** | When true, this workflow can be retried if has not been modified for more than a period of 2 weeks. | [optional] 
**SupportStatus** | **String** | Supported status of the definition. | [optional] [default to "Supported"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowWorkflowPropertiesAllOf  -ExternalMeta null `
 -Retryable null `
 -SupportStatus null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

