# OsPlaceHolderAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsValueSet** | **Boolean** | Flag to indicate if value is set. Value will be used to check if any edit. | [optional] 
**Type** | [**WorkflowPrimitiveDataType**](WorkflowPrimitiveDataType.md) |  | [optional] 
**Value** | [**AnyType**](.md) | Value for placeholder provided by user. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightOsPlaceHolderAllOf  -IsValueSet null `
 -Type null `
 -Value null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

