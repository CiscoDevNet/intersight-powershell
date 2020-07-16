# SdwanTemplateInputsType
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The concrete type of this complex type. Its value must be the same as the &#39;objectType&#39; property. The OpenAPI document references this property as a discriminator value. | [readonly] 
**ObjectType** | **String** | The concrete type of this complex type. The ObjectType property must be set explicitly by API clients when the type is ambiguous. In all other cases, the  ObjectType is optional.  The type is ambiguous when a managed object contains an array of nested documents, and the documents in the array are heterogeneous, i.e. the array can contain nested documents of different types. | 
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
Initialize-IntersightSdwanTemplateInputsType  -ClassId null `
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
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

