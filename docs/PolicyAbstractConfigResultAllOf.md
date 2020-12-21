# PolicyAbstractConfigResultAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ConfigStage** | **String** | The current running stage of the configuration or workflow. | [optional] 
**ConfigState** | **String** | Indicates overall configuration state for applying the configuration to the end point. Values  -- Ok, Ok-with-warning, Errored. | [optional] 
**ValidationState** | **String** | Indicates overall state for logical model validation. Values  -- Ok, Ok-with-warning, Errored. | [optional] 

## Examples

- Prepare the resource
```powershell
$PolicyAbstractConfigResultAllOf = Initialize-IntersightPolicyAbstractConfigResultAllOf  -ClassId null `
 -ObjectType null `
 -ConfigStage null `
 -ConfigState null `
 -ValidationState null
```

- Convert the resource to JSON
```powershell
$PolicyAbstractConfigResultAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

