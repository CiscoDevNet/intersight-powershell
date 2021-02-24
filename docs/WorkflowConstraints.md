# WorkflowConstraints
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.Constraints"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.Constraints"]
**EnumList** | [**WorkflowEnumEntry[]**](WorkflowEnumEntry.md) |  | [optional] 
**Max** | **Double** | Allowed maximum value of the parameter if parameter is integer/float or maximum length of the parameter if the parameter is string. When max and min are set to 0, then the limits are not checked. The maximum number supported is 1.797693134862315708145274237317043567981e+308 or (2**1023 * (2**53 - 1) / 2**52). When a number bigger than this is given as Maximum value, the constraints will not be enforced. | [optional] 
**Min** | **Double** | Allowed minimum value of the parameter if parameter is integer/float or minimum length of the parameter if the parameter is string. When max and min are set to 0, then the limits are not checked. The minimum number supported is 4.940656458412465441765687928682213723651e-324 or (1 / 2 ** (1023 - 1 + 52)). When a number smaller than this is given as minimum value, the constraints will not be enforced. | [optional] 
**Regex** | **String** | When the parameter is a string this regular expression is used to ensure the value is valid. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowConstraints = Initialize-IntersightWorkflowConstraints  -ClassId null `
 -ObjectType null `
 -EnumList null `
 -Max null `
 -Min null `
 -Regex null
```

- Convert the resource to JSON
```powershell
$WorkflowConstraints | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

