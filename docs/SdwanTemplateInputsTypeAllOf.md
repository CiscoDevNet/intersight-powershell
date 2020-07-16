# SdwanTemplateInputsTypeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Editable** | **Boolean** | Defines if the input is editable. | [optional] 
**Key** | **String** | Name of the dynamic input key specified in the vManage template. | [optional] 
**Required** | **Boolean** | Defines if the input is optional or required. | [optional] 
**Template** | **String** | Refers to the name of the vManage template that this inputs belongs to. | [optional] [readonly] 
**Title** | **String** | Label for the property being saved in the current instance of template Input. | [optional] 
**Type** | **String** | Defines the object type for the input. | [optional] 
**Value** | **String** | Value of the dynamic input key specfied in the vManage template. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightSdwanTemplateInputsTypeAllOf  -Editable null `
 -Key null `
 -Required null `
 -Template null `
 -Title null `
 -Type null `
 -Value null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

