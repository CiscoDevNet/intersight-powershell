# WorkflowPrimitiveDataProperty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
**Constraints** | [**WorkflowConstraints**](WorkflowConstraints.md) |  | [optional] 
**InventorySelector** | [**WorkflowMoReferenceProperty[]**](WorkflowMoReferenceProperty.md) |  | [optional] 
**Secure** | **Boolean** | Intersight supports secure properties as task input/output. The values of these properties are encrypted and stored in Intersight. This flag marks the property to be secure when it is set to true. | [optional] 
**Type** | **String** | Specify the enum type for primitive data type. | [optional] [default to "string"]

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowPrimitiveDataProperty  -ClassId null `
 -ObjectType null `
 -Constraints null `
 -InventorySelector null `
 -Secure null `
 -Type null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

