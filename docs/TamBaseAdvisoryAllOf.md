# TamBaseAdvisoryAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **String** | Brief description of the advisory details. | [optional] 
**Name** | **String** | A user defined name for the Intersight Advisory. | [optional] 
**Severity** | [**TamSeverity**](TamSeverity.md) |  | [optional] 
**State** | **String** | Current state of the advisory. | [optional] [default to "ready"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightTamBaseAdvisoryAllOf  -Description null `
 -Name null `
 -Severity null `
 -State null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

