# PolicyAbstractConfigResultAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigStage** | **String** | The current running stage of the configuration or workflow. | [optional] 
**ConfigState** | **String** | Indicates overall configuration state for applying the configuration to the end point. Values  -- Ok, Ok-with-warning, Errored. | [optional] 
**ValidationState** | **String** | Indicates overall state for logical model validation. Values  -- Ok, Ok-with-warning, Errored. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightPolicyAbstractConfigResultAllOf  -ConfigStage null `
 -ConfigState null `
 -ValidationState null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

