# WorkflowValidationInformationAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **String** | The current validation state of this workflow. The possible states are Valid, Invalid, NotValidated (default). | [optional] [readonly] [default to "NotValidated"]
**ValidationError** | [**WorkflowValidationError[]**](WorkflowValidationError.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowValidationInformationAllOf  -State null `
 -ValidationError null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

