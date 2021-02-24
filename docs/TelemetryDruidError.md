# TelemetryDruidError
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarError** | **String** | A well-defined error code. | [optional] 
**ErrorMessage** | **String** | A free-form message with more information about the error. May be null. | [optional] 
**ErrorClass** | [**AnyType**](.md) | The class of the exception that caused this error. May be null. | [optional] 

## Examples

- Prepare the resource
```powershell
$TelemetryDruidError = Initialize-IntersightTelemetryDruidError  -VarError null `
 -ErrorMessage null `
 -ErrorClass null
```

- Convert the resource to JSON
```powershell
$TelemetryDruidError | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

