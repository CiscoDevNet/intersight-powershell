# WorkflowPrimitiveDataPropertyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Constraints** | [**WorkflowConstraints**](WorkflowConstraints.md) |  | [optional] 
**InventorySelector** | [**WorkflowMoReferenceProperty[]**](WorkflowMoReferenceProperty.md) |  | [optional] 
**Secure** | **Boolean** | Intersight supports secure properties as task input/output. The values of these properties are encrypted and stored in Intersight. This flag marks the property to be secure when it is set to true. | [optional] 
**Type** | **String** | Specify the enum type for primitive data type. | [optional] [default to "string"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowPrimitiveDataPropertyAllOf  -Constraints null `
 -InventorySelector null `
 -Secure null `
 -Type null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

