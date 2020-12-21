# WorkflowBaseDataType
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. The enum values provides the list of concrete types that can be instantiated from this abstract type. | 
**Default** | [**WorkflowDefaultValue**](WorkflowDefaultValue.md) |  | [optional] 
**Description** | **String** | Provide a detailed description of the data type. | [optional] 
**DisplayMeta** | [**WorkflowDisplayMeta**](WorkflowDisplayMeta.md) |  | [optional] 
**InputParameters** | [**AnyType**](.md) | JSON formatted mapping from other property of the definition to the current property. Input parameter mapping is supported only for custom data type property in workflow definition and custom data type definition. The format to specify mapping ina workflow definition when source property is of scalar types is &#39;${workflow.input.property}&#39;. The format to specify mapping when the source property is of object reference and mapping needs to be made to the property of the object is &#39;${workflow.input.property.subproperty}&#39;. The format to specify mapping in a custom data type definition is &#39;${datatype.type.property}&#39;. When the current property is of non-scalar type like composite custom data type, then mapping can be provided to the individual property of the custom data type like &#39;cdt_property:${workflow.input.property}&#39;. | [optional] 
**Label** | **String** | Descriptive label for the data type. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), space ( ) or an underscore (_). The first and last character in label must be an alphanumeric character. | [optional] 
**Name** | **String** | Descriptive name for the data type. Name can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-) or an underscore (_). The first and last character in name must be an alphanumeric character. | [optional] 
**Required** | **Boolean** | Specifies whether this parameter is required. The field is applicable for task and workflow. | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowBaseDataType = Initialize-IntersightWorkflowBaseDataType  -ClassId null `
 -ObjectType null `
 -Default null `
 -Description null `
 -DisplayMeta null `
 -InputParameters null `
 -Label null `
 -Name null `
 -Required null
```

- Convert the resource to JSON
```powershell
$WorkflowBaseDataType | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

