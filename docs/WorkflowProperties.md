# WorkflowProperties
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.Properties"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.Properties"]
**ExternalMeta** | **Boolean** | When set to false the task definition can only be used by internal system workflows. When set to true then the task can be included in user defined workflows. | [optional] [default to $false]
**InputDefinition** | [**WorkflowBaseDataType[]**](WorkflowBaseDataType.md) |  | [optional] 
**OutputDefinition** | [**WorkflowBaseDataType[]**](WorkflowBaseDataType.md) |  | [optional] 
**RetryCount** | **Int64** | The number of times a task should be tried before marking as failed. | [optional] [default to 3]
**RetryDelay** | **Int64** | The delay in seconds after which the the task is re-tried. | [optional] [default to 60]
**RetryPolicy** | **String** | The retry policy for the task. * &#x60;Fixed&#x60; - The enum specifies the option as Fixed where the task retry happens after fixed time specified by RetryDelay. | [optional] [default to "Fixed"]
**SupportStatus** | **String** | Supported status of the definition. * &#x60;Supported&#x60; - The definition is a supported version and there will be no changes to the mandatory inputs or outputs. * &#x60;Beta&#x60; - The definition is a Beta version and this version can under go changes until the version is marked supported. * &#x60;Deprecated&#x60; - The version of definition is deprecated and typically there will be a higher version of the same definition that has been added. | [optional] [default to "Supported"]
**Timeout** | **Int64** | The timeout value in seconds after which task will be marked as timed out. Max allowed value is 7 days. | [optional] [default to 600]
**TimeoutPolicy** | **String** | The timeout policy for the task. * &#x60;Timeout&#x60; - The enum specifies the option as Timeout where task will be timed out after the specified time in Timeout property. * &#x60;Retry&#x60; - The enum specifies the option as Retry where task will be re-tried. | [optional] [default to "Timeout"]

## Examples

- Prepare the resource
```powershell
$WorkflowProperties = Initialize-IntersightWorkflowProperties  -ClassId null `
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
$WorkflowProperties | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

