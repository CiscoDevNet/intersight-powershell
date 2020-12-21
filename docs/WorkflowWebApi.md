# WorkflowWebApi
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.WebApi"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.WebApi"]
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
**Cookies** | [**AnyType**](.md) | Collection of key value pairs to set in the request header as Cookie list. | [optional] 
**EndpointRequestType** | **String** | If the target type is Endpoint, this property determines whether the request is to be handled as internal request or external request by the device connector. * &#x60;Internal&#x60; - The endpoint API executed is an internal request handled by the device connector plugin. * &#x60;External&#x60; - The endpoint API request is passed through by the device connector. | [optional] [default to "Internal"]
**Headers** | [**AnyType**](.md) | Collection of key value pairs to set in the request header. | [optional] 
**Method** | **String** | The HTTP method to be executed in the given URL (GET, POST, PUT, etc). If the value is not specified, GET will be used as default. | [optional] 
**MoType** | **String** | The type of the intersight object for which API request is to be made. The property is valid in case of Intersight API calls and the base url is automatically prepended based on the value. | [optional] 
**Protocol** | **String** | The accepted web protocol values are http and https. | [optional] 
**TargetType** | **String** | If the web API is to be executed in a remote device connected to the Intersight through device connector, &#39;Endpoint&#39; is expected as the value whereas if the API is an Intersight API, &#39;Local&#39; is expected as the value. | [optional] 
**Url** | **String** | The URL of the resource in the target to which the API request is made. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowWebApi = Initialize-IntersightWorkflowWebApi  -ClassId null `
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
 -Cookies null `
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
$WorkflowWebApi | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

