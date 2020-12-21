# WorkflowCustomDataPropertyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.CustomDataProperty"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.CustomDataProperty"]
**CatalogMoid** | **String** | Specify the catalog moid that this custom data type belongs. | [optional] 
**CustomDataTypeId** | **String** | The resolved custom data type definition managed object. | [optional] [readonly] 
**CustomDataTypeName** | **String** | Name of the custom data type for this input. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowCustomDataPropertyAllOf = Initialize-IntersightWorkflowCustomDataPropertyAllOf  -ClassId null `
 -ObjectType null `
 -CatalogMoid null `
 -CustomDataTypeId null `
 -CustomDataTypeName null
```

- Convert the resource to JSON
```powershell
$WorkflowCustomDataPropertyAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

