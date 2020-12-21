# WorkflowCliCommand
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.CliCommand"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.CliCommand"]
**AssetTargetMoid** | **String** | Asset target defines the remote target endpoints which are either managed by Intersight or their service APIs are invoked from Intersight. Generic API executor service Jasmine can invoke these remote APIs via its executors. Asset targets can be accessed directly for cloud targets or via an associated Intersight Assist. Prerequisite to use asset targets is to persist the target details. Asset target MoRef can be given as task input of type TargetDataType. Fusion determines and populates the target context with the Assist if associated with. It is set internally at the API level. In case of an associated assist, it is used by Assist to fetch the target details and form the API request to send to endpoints. In case of cloud asset targets, Jasmine fetched the target details from DB, forms the API request and sends it to the target. | [optional] [readonly] 
**Body** | **String** | The optional request body that is sent as part of this API request. The request body can contain a golang template that can be populated with task input parameters and previous API output parameters. | [optional] 
**ContentType** | **String** | Intersight Orchestrator, with the support of response parser specification, can extract the values from API responses and map them to task output parameters. The value extraction is supported for response content types XML and JSON. The type of the content that gets passed as payload and response in this API. | [optional] 
**Description** | **String** | A description that task designer can add to individual API requests that explain  what the API call is about. | [optional] 
**Label** | **String** | A user friendly label that task designers have given to the batch API request. | [optional] 
**Name** | **String** | A reference name for this API request within the batch API request. This name shall be used to map the API output parameters to subsequent API input parameters within a batch API task. | [optional] 
**Outcomes** | [**AnyType**](.md) | All the possible outcomes of this API are captured here. Outcomes property is a collection property of type workflow.Outcome objects. The outcomes can be mapped to the message to be shown. The outcomes are evaluated in the order they are given. At the end of the outcomes list, an catchall success/fail outcome can be added with condition as &#39;true&#39;. This is an optional property and if not specified the task will be marked as success. | [optional] 
**ResponseSpec** | [**AnyType**](.md) | The optional grammar specification for parsing the response to extract the required values. The specification should have extraction specification specified for all the API output parameters. | [optional] 
**SkipOnCondition** | **String** | The skip expression, if provided, allows the batch API executor to skip the api execution when the given expression evaluates to true. The expression is given as such a golang template that has to be evaluated to a final content true/false. The expression is an optional and in case not provided, the API will always be executed. | [optional] 
**StartDelay** | **Int64** | The delay in seconds after which the API needs to be executed. By default, the given API is executed immediately. Specifying a start delay adds to the delay to execution. Start Delay is not supported for the first API in the Batch and cumulative delay of all the APIs in the Batch should not exceed the task time out. | [optional] 
**Timeout** | **Int64** | The duration in seconds by which the API response is expected from the API target. If the end point does not respond for the API request within this timeout duration, the task will be marked as failed. | [optional] 
**Command** | **String** | The command to run on the device connector. | [optional] 
**EndPrompt** | **String** | The regex string that identifies the end of the command response. | [optional] 
**ExpectPrompts** | [**WorkflowExpectPrompt[]**](WorkflowExpectPrompt.md) |  | [optional] 
**SkipStatusCheck** | **Boolean** | Skips the execution status check of the terminal command. One use case for this is while exiting the terminal session from esxi host. | [optional] 
**TerminalEnd** | **Boolean** | If this flag is set, it marks the end of the terminal session where the previous commands were executed. | [optional] 
**TerminalStart** | **Boolean** | If this flag is set, the execution of this command initiates a terminal session in which the subsequent CLI commands are executed until a command with terminalEnd flag is encountered or the end of the batch. | [optional] 
**Type** | **String** | The type of the command - can be interactive or non-interactive. * &#x60;NonInteractive&#x60; - The CLI command is not an interactive command. * &#x60;Interactive&#x60; - The CLI command is executed in interactive mode and the command must provide the expects andanswers. | [optional] [default to "NonInteractive"]

## Examples

- Prepare the resource
```powershell
$WorkflowCliCommand = Initialize-IntersightWorkflowCliCommand  -ClassId null `
 -ObjectType null `
 -AssetTargetMoid null `
 -Body null `
 -ContentType null `
 -Description null `
 -Label null `
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
$WorkflowCliCommand | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

