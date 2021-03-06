# WorkflowPrimitiveDataTypeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.PrimitiveDataType"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.PrimitiveDataType"]
**Properties** | [**WorkflowPrimitiveDataProperty**](WorkflowPrimitiveDataProperty.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowPrimitiveDataTypeAllOf = Initialize-IntersightWorkflowPrimitiveDataTypeAllOf  -ClassId null `
 -ObjectType null `
 -Properties null
```

- Convert the resource to JSON
```powershell
$WorkflowPrimitiveDataTypeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

