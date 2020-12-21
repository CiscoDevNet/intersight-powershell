# WorkflowPrimitiveDataPropertyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.PrimitiveDataProperty"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.PrimitiveDataProperty"]
**Constraints** | [**WorkflowConstraints**](WorkflowConstraints.md) |  | [optional] 
**InventorySelector** | [**WorkflowMoReferenceProperty[]**](WorkflowMoReferenceProperty.md) |  | [optional] 
**Secure** | **Boolean** | Intersight supports secure properties as task input/output. The values of these properties are encrypted and stored in Intersight. This flag marks the property to be secure when it is set to true. | [optional] 
**Type** | **String** | Specify the enum type for primitive data type. * &#x60;string&#x60; - Enum to specify a string data type. * &#x60;integer&#x60; - Enum to specify an integer32 data type. * &#x60;float&#x60; - Enum to specify a float64 data type. * &#x60;boolean&#x60; - Enum to specify a boolean data type. * &#x60;json&#x60; - Enum to specify a json data type. * &#x60;enum&#x60; - Enum to specify a enum data type which is a list of pre-defined strings. | [optional] [default to "string"]

## Examples

- Prepare the resource
```powershell
$WorkflowPrimitiveDataPropertyAllOf = Initialize-IntersightWorkflowPrimitiveDataPropertyAllOf  -ClassId null `
 -ObjectType null `
 -Constraints null `
 -InventorySelector null `
 -Secure null `
 -Type null
```

- Convert the resource to JSON
```powershell
$WorkflowPrimitiveDataPropertyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

