# WorkflowCliCommand
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Body** | **String** | The optional request body that is sent as part of this API request. The request body can contain a golang template that can be populated with task input parameters and previous API output parameters. | [optional] 
**ContentType** | **String** | Intersight Orchestrator, with the support of response parser specification, can extract the values from API responses and map them to task output parameters. The value extraction is supported for response content types XML and JSON. The type of the content that gets passed as payload and response in this API. | [optional] [default to "json"]
**Name** | **String** | A reference name for this API request within the batch API request. This name shall be used to map the API output parameters to subsequent API input parameters within a batch API task. | [optional] 
**Outcomes** | [**AnyType**](.md) | All the possible outcomes of this API are captured here. Outcomes property is a collection property of type workflow.Outcome objects. The outcomes can be mapped to the message to be shown. The outcomes are evaluated in the order they are given. At the end of the outcomes list, an catchall success/fail outcome can be added with condition as &#39;true&#39;. This is an optional property and if not specified the task will be marked as success. | [optional] 
**ResponseSpec** | [**ContentGrammar**](ContentGrammar.md) |  | [optional] 
**SkipOnCondition** | **String** | The skip expression, if provided, allows the batch API executor to skip the api execution when the given expression evaluates to true. The expression is given as such a golang template that has to be evaluated to a final content true/false. The expression is an optional and in case not provided, the API will always be executed. | [optional] 
**StartDelay** | **Int64** | The delay in seconds after which the API needs to be executed. By default, the given API is executed immediately. Specifying a start delay adds to the delay to execution. Start Delay is not supported for the first API in the Batch and cumulative delay of all the APIs in the Batch should not exceed the task time out. | [optional] 
**Timeout** | **Int64** | The duration in seconds by which the API response is expected from the API target. If the end point does not respond for the API request within this timeout duration, the task will be marked as failed. | [optional] 
**Command** | **String** | The command to run on the device connector. | [optional] 
**EndPrompt** | **String** | The regex string that identifies the end of the command response. | [optional] 
**ExpectPrompts** | [**WorkflowExpectPrompt[]**](WorkflowExpectPrompt.md) |  | [optional] 
**SkipStatusCheck** | **Boolean** | Skips the execution status check of the terminal command. One use case for this is while exiting the terminal session from esxi host. | [optional] 
**TerminalEnd** | **Boolean** | If this flag is set, it marks the end of the terminal session where the previous commands were executed. | [optional] 
**TerminalStart** | **Boolean** | If this flag is set, the execution of this command initiates a terminal session in which the subsequent CLI commands are executed until a command with terminalEnd flag is encountered or the end of the batch. | [optional] 
**Type** | **String** | The type of the command - can be interactive or non-interactive. | [optional] [default to "NonInteractive"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowCliCommand  -ClassId null `
 -ObjectType null `
 -Body null `
 -ContentType null `
 -Name null `
 -Outcomes null `
 -ResponseSpec null `
 -SkipOnCondition null `
 -StartDelay null `
 -Timeout null `
 -Command null `
 -EndPrompt null `
 -ExpectPrompts null `
 -SkipStatusCheck null `
 -TerminalEnd null `
 -TerminalStart null `
 -Type null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

