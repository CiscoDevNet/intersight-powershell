# WorkflowTargetDataTypeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.TargetDataType"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.TargetDataType"]
**CustomDataTypeProperties** | [**WorkflowCustomDataProperty**](WorkflowCustomDataProperty.md) |  | [optional] 
**IsArray** | **Boolean** | When this property is true then an array of targets can be passed as input. | [optional] [default to $false]
**Max** | **Int64** | Specify the maximum value of the array. | [optional] 
**Min** | **Int64** | Specify the minimum value of the array. | [optional] 
**Properties** | [**WorkflowTargetProperty[]**](WorkflowTargetProperty.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowTargetDataTypeAllOf = Initialize-IntersightWorkflowTargetDataTypeAllOf  -ClassId null `
 -ObjectType null `
 -CustomDataTypeProperties null `
 -IsArray null `
 -Max null `
 -Min null `
 -Properties null
```

- Convert the resource to JSON
```powershell
$WorkflowTargetDataTypeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

