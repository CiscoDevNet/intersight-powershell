# WorkflowConstraintsAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnumList** | [**WorkflowEnumEntry[]**](WorkflowEnumEntry.md) |  | [optional] 
**Max** | **Double** | Allowed maximum value of the parameter if parameter is integer/float or maximum length of the parameter if the parameter is string. When max and min are set to 0, then the limits are not checked. | [optional] 
**Min** | **Double** | Allowed minimum value of the parameter if parameter is integer/float or minimum length of the parameter if the parameter is string. When max and min are set to 0, then the limits are not checked. | [optional] 
**Regex** | **String** | When the parameter is a string this regular expression is used to ensure the value is valid. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowConstraintsAllOf  -EnumList null `
 -Max null `
 -Min null `
 -Regex null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

