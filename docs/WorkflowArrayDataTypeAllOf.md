# WorkflowArrayDataTypeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.ArrayDataType"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.ArrayDataType"]
**ArrayItemType** | [**WorkflowArrayItem**](WorkflowArrayItem.md) |  | [optional] 
**Max** | **Int64** | Specify the maximum value of the array. | [optional] 
**Min** | **Int64** | Specify the minimum value of the array. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowArrayDataTypeAllOf = Initialize-IntersightWorkflowArrayDataTypeAllOf  -ClassId null `
 -ObjectType null `
 -ArrayItemType null `
 -Max null `
 -Min null
```

- Convert the resource to JSON
```powershell
$WorkflowArrayDataTypeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

