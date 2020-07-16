# WorkflowTargetDataTypeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomDataTypeProperties** | [**WorkflowCustomDataProperty**](WorkflowCustomDataProperty.md) |  | [optional] 
**IsArray** | **Boolean** | When this property is true then an array of targets can be passed as input. | [optional] 
**Max** | **Int64** | Specify the maximum value of the array. | [optional] 
**Min** | **Int64** | Specify the minimum value of the array. | [optional] 
**Properties** | [**WorkflowTargetProperty[]**](WorkflowTargetProperty.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowTargetDataTypeAllOf  -CustomDataTypeProperties null `
 -IsArray null `
 -Max null `
 -Min null `
 -Properties null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

