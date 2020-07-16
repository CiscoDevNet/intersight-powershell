# WorkflowProperties
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
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
Initialize-IntersightWorkflowProperties  -ClassId null `
 -ObjectType null `
 -ExternalMeta null `
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

