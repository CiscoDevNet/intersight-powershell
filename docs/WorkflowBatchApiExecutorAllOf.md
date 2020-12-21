# WorkflowBatchApiExecutorAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.BatchApiExecutor"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.BatchApiExecutor"]
**Batch** | [**WorkflowApi[]**](WorkflowApi.md) |  | [optional] 
**Constraints** | [**WorkflowTaskConstraints**](WorkflowTaskConstraints.md) |  | [optional] 
**Description** | **String** | A detailed description about the batch APIs. | [optional] 
**Name** | **String** | Name for the batch API task. | [optional] 
**Outcomes** | [**AnyType**](.md) | All the possible outcomes of this task are captured here. Outcomes property is a collection property of type workflow.Outcome objects. The outcomes can be mapped to the message to be shown. The outcomes are evaluated in the order they are given. At the end of the outcomes list, an catchall success/fail outcome can be added with condition as &#39;true&#39;. This is an optional property and if not specified the task will be marked as success. | [optional] 
**Output** | [**AnyType**](.md) | Intersight Orchestrator allows the extraction of required values from API responses using the API response grammar. These extracted values can be mapped to task output parameters defined in task definition. The mapping of API output parameters to the task output parameters is provided as JSON in this property. | [optional] 
**RetryFromFailedApi** | **Boolean** | When an execution of a nth API in the Batch fails, Retry from falied API flag indicates if the execution should start from the nth API or the first API during task retry. By default the value is set to false. | [optional] 
**SkipOnCondition** | **String** | The skip expression, if provided, allows the batch API executor to skip the task execution when the given expression evaluates to true. The expression is given as such a golang template that has to be evaluated to a final content true/false. The expression is an optional and in case not provided, the API will always be executed. | [optional] 
**ErrorResponseHandler** | [**WorkflowErrorResponseHandlerRelationship**](WorkflowErrorResponseHandlerRelationship.md) |  | [optional] 
**TaskDefinition** | [**WorkflowTaskDefinitionRelationship**](WorkflowTaskDefinitionRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowBatchApiExecutorAllOf = Initialize-IntersightWorkflowBatchApiExecutorAllOf  -ClassId null `
 -ObjectType null `
 -Batch null `
 -Constraints null `
 -Description null `
 -Name null `
 -Outcomes null `
 -Output null `
 -RetryFromFailedApi null `
 -SkipOnCondition null `
 -ErrorResponseHandler null `
 -TaskDefinition null
```

- Convert the resource to JSON
```powershell
$WorkflowBatchApiExecutorAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

