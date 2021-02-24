# WorkflowParameterSetAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.ParameterSet"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.ParameterSet"]
**Condition** | **String** | The condition to be evaluated. * &#x60;eq&#x60; - Checks if the values of the two parameters are equal. * &#x60;ne&#x60; - Checks if the values of the two parameters are not equal. * &#x60;contains&#x60; - Checks if the second parameter string value is a substring of the first parameter string value. * &#x60;matchesPattern&#x60; - Checks if a string matches a regular expression. | [optional] [default to "eq"]
**ControlParameter** | **String** | Name of the controlling entity, whose value will be used for evaluating the parameter set. | [optional] 
**EnableParameters** | **String[]** |  | [optional] 
**Name** | **String** | Name for the parameter set.  Limited to 64 alphanumeric characters (upper and lower case), and special characters &#39;-&#39; and &#39;_&#39;. | [optional] 
**Value** | **String** | The controlling parameter will be evaluated against this &#39;value&#39;. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowParameterSetAllOf = Initialize-IntersightWorkflowParameterSetAllOf  -ClassId null `
 -ObjectType null `
 -Condition null `
 -ControlParameter null `
 -EnableParameters null `
 -Name null `
 -Value null
```

- Convert the resource to JSON
```powershell
$WorkflowParameterSetAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

