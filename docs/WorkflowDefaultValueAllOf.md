# WorkflowDefaultValueAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Override** | **Boolean** | Override the default value provided for the data type. When true, allow the user to enter value for the data type. | [optional] 
**Value** | [**AnyType**](.md) | Default value for the data type. If default value was provided and the input was required the default value will be used as the input. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowDefaultValueAllOf  -Override null `
 -Value null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

