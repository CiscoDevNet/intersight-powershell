# WorkflowWebApi
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
**EndpointRequestType** | **String** | If the target type is Endpoint, this property determines whether the request is to be handled as internal request or external request by the device connector. | [optional] [default to "Internal"]
**Headers** | [**AnyType**](.md) | Collection of key value pairs to set in the request header. | [optional] 
**Method** | **String** | The HTTP method to be executed in the given URL (GET, POST, PUT, etc). If the value is not specified, GET will be used as default. | [optional] 
**MoType** | **String** | The type of the intersight object for which API request is to be made. The property is valid in case of Intersight API calls and the base url is automatically prepended based on the value. | [optional] 
**Protocol** | **String** | The accepted web protocol values are http and https. | [optional] 
**TargetType** | **String** | If the web API is to be executed in a remote device connected to the Intersight through device connector, &#39;Endpoint&#39; is expected as the value whereas if the API is an Intersight API, &#39;Local&#39; is expected as the value. | [optional] [default to "Endpoint"]
**Url** | **String** | The URL of the resource in the target to which the API request is made. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowWebApi  -ClassId null `
 -ObjectType null `
 -Body null `
 -ContentType null `
 -Name null `
 -Outcomes null `
 -ResponseSpec null `
 -SkipOnCondition null `
 -StartDelay null `
 -Timeout null `
 -EndpointRequestType null `
 -Headers null `
 -Method null `
 -MoType null `
 -Protocol null `
 -TargetType null `
 -Url null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

