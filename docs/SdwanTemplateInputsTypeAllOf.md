# SdwanTemplateInputsTypeAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "sdwan.TemplateInputsType"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "sdwan.TemplateInputsType"]
**Editable** | **Boolean** | Defines if the input is editable. | [optional] [default to $false]
**Key** | **String** | Name of the dynamic input key specified in the vManage template. | [optional] 
**Required** | **Boolean** | Defines if the input is optional or required. | [optional] [default to $false]
**Template** | **String** | Refers to the name of the vManage template that this inputs belongs to. | [optional] [readonly] 
**Title** | **String** | Label for the property being saved in the current instance of template Input. | [optional] 
**Type** | **String** | Defines the object type for the input. | [optional] [default to "string"]
**Value** | **String** | Value of the dynamic input key specfied in the vManage template. | [optional] 

## Examples

- Prepare the resource
```powershell
$SdwanTemplateInputsTypeAllOf = Initialize-IntersightSdwanTemplateInputsTypeAllOf  -ClassId null `
 -ObjectType null `
 -Editable null `
 -Key null `
 -Required null `
 -Template null `
 -Title null `
 -Type null `
 -Value null
```

- Convert the resource to JSON
```powershell
$SdwanTemplateInputsTypeAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

