# WorkflowCustomDataTypeDefinitionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassId** | **String** | The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. | [default to "workflow.CustomDataTypeDefinition"]
**ObjectType** | **String** | The fully-qualified name of the instantiated, concrete type. The value should be the same as the &#39;ClassId&#39; property. | [default to "workflow.CustomDataTypeDefinition"]
**CompositeType** | **Boolean** | When true this data type definition is a collection of type definitions to represent composite data like JSON. | [optional] [default to $false]
**Description** | **String** | A human-friendly description of this custom data type indicating it&#39;s domain and usage. | [optional] 
**Label** | **String** | A user friendly short name to identify the custom data type definition. Label can only contain letters (a-z, A-Z), numbers (0-9), hyphen (-), period (.), colon (:), space ( ), single quote (&#39;), or an underscore (_). | [optional] 
**Name** | **String** | The name of custom data type definition. The valid name can contain lower case and upper case alphabetic characters, digits and special characters &#39;-&#39; and &#39;_&#39;. | [optional] 
**ParameterSet** | [**WorkflowParameterSet[]**](WorkflowParameterSet.md) |  | [optional] 
**TypeDefinition** | [**WorkflowBaseDataType[]**](WorkflowBaseDataType.md) |  | [optional] 
**Catalog** | [**WorkflowCatalogRelationship**](WorkflowCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkflowCustomDataTypeDefinitionAllOf = Initialize-IntersightWorkflowCustomDataTypeDefinitionAllOf  -ClassId null `
 -ObjectType null `
 -CompositeType null `
 -Description null `
 -Label null `
 -Name null `
 -ParameterSet null `
 -TypeDefinition null `
 -Catalog null
```

- Convert the resource to JSON
```powershell
$WorkflowCustomDataTypeDefinitionAllOf | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

