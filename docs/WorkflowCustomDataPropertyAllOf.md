# WorkflowCustomDataPropertyAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CatalogMoid** | **String** | Specify the catalog moid that this custom data type belongs. | [optional] 
**CustomDataTypeId** | **String** | The resolved custom data type definition managed object. | [optional] [readonly] 
**CustomDataTypeName** | **String** | Name of the custom data type for this input. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowCustomDataPropertyAllOf  -CatalogMoid null `
 -CustomDataTypeId null `
 -CustomDataTypeName null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

