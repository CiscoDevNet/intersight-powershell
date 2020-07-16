# WorkflowCustomDataTypeDefinitionAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompositeType** | **Boolean** | When true this data type definition is a collection of type definitions to represent composite data like JSON. | [optional] 
**Description** | **String** | A human-friendly description of this custom data type indicating it&#39;s domain and usage. | [optional] 
**Label** | **String** | A user friendly short name to identify the custom data type definition. | [optional] 
**Name** | **String** | The name of custom data type definition. The valid name can contain lower case and upper case alphabetic characters, digits and special characters &#39;-&#39; and &#39;_&#39;. | [optional] 
**TypeDefinition** | [**WorkflowBaseDataType[]**](WorkflowBaseDataType.md) |  | [optional] 
**Catalog** | [**WorkflowCatalogRelationship**](WorkflowCatalogRelationship.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightWorkflowCustomDataTypeDefinitionAllOf  -CompositeType null `
 -Description null `
 -Label null `
 -Name null `
 -TypeDefinition null `
 -Catalog null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

