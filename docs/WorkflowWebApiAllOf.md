# WorkflowWebApiAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.WebApi"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.WebApi"]
**Cookies** | [**AnyType**](.md) | Collection of key value pairs to set in the request header as Cookie list. | [optional] 
**EndpointRequestType** | **String** | If the target type is Endpoint, this property determines whether the request is to be handled as internal request or external request by the device connector. * &#x60;Internal&#x60; - The endpoint API executed is an internal request handled by the device connector plugin. * &#x60;External&#x60; - The endpoint API request is passed through by the device connector. | [optional] [default to "Internal"]
**Headers** | [**AnyType**](.md) | Collection of key value pairs to set in the request header. | [optional] 
**Method** | **String** | The HTTP method to be executed in the given URL (GET, POST, PUT, etc). If the value is not specified, GET will be used as default. The supported values are GET, POST, PUT, DELETE, PATCH, HEAD. | [optional] 
**MoType** | **String** | The type of the intersight object for which API request is to be made. The property is valid in case of Intersight API calls and the base url is automatically prepended based on the value. | [optional] 
**Protocol** | **String** | The accepted web protocol values are http and https. | [optional] 
**TargetType** | **String** | If the web API is to be executed in a remote device connected to the Intersight through device connector, &#39;Endpoint&#39; is expected as the value whereas if the API is an Intersight API, &#39;Local&#39; is expected as the value. | [optional] 
**Url** | **String** | The URL of the resource in the target to which the API request is made. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowWebApiAllOf = Initialize-IntersightWorkflowWebApiAllOf  -ClassId null `
 -ObjectType null `
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
$WorkflowWebApiAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

