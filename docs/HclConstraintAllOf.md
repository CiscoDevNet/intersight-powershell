# HclConstraintAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConstraintName** | **String** | Name or key of the applicable compatibility constraint. | [optional] 
**ConstraintValue** | **String** | Value of the applicable compatibility constraint. Could either be a string value or a regex. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightHclConstraintAllOf  -ConstraintName null `
 -ConstraintValue null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

