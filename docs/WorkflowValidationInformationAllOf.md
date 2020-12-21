# WorkflowValidationInformationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.ValidationInformation"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.ValidationInformation"]
**State** | **String** | The current validation state of this workflow. The possible states are Valid, Invalid, NotValidated (default). * &#x60;NotValidated&#x60; - The state when workflow definition has not been validated. * &#x60;Valid&#x60; - The state when workflow definition is valid. * &#x60;Invalid&#x60; - The state when workflow definition is invalid. | [optional] [readonly] [default to "NotValidated"]
**ValidationError** | [**WorkflowValidationError[]**](WorkflowValidationError.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowValidationInformationAllOf = Initialize-IntersightWorkflowValidationInformationAllOf  -ClassId null `
 -ObjectType null `
 -State null `
 -ValidationError null
```

- Convert the resource to JSON
```powershell
$WorkflowValidationInformationAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

