# WorkflowArrayDataTypeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ArrayItemType** | [**WorkflowArrayItem**](WorkflowArrayItem.md) |  | [optional] 
**Max** | **Int64** | Specify the maximum value of the array. | [optional] 
**Min** | **Int64** | Specify the minimum value of the array. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowArrayDataTypeAllOf  -ArrayItemType null `
 -Max null `
 -Min null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

