# HyperflexErrorStackAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "hyperflex.ErrorStack"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "hyperflex.ErrorStack"]
**Message** | **String** | The error message string for this error stack. | [optional] [readonly] 
**MessageId** | **Int64** | The error message ID for this error stack. | [optional] [readonly] 

## Examples

- Prepare the resource
```powershell
$HyperflexErrorStackAllOf = Initialize-IntersightHyperflexErrorStackAllOf  -ClassId null `
 -ObjectType null `
 -Message null `
 -MessageId null
```

- Convert the resource to JSON
```powershell
$HyperflexErrorStackAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

